using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Google.Protobuf;
using netutils;
using CenturyGame.Framework.Base;
using CenturyGame.Framework.Network;
using UnityEngine;
using UnityEngine.Networking;

namespace ProtokitHelper
{
    public delegate void DelegateRecvProto(int sequenceId, string passThrough, string uri, byte[] data);
    public delegate void DelegateRecvPacketFinish(int sequenceId);
    public delegate void DelegateHttpResponseFailed(int statusCode, string statusName);
    public delegate void DelegateRecvProtoBytes(string uri, byte[] data);
    public delegate void DelegateRecvCommonError(int code, string message);

    public class ProtokitHttpClient : Singleton<ProtokitHttpClient>
    {
        /// <summary>
        /// 超时时间(毫秒)
        /// </summary>
        private int timeOutms = 15000;
        /// <summary>
        /// 消息预期返回时间
        /// </summary>
        private float timeExpect = 0.5f;
        //private ResourcePool<HttpProtoRequest> RequestPool = new ResourcePool<HttpProtoRequest>(() => new HttpProtoRequest(), HttpProtoRequest.Init, null);
        private Queue<HttpProtoRequest> SequentialRequests = new Queue<HttpProtoRequest>(256);
        private Queue<HttpRawProto> SequentialRawProtos = new Queue<HttpRawProto>(1024);
        private Dictionary<string, Action<IMessage>> ReqeustMsgHandlerMap = new Dictionary<string, Action<IMessage>>();
        private Dictionary<string, DelegateRecvProtoBytes> RequestBytesHandlerMap = new Dictionary<string, DelegateRecvProtoBytes>();
        private HttpProtoRequest CurRequest;
        private HttpProtoRequest LastFailedRequest;
        private Dictionary<int, RequestBatchRecord> RequestBatchRecordMap = new Dictionary<int, RequestBatchRecord>();
        /// <summary>
        /// 是否允许请求
        /// </summary>
        private bool EnableSendRequest = false;
        /// <summary>
        /// 消息最大合并数
        /// </summary>
        public int MaxBatchCount { get; private set; } = 1;
        /// <summary>
        /// 重发次数
        /// </summary>
        private int MaxRetry = 3;
        /// <summary>
        /// 消息接收
        /// </summary>
        public event DelegateRecvProto Evt_RecvMsg;
        /// <summary>
        /// 消息包解析完成
        /// </summary>
        public event DelegateRecvPacketFinish Evt_RecvPackFinish;
        /// <summary>
        /// 请求返回了底层错误
        /// </summary>
        public event DelegateRecvCommonError Evt_RecvCommonError;
        /// <summary>
        /// 返回了错误的状态码
        /// </summary>
        public event DelegateHttpResponseFailed Evt_RspFailed;
        /// <summary>
        /// Update轮询
        /// </summary>
        public event Action Evt_Update;
        /// <summary>
        /// 开始发送请求
        /// </summary>
        public event Action Evt_ReqBegin;
        /// <summary>
        /// 一次请求结束
        /// </summary>
        public event Action Evt_ReqEnd;
        /// <summary>
        /// 请求失败
        /// </summary>
        public event Action Evt_ReqFailed;
        /// <summary>
        /// 请求超出预期时间
        /// </summary>
        public event Action Evt_ReqTimeOutExpect;

        public HttpClient HttpAgent { get; } = new HttpClient();

        /// <summary>
        /// 是否允许使用queue模式合并请求
        /// </summary>
        public bool EnableBatchRequest { get; private set; }

        /// <summary>
        /// 是否允许自动重发
        /// </summary>
        public bool EnableAutoRetry { get; private set; }

        /// <summary>
        /// user token
        /// </summary>
        public string HttpToken { get; private set; }

        //private StringBuilder sb = new StringBuilder();

        public void Init(bool queueMode, bool autoRetry, int batchLimit = 1)
        {
            EnableSendRequest = true;
            EnableBatchRequest = queueMode;
            EnableAutoRetry = autoRetry;
            MaxBatchCount = batchLimit;
        }

        public void SetHttpToken(string token)
        {
            HttpToken = token;
        }

        /// <summary>
        /// 设置超时时间（单位:毫秒）
        /// </summary>
        /// <param name="ms"></param>
        public void SetTimeOut(int ms)
        {
            timeOutms = ms;
        }

        /// <summary>
        /// 设置重试次数
        /// </summary>
        /// <param name="count"></param>
        public void SetRetryLimit(int count)
        {
            MaxRetry = count;
        }

        /// <summary>
        /// 设置消息预期返回时间
        /// </summary>
        /// <param name="time"></param>
        public void SetExpectTime(float time)
        {
            timeExpect = time;
        }

        public void PostRequestMsg(string url, IMessage msg, Action<IMessage> callback = null, bool waitResponse = true)
        {
            HttpRawProto httpRawProto = new HttpRawProto
            {
                Url = url,
                RawProto = ProtokitUtil.Instance.GetRawPorto(msg),
                Method = HttpMethod.Post
            };
            if (callback != null)
            {
                ReqeustMsgHandlerMap.Add(httpRawProto.RawProto.Passthrough, callback);
            }
            SequentialRawProtos.Enqueue(httpRawProto);
        }

        public void PostRequestBytes(string url, byte[] sendData, bool waitResponse = true)
        {
            HttpProtoRequest request = new HttpProtoRequest
            {
                SendData = sendData,
                Url = url,
                Method = HttpMethod.Post
            };
            SequentialRequests.Enqueue(request);
        }

        public void Update()
        {
            Evt_Update?.Invoke();
            //UpdateSequentialRawProto();
            UpdateSequentialRequest();
        }

        private void UpdateSequentialRawProto()
        {
            if (EnableBatchRequest)
            {
                if (SequentialRawProtos.Count > 0)
                {
                    HttpProtoRequest request = new HttpProtoRequest();
                    RawPacket rp = new RawPacket
                    {
                        Version = 1,
                        SequenceID = ProtokitUtil.Instance.GetSequenceId()
                    };
                    request.SequenceId = rp.SequenceID;
                    RequestBatchRecord batchRecordItem = ProtokitUtil.Instance.GetRequestBatchRecord();
                    batchRecordItem.SequenceID = rp.SequenceID;
                    int batchCount = 0;
                    while (SequentialRawProtos.Count > 0 && batchCount < MaxBatchCount)
                    {
                        var httpRawProto = SequentialRawProtos.Peek();
                        if (batchCount == 0)
                        {
                            request.Url = httpRawProto.Url;
                            request.Method = httpRawProto.Method;
                            httpRawProto = SequentialRawProtos.Dequeue();
                        }
                        else
                        {
                            //如果单个请求地址或者方法与合并请求的地址或方法不同不同，则不合并
                            if (!request.Url.Equals(httpRawProto.Url) || !request.Method.Equals(httpRawProto.Method))
                                break;
                            else
                                httpRawProto = SequentialRawProtos.Dequeue();
                        }
                        RawAny rawAny = new RawAny
                        {
                            Uri = httpRawProto.RawProto.MsgUri,
                            Raw = httpRawProto.RawProto.MsgRaw,
                            PassThrough = httpRawProto.RawProto.Passthrough
                        };
                        rp.RawAny.Add(rawAny);
                        batchRecordItem.Requests.Add(rawAny.PassThrough, rawAny.Uri);
                        batchRecordItem.SendLog.Enqueue($"[HTTP][Send] {httpRawProto.RawProto.ProtoLog}");
                        batchCount++;
                    }
                    RequestBatchRecordMap.Add(batchRecordItem.SequenceID, batchRecordItem);
                    using (var stream = new MemoryStream())
                    {
                        rp.WriteTo(stream);
                        byte[] data = stream.ToArray();
                        request.SendData = data;
                    }
                    SequentialRequests.Enqueue(request);
                }
            }
            else
            {
                while (SequentialRawProtos.Count > 0)
                {
                    HttpProtoRequest request = new HttpProtoRequest();
                    RawPacket rp = new RawPacket
                    {
                        Version = 1,
                        SequenceID = ProtokitUtil.Instance.GetSequenceId()
                    };
                    request.SequenceId = rp.SequenceID;
                    RequestBatchRecord batchRecordItem = ProtokitUtil.Instance.GetRequestBatchRecord();
                    batchRecordItem.SequenceID = rp.SequenceID;
                    var httpRawProto = SequentialRawProtos.Dequeue();
                    RawAny rawAny = new RawAny
                    {
                        Uri = httpRawProto.RawProto.MsgUri,
                        Raw = httpRawProto.RawProto.MsgRaw,
                        PassThrough = httpRawProto.RawProto.Passthrough
                    };
                    rp.RawAny.Add(rawAny);
                    batchRecordItem.Requests.Add(rawAny.PassThrough, rawAny.Uri);
                    batchRecordItem.SendLog.Enqueue($"[HTTP][Send] {httpRawProto.RawProto.ProtoLog}");
                    RequestBatchRecordMap.Add(batchRecordItem.SequenceID, batchRecordItem);
                    using (var stream = new MemoryStream())
                    {
                        rp.WriteTo(stream);
                        byte[] data = stream.ToArray();
                        request.Url = httpRawProto.Url;
                        request.Method = httpRawProto.Method;
                        request.SendData = data;
                    }
                    SequentialRequests.Enqueue(request);
                }
            }
        }

        private void UpdateSequentialRequest()
        {
            if (!EnableSendRequest)
                return;
            if (CurRequest != null)
            {
                if (CurRequest.State == ProtoHttpRequestState.Reqeusting)
                {
                    if (!CurRequest.RequestOutExpectTimeInvoked && IsRequestOutExpectTime(CurRequest))
                    {
                        CurRequest.RequestOutExpectTimeInvoked = true;
                        OnResponseOutExpectTime();
                    }
                }
                else if (CurRequest.State == ProtoHttpRequestState.Reqeusted)
                {
                    OnRequestEnd();
                    if (EnableAutoRetry && CurRequest.RequestCount <= MaxRetry)
                    {
                        OnRequestBegin();
                        SendRequestAsync(CurRequest);
                    }
                    else
                    {
                        LastFailedRequest = CurRequest;
                        CurRequest = null;
                        EnableSendRequest = false;
                        OnRequestFailed();
                    }
                }
                else if (CurRequest.State == ProtoHttpRequestState.Responsed)
                {
                    OnRequestEnd();
                    //RequestPool.Recycle(CurRequest);
                    CurRequest = null;
                }
            }
            else
            {
                UpdateSequentialRawProto();
                if (SequentialRequests.Count > 0)
                {
                    CurRequest = SequentialRequests.Dequeue();
                    OnRequestBegin();
                    SendRequestAsync(CurRequest);
                }
            }
        }

        private bool IsRequestOutExpectTime(HttpProtoRequest request)
        {
            if (request.EndTime == 0)
            {
                if (Time.realtimeSinceStartup - request.StartTime > timeExpect)
                    return true;
            }
            else
            {
                if (request.EndTime - request.StartTime > timeExpect)
                    return true;
            }
            return false;
        }

        private async void SendRequestAsync(HttpProtoRequest request)
        {
            try
            {
                request.State = ProtoHttpRequestState.Reqeusting;
                request.RequestOutExpectTimeInvoked = false;
                request.StartTime = Time.realtimeSinceStartup;
                request.EndTime = 0;
                request.ResultCode = 0;
                request.RequestCount++;
                HttpRequestMessage req = new HttpRequestMessage(request.Method, request.Url)
                {
                    Content = new ByteArrayContent(request.SendData)
                };
                var Header = ProtokitUtil.Instance.GetHttpRequestHeader(request, HttpToken);
                if (Header != null)
                {
                    foreach (var p in Header)
                    {
                        if (p.Key.Equals("Content-Type"))
                        {
                            req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(p.Value);
                        }
                        else
                        {
                            req.Content.Headers.TryAddWithoutValidation(p.Key, p.Value);
                        }
                    }
                }
                if (RequestBatchRecordMap.ContainsKey(request.SequenceId))
                    RequestBatchRecordMap[request.SequenceId].TraceLog();
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeOutms);
                HttpResponseMessage rsp = await HttpAgent.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token);
                request.ResultCode = (int)rsp.StatusCode;
                if (rsp.IsSuccessStatusCode)
                {
                    byte[] retData = await rsp.Content.ReadAsByteArrayAsync();
                    request.State = ProtoHttpRequestState.Responsed;
                    request.EndTime = Time.realtimeSinceStartup;
                    OnResponseSuccess(retData);
                }
                else
                {
                    request.State = ProtoHttpRequestState.Reqeusted;
                    OnResponseFailed(request.ResultCode, rsp.StatusCode.ToString());
                }
            }
            catch (Exception e)
            {
                request.State = ProtoHttpRequestState.Reqeusted;
                string exceptionType = "UnknownError";
                if (e is ArgumentNullException)
                {
                    exceptionType = "ArgumentNull";
                }
                else if (e is InvalidOperationException)
                {
                    exceptionType = "InvalidOperation";
                }
                else if (e is HttpRequestException)
                {
                    if (e.InnerException is WebException)
                    {
                        WebException webException = e.InnerException as WebException;
                        exceptionType = webException.Status.ToString();
                        request.ResultCode = (int)webException.Status;
                    }
                    else
                    {
                        HttpRequestException httpRequestException = e as HttpRequestException;
                        request.ResultCode = httpRequestException.HResult;
                    }
                }
                else if (e is TaskCanceledException)
                {
                    request.ResultCode = (int)HttpStatusCode.RequestTimeout;
                    exceptionType = "RequestTimeout";
                }
                OnResponseFailed(request.ResultCode, exceptionType);
            }
        }

        private void OnResponseSuccess(byte[] data)
        {
            RawPacket rp;
            try
            {
                rp = RawPacket.Parser.ParseFrom(data);
            }
            catch (Exception e)
            {
                Debug.LogErrorFormat("Exception throw :{0} on parsing data", e.Message);
                return;
            }
            for (int i = 0; i < rp.RawAny.Count; i++)
            {
                string name = rp.RawAny[i].Uri;
                byte[] rawdata = rp.RawAny[i].Raw.ToByteArray();
                string passthrough = rp.RawAny[i].PassThrough;
                RecvMsg(rp.SequenceID, passthrough, name, rawdata);
            }
            Evt_RecvPackFinish?.Invoke(rp.SequenceID);
            ClearSequenceHandler(rp.SequenceID);
        }

        private void OnResponseFailed(int statusCode, string statusName)
        {
            Evt_RspFailed?.Invoke(statusCode, statusName);
        }

        /// <summary>
        /// 超出预期请求时间，可能需要显示转圈界面，当请求结束时关闭转圈界面
        /// </summary>
        private void OnResponseOutExpectTime()
        {
            Evt_ReqTimeOutExpect?.Invoke();
        }

        /// <summary>
        /// 请求开始
        /// </summary>
        private void OnRequestBegin()
        {
            Evt_ReqBegin?.Invoke();
        }

        /// <summary>
        /// 请求结束
        /// </summary>
        private void OnRequestEnd()
        {
            Evt_ReqEnd?.Invoke();
        }

        /// <summary>
        /// 请求达到重试次数上限仍未成功，可弹窗提示用户确认网络状况后手动重试(调用Retry)，或者停止HttpClient的所有请求(调用Stop)后退回登录界面
        /// </summary>
        private void OnRequestFailed()
        {
            Evt_ReqFailed?.Invoke();
        }

        private void RecvMsg(int sequenceId, string passthrough, string uri, byte[] data)
        {
            try
            {
                //sb.Length = 0;
                //sb.AppendFormat("[HTTP][Recv] name:{0}", uri);
                if (ReqeustMsgHandlerMap.ContainsKey(passthrough))
                {
                    var parser = ProtokitUtil.Instance.GetParser(uri);
                    if (parser != null)
                    {
                        var message = parser.ParseFrom(data);
                        //sb.AppendFormat(", body:{0}", message);
                        ReqeustMsgHandlerMap[passthrough].Invoke(message);
                    }
                    else
                        Debug.LogWarning($"ProtokitHttpClient can't find request parser, uri={uri}, sequenceId={sequenceId}, passthrough={passthrough}");
                    ReqeustMsgHandlerMap.Remove(passthrough);
                }
                if (RequestBytesHandlerMap.ContainsKey(passthrough))
                {
                    RequestBytesHandlerMap[passthrough].Invoke(uri, data);
                    RequestBytesHandlerMap.Remove(passthrough);
                }
                if (uri.Equals(ErrorResponse.Descriptor.FullName))
                {
                    ErrorResponse errMsg = ErrorResponse.Parser.ParseFrom(data);
                    //sb.AppendFormat(", body:{0}", errMsg);
                    if (!errMsg.LogicException)
                    {
                        RecvCommonError(sequenceId, passthrough, errMsg);
                    }
                }
                //Debug.Log(sb);
                Evt_RecvMsg?.Invoke(sequenceId, passthrough, uri, data);
            }
            catch (Exception e)
            {
                Debug.LogErrorFormat($"ProtokitHttpClient RecvMsg catch exception : {e.Message}, sequenceId={sequenceId}, passthrough={passthrough}, uri={uri}");
            }
        }

        private void RecvCommonError(int sequenceId, string passthrough, ErrorResponse msg)
        {
            string ErrReqUri = string.Empty;
            if (RequestBatchRecordMap.ContainsKey(sequenceId))
            {
                if (RequestBatchRecordMap[sequenceId].Requests.ContainsKey(passthrough))
                    ErrReqUri = RequestBatchRecordMap[sequenceId].Requests[passthrough];
            }
            Evt_RecvCommonError?.Invoke(msg.Code, msg.Message);
        }

        private void ClearSequenceHandler(int sequenceId)
        {
            if (RequestBatchRecordMap.ContainsKey(sequenceId))
            {
                var batch = RequestBatchRecordMap[sequenceId];
                var e = batch.Requests.GetEnumerator();
                while (e.MoveNext())
                {
                    ReqeustMsgHandlerMap.Remove(e.Current.Key);
                }
                RequestBatchRecordMap.Remove(sequenceId);
                ProtokitUtil.Instance.RecycleRequestBatch(batch);
            }
        }

        public void Stop()
        {
            HttpAgent.CancelPendingRequests();
            SequentialRequests.Clear();
            ReqeustMsgHandlerMap.Clear();
            RequestBatchRecordMap.Clear();
            CurRequest = null;
            LastFailedRequest = null;
            EnableSendRequest = false;
        }

        public bool Retry()
        {
            if (LastFailedRequest == null)
            {
                Debug.LogWarning("手动重发请求失败，找不到上次发送失败的请求");
                return false;
            }
            else if (CurRequest != null)
            {
                Debug.LogWarning("手动重发请求失败，当前已有新的请求被发送过");
                return false;
            }
            else
            {
                CurRequest = LastFailedRequest;
                EnableSendRequest = true;
                OnRequestBegin();
                SendRequestAsync(CurRequest);
                return true;
            }
        }
    }
}