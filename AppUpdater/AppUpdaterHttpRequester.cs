/***************************************************************

 *  类名称：        AppUpdaterHttpRequester

 *  描述：				

 *  作者：          Chico(wuyuanbing)

 *  创建时间：      2020/5/19 16:21:59

 *  最后修改人：

 *  版权所有 （C）:   diandiangames

***************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using CenturyGame.AppUpdaterLib.Runtime;
using CenturyGame.AppUpdaterLib.Runtime.Configs;
using CenturyGame.AppUpdaterLib.Runtime.Interfaces;
using CenturyGame.AppUpdaterLib.Runtime.Managers;
using CenturyGame.AppUpdaterLib.Runtime.Protocols;
using CenturyGame.Core.Functional;
using CenturyGame.Framework.Http;
using CenturyGame.LoggerModule.Runtime;
using Google.Protobuf;
using gen.msg;
using netutils;
using UnityEngine;
using ILogger = CenturyGame.LoggerModule.Runtime.ILogger;

namespace CenturyGame.Game
{
    using IMessage = Google.Protobuf.IMessage;
    public class AppUpdaterHttpRequester : IAppUpdaterRequester
    {

        #region Enums & Inner Class

        public enum InnerState
        {
            Idle,

            StartRequest,

            Requesting,

            WaitForReq,

            RequestAgain,

            RequestingAgain,

            RequestCompleted,

            RequestFailure
        }

        #endregion

        //--------------------------------------------------------------
        #region Fields
        //--------------------------------------------------------------

        private static ILogger s_mLogger = LoggerManager.GetLogger("AppUpdaterHttpRequester");

        public HttpManager mHttpManager;

        private static int DefaultUrlsReqIndex = -1;

        private InnerState mInnerState = InnerState.Idle;

        /// <summary>
        /// 对应于EntryPointResponse返回
        /// </summary>
        private Action<GetVersionResponseInfo> mGetVersionInfoEvent = null;

        private GetVersionResponseInfo mReqResult = null;

        /// <summary>
        /// 请求的服务器的url列表，包括主服务器和fallback列表
        /// </summary>
        public string[] UrlList;
        public string CurrentUrl => UrlList[mCurReqUrlIndex];

        /// <summary>
        /// 当前请求的
        /// </summary>
        private int mCurReqUrlIndex = DefaultUrlsReqIndex;

        private EntryPointRequest mCurRequest;
        private string mAppVersion;
        private string mChannel;

        private float mStartTime = 0;
        private float mReqInternal = 3f;

        public Action WhenSuccess;

        #endregion

        //--------------------------------------------------------------
        #region Properties & Events
        //--------------------------------------------------------------

        public InnerState State => mInnerState;

        #endregion

        //--------------------------------------------------------------
        #region Creation & Cleanup
        //--------------------------------------------------------------

        public AppUpdaterHttpRequester(HttpManager httpManager)
        {
            mHttpManager = httpManager;
        }

        #endregion

        //--------------------------------------------------------------
        #region Methods
        //--------------------------------------------------------------

        public void Update()
        {
            switch (mInnerState)
            {
                case InnerState.StartRequest:
                    StartRequestToHttpServer();
                    break;
                case InnerState.WaitForReq:
                    WaitingForRequestToHttpServer();
                    break;
                case InnerState.RequestAgain:
                    StartRequestToHttpServerAgain();
                    break;
                case InnerState.RequestCompleted:
                    OnReqCompleted();
                    break;
                case InnerState.RequestFailure:
                    OnReqFailure();
                    break;
            }
        }

        public void ReqGetVersion(LighthouseConfig.Server serverData, string appVersion, string lighthouseId,string channel , FileServerType fromTo, Action<GetVersionResponseInfo> getVersionResponseInfoAction)
        {
            Clear();
            UrlList = new string[serverData.FallbackUrlList.Count + 1];
            UrlList[0] = serverData.Url;
            serverData.FallbackUrlList.ForCall((x, index) => { UrlList[index+1] = x; });

            s_mLogger.Debug($"[appVersion : {appVersion}] [lighthouseId : {lighthouseId}] [channel : {channel}] [fromTo : {fromTo}] .");

            mAppVersion = appVersion;
            mChannel = channel;
            mGetVersionInfoEvent = getVersionResponseInfoAction;
            
            mCurRequest = new EntryPointRequest();
            mCurRequest.AppVersion = appVersion;
            mCurRequest.LighthouseId = lighthouseId;
            mCurRequest.From = (fromTo == FileServerType.CDN) ? EntryPointFromType.Cdn : EntryPointFromType.Oss;

            mInnerState = InnerState.StartRequest;
        }

        private void Clear()
        {
            mInnerState = InnerState.Idle;
            mGetVersionInfoEvent = null;
            mReqResult = null;
            UrlList = null;
            mCurReqUrlIndex= DefaultUrlsReqIndex;
            mCurRequest = null;
        }

        private void OnReqCompleted()
        {
            WhenSuccess?.Invoke();
            mGetVersionInfoEvent?.Invoke(mReqResult);
            Clear();
        }

        private void OnReqFailure()
        {
            mGetVersionInfoEvent?.Invoke(null);
            Clear();
        }

        private RawPacket GenRawPacket(IMessage msg, string passthrough)
        {
            var rp = new RawPacket
            {
            };
            using (var stream = new MemoryStream())
            {
                msg.WriteTo(stream);
                var rawAny = new RawAny
                {
                    Uri = msg.Descriptor.FullName,
                    Raw = ByteString.CopyFrom(stream.ToArray()),
                    PassThrough = passthrough,
                };
                rp.RawAny.Add(rawAny);
                rp.Version = 1;
            }
            return rp;

        }

        private byte[] GetRawPacketData(RawPacket rp)
        {
            using (var stream = new MemoryStream())
            {
                rp.WriteTo(stream);
                return stream.ToArray();
            }
        }


        private void StartRequestToHttpServer()
        {
            mInnerState = InnerState.Requesting;
            StartRequestToHttpServerInternal();
        }

        private void StartRequestToHttpServerAgain()
        {
            mInnerState = InnerState.RequestingAgain;
            StartRequestToHttpServerInternal();
        }


        private bool CheckEntryPointResponseValid(EntryPointResponse response)
        {
            s_mLogger.Debug($"forceUpdate:{response.ForceUpdate} maintenance:{response.Maintenance} lighthouseId:{response.LighthouseId}");

            if (string.IsNullOrEmpty(response.LighthouseId))
            {
                s_mLogger.Error("Invalid LighthouseId!");
                return false;
            }

            if (response.ResourceDetail == null)
            {
                s_mLogger.Error("Invalid ResourceDetail!");
                return false;
            }
            if (response.ResourceDetail.AndroidVersion == null
                && response.ResourceDetail.IOSVersion == null)  {
                s_mLogger.Error("Invalid ResVersion!");
                return false;
            }
            return true;
        }

        private void SetMetadata(RawPacket rp)
        {
            rp.Metadata.Add(MetadataKey.AppVersion.ToString());
            rp.Metadata.Add(mAppVersion);

            rp.Metadata.Add(MetadataKey.Channel.ToString());
            rp.Metadata.Add(mChannel);

            rp.Metadata.Add(MetadataKey.Language.ToString());
            rp.Metadata.Add("en");

            var clientUniqueId = AppUpdaterManager.ClientUniqueId;
            if (!string.IsNullOrEmpty(clientUniqueId))
            {
                s_mLogger.Debug($"clientUniqueId : {clientUniqueId}");
                rp.Metadata.Add(MetadataKey.ClientId.ToString());
                rp.Metadata.Add(clientUniqueId);
            }
        }

        private void StartRequestToHttpServerInternal()
        {
            mCurReqUrlIndex++;
            
            var rp = GenRawPacket(mCurRequest, (DateTime.Now).ToString("yyyyMMddHHmmssffff"));
            SetMetadata(rp);

            var header = new Dictionary<string, string>
            {
                {"Content-Type", "application/x-protobuf"}, {"charset", "utf-8"}
            };

            var curUrl = UrlList[mCurReqUrlIndex] + "/lighthouse";
            s_mLogger.Info($"Current req url : {curUrl} !");
            mHttpManager.PostHttpRequest(curUrl, header, GetRawPacketData(rp), recvData =>
            {
                if (recvData == null || recvData.Length == 0)
                {
                    mInnerState = InnerState.WaitForReq;
                    mStartTime = Time.realtimeSinceStartup;
                    return;
                }

                var result = new GetVersionResponseInfo();
                var receiveData = RawPacket.Parser.ParseFrom(recvData);
                if (ErrorResponse.Descriptor.FullName.Equals(receiveData.RawAny[0].Uri))
                {
                    var errorMsg = ErrorResponse.Parser.ParseFrom(receiveData.RawAny[0].Raw);
                    s_mLogger.Info($"ErrorResponse code : {errorMsg.Code}");
                    var lighthouse_id = new System.Text.UTF8Encoding(false, true).GetString(errorMsg.Data.ToByteArray());
                    
                    result.lighthouseId = lighthouse_id;                    
                    if (errorMsg.Code == APP_UPDATE_ERROR_CODE.MAINTENANCE)
                    {
                        result.maintenance = true;
                        mReqResult = result;
                        mInnerState = InnerState.RequestCompleted;
                    }
                    else if (errorMsg.Code == APP_UPDATE_ERROR_CODE.FORCE_UPDATE)
                    {
                        result.forceUpdate = true;
                        mReqResult = result;
                        mInnerState = InnerState.RequestCompleted;
                    }
                    else
                    {
                        mInnerState = InnerState.RequestFailure;
                    }
                }
                else
                {
                    var msg = EntryPointResponse.Parser.ParseFrom(receiveData.RawAny[0].Raw);
                    var redirectUrl = msg.RedirectURL;
                    if (!string.IsNullOrEmpty(msg.RedirectURL))
                    {
                        if (!string.Equals(redirectUrl, curUrl))
                        {
                            UrlList = new string[] { redirectUrl };
                            mCurReqUrlIndex = DefaultUrlsReqIndex;
                            mStartTime = Time.realtimeSinceStartup;
                            mInnerState = InnerState.WaitForReq;
                            s_mLogger.Info($"{mReqInternal} seconds to redirect request , redirect url : {msg.RedirectURL} .");
                            return;
                        }
                    }

                    if (CheckEntryPointResponseValid(msg))
                    {
                        result.url = curUrl;
                        result.forceUpdate = msg.ForceUpdate;
                        result.lighthouseId = msg.LighthouseId;
                        result.maintenance = msg.Maintenance;

                        result.update_detail = new ResUpdateDetail();
                        
                        s_mLogger.Debug($"DataVersion : {msg.ResourceDetail.DataVersion}");
                        result.update_detail.DataVersion = msg.ResourceDetail.DataVersion;
                        var versionInfo =  msg.ResourceDetail.AndroidVersion ?? msg.ResourceDetail.IOSVersion;
                        s_mLogger.Debug($"ResVersion : {versionInfo}");
                        result.update_detail.ResVersionNum = versionInfo.Version;
                        result.update_detail.ResVersion = versionInfo.Md5;
                        mReqResult = result;
                        mInnerState = InnerState.RequestCompleted;
                    }
                    else
                    {
                        mInnerState = InnerState.RequestFailure;
                    }
                }
            });
        }


        private void WaitingForRequestToHttpServer()
        {
            if (Time.realtimeSinceStartup - mStartTime > mReqInternal)
            {
                mInnerState = InnerState.RequestAgain;
                s_mLogger.Info("Request again!");
            }
            else
            {
                if (!CheckCurrentUrlValid())
                {
                    mInnerState = InnerState.RequestFailure;
                }
            }
        }

        private bool CheckCurrentUrlValid()
        {
            if (mCurReqUrlIndex >= UrlList.Length - 1)
            {
                return false;
            }

            return true;
        }

#endregion
    }
}
