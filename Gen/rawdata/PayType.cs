// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata/PayType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata/PayType.proto</summary>
  public static partial class PayTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata/PayType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PayTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVyYXdkYXRhL1BheVR5cGUucHJvdG8SB3Jhd2RhdGEqKQoHUGF5VHlwZRIL",
            "CgdEaWFtb25kEAASEQoNT2ZmbGluZVJld2FyZBABQkdaO2JpdGJ1Y2tldC5v",
            "cmcvZnVucGx1cy9zaG9wcGluZy1tYWxsLWRhdGEvZ2VuL2dvbGFuZy9yYXdk",
            "YXRhqgIHcmF3ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::rawdata.PayType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum PayType {
    [pbr::OriginalName("Diamond")] Diamond = 0,
    [pbr::OriginalName("OfflineReward")] OfflineReward = 1,
  }

  #endregion

}

#endregion Designer generated code