using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Google.Protobuf;
using UnityEngine;
using UnityEngine.Networking;
using Transient;
using System;
using netutils;

namespace NS.Bridge {
    public class ProtokitHttp : NetworkHttp {
        public Action<int, string, string, byte[]> WhenOneOfBatchReceived { get; set; }
        public Action<int> WhenBatchDone { get; set; }
        public string AccessToken {
            set {
                var key = "x-fun-user-token";
                DefaultHeader.Remove(key);
                DefaultHeader.TryAddWithoutValidation(key, value);
            }
        }
        
        public void InitWithProtokit() {
            Init();
            WhenReceived = WhenReceivedBatch;
            WhenCompositeContent = WhenComposite;
            DefaultHeader.TryAddWithoutValidation("Connection", "keep-alive");
        }

        private void WhenComposite(HttpContent content_) {
            content_.Headers.TryAddWithoutValidation("x-fun-request-id", "0");//TODO
            content_.Headers.TryAddWithoutValidation("Content-Type", "application/x-protobuf");
        }

        private void WhenReceivedBatch(byte[] data_) {
            try {
                var packet = RawPacket.Parser.ParseFrom(data_);
                foreach (var response in packet.RawAny) {
                    WhenOneOfBatchReceived(packet.SequenceID,
                        response.PassThrough,
                        response.Uri,
                        response.Raw.ToByteArray());
                }
                WhenBatchDone?.Invoke(packet.SequenceID);
            }
            catch (System.Exception e) {
                Debug.LogErrorFormat("Exception throw :{0} on parsing data", e.Message);
            }
        }
    }
}