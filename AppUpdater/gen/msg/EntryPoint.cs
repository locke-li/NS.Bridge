// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: msg/entry_point.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace gen.msg {

  /// <summary>Holder for reflection information generated from msg/entry_point.proto</summary>
  public static partial class EntryPointReflection {

    #region Descriptor
    /// <summary>File descriptor for msg/entry_point.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntryPointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVtc2cvZW50cnlfcG9pbnQucHJvdG8SA21zZyKZAQoRRW50cnlQb2ludFJl",
            "cXVlc3QSEAoIQ2xpZW50SUQYASABKAkSEgoKQXBwVmVyc2lvbhgCIAEoCRIQ",
            "CghMYW5ndWFnZRgDIAEoCRIPCgdDaGFubmVsGAQgASgJEhQKDExpZ2h0aG91",
            "c2VJZBgFIAEoCRIlCgRGcm9tGAYgASgOMhcubXNnLkVudHJ5UG9pbnRGcm9t",
            "VHlwZSIrCgtWZXJzaW9uSW5mbxILCgNNZDUYASABKAkSDwoHVmVyc2lvbhgC",
            "IAEoCSJ0Cg1WZXJzaW9uRGV0YWlsEhMKC0RhdGFWZXJzaW9uGAEgASgJEigK",
            "DkFuZHJvaWRWZXJzaW9uGAIgASgLMhAubXNnLlZlcnNpb25JbmZvEiQKCklP",
            "U1ZlcnNpb24YAyABKAsyEC5tc2cuVmVyc2lvbkluZm8ilQEKEkVudHJ5UG9p",
            "bnRSZXNwb25zZRIUCgxMaWdodGhvdXNlSWQYASABKAkSEwoLRm9yY2VVcGRh",
            "dGUYAiABKAgSKgoOUmVzb3VyY2VEZXRhaWwYAyABKAsyEi5tc2cuVmVyc2lv",
            "bkRldGFpbBITCgtNYWludGVuYW5jZRgEIAEoCBITCgtSZWRpcmVjdFVSTBgF",
            "IAEoCSomChJFbnRyeVBvaW50RnJvbVR5cGUSBwoDQ0ROEAASBwoDT1NTEAFC",
            "TFpAYml0YnVja2V0Lm9yZy9mdW5wbHVzL2Nvcm5lcnN0b25lLWNvbmYvbGln",
            "aHRob3VzZS9nZW4vZ29sYW5nL21zZ6oCB2dlbi5tc2diBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::gen.msg.EntryPointFromType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::gen.msg.EntryPointRequest), global::gen.msg.EntryPointRequest.Parser, new[]{ "ClientID", "AppVersion", "Language", "Channel", "LighthouseId", "From" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gen.msg.VersionInfo), global::gen.msg.VersionInfo.Parser, new[]{ "Md5", "Version" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gen.msg.VersionDetail), global::gen.msg.VersionDetail.Parser, new[]{ "DataVersion", "AndroidVersion", "IOSVersion" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::gen.msg.EntryPointResponse), global::gen.msg.EntryPointResponse.Parser, new[]{ "LighthouseId", "ForceUpdate", "ResourceDetail", "Maintenance", "RedirectURL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum EntryPointFromType {
    [pbr::OriginalName("CDN")] Cdn = 0,
    [pbr::OriginalName("OSS")] Oss = 1,
  }

  #endregion

  #region Messages
  public sealed partial class EntryPointRequest : pb::IMessage<EntryPointRequest> {
    private static readonly pb::MessageParser<EntryPointRequest> _parser = new pb::MessageParser<EntryPointRequest>(() => new EntryPointRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EntryPointRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gen.msg.EntryPointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntryPointRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntryPointRequest(EntryPointRequest other) : this() {
      clientID_ = other.clientID_;
      appVersion_ = other.appVersion_;
      language_ = other.language_;
      channel_ = other.channel_;
      lighthouseId_ = other.lighthouseId_;
      from_ = other.from_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntryPointRequest Clone() {
      return new EntryPointRequest(this);
    }

    /// <summary>Field number for the "ClientID" field.</summary>
    public const int ClientIDFieldNumber = 1;
    private string clientID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientID {
      get { return clientID_; }
      set {
        clientID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "AppVersion" field.</summary>
    public const int AppVersionFieldNumber = 2;
    private string appVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppVersion {
      get { return appVersion_; }
      set {
        appVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Language" field.</summary>
    public const int LanguageFieldNumber = 3;
    private string language_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Language {
      get { return language_; }
      set {
        language_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Channel" field.</summary>
    public const int ChannelFieldNumber = 4;
    private string channel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Channel {
      get { return channel_; }
      set {
        channel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LighthouseId" field.</summary>
    public const int LighthouseIdFieldNumber = 5;
    private string lighthouseId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LighthouseId {
      get { return lighthouseId_; }
      set {
        lighthouseId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "From" field.</summary>
    public const int FromFieldNumber = 6;
    private global::gen.msg.EntryPointFromType from_ = global::gen.msg.EntryPointFromType.Cdn;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::gen.msg.EntryPointFromType From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EntryPointRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EntryPointRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientID != other.ClientID) return false;
      if (AppVersion != other.AppVersion) return false;
      if (Language != other.Language) return false;
      if (Channel != other.Channel) return false;
      if (LighthouseId != other.LighthouseId) return false;
      if (From != other.From) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientID.Length != 0) hash ^= ClientID.GetHashCode();
      if (AppVersion.Length != 0) hash ^= AppVersion.GetHashCode();
      if (Language.Length != 0) hash ^= Language.GetHashCode();
      if (Channel.Length != 0) hash ^= Channel.GetHashCode();
      if (LighthouseId.Length != 0) hash ^= LighthouseId.GetHashCode();
      if (From != global::gen.msg.EntryPointFromType.Cdn) hash ^= From.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ClientID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientID);
      }
      if (AppVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AppVersion);
      }
      if (Language.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Language);
      }
      if (Channel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Channel);
      }
      if (LighthouseId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(LighthouseId);
      }
      if (From != global::gen.msg.EntryPointFromType.Cdn) {
        output.WriteRawTag(48);
        output.WriteEnum((int) From);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClientID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientID);
      }
      if (AppVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppVersion);
      }
      if (Language.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Language);
      }
      if (Channel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Channel);
      }
      if (LighthouseId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LighthouseId);
      }
      if (From != global::gen.msg.EntryPointFromType.Cdn) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) From);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EntryPointRequest other) {
      if (other == null) {
        return;
      }
      if (other.ClientID.Length != 0) {
        ClientID = other.ClientID;
      }
      if (other.AppVersion.Length != 0) {
        AppVersion = other.AppVersion;
      }
      if (other.Language.Length != 0) {
        Language = other.Language;
      }
      if (other.Channel.Length != 0) {
        Channel = other.Channel;
      }
      if (other.LighthouseId.Length != 0) {
        LighthouseId = other.LighthouseId;
      }
      if (other.From != global::gen.msg.EntryPointFromType.Cdn) {
        From = other.From;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ClientID = input.ReadString();
            break;
          }
          case 18: {
            AppVersion = input.ReadString();
            break;
          }
          case 26: {
            Language = input.ReadString();
            break;
          }
          case 34: {
            Channel = input.ReadString();
            break;
          }
          case 42: {
            LighthouseId = input.ReadString();
            break;
          }
          case 48: {
            From = (global::gen.msg.EntryPointFromType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VersionInfo : pb::IMessage<VersionInfo> {
    private static readonly pb::MessageParser<VersionInfo> _parser = new pb::MessageParser<VersionInfo>(() => new VersionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gen.msg.EntryPointReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo(VersionInfo other) : this() {
      md5_ = other.md5_;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo Clone() {
      return new VersionInfo(this);
    }

    /// <summary>Field number for the "Md5" field.</summary>
    public const int Md5FieldNumber = 1;
    private string md5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Md5 {
      get { return md5_; }
      set {
        md5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Md5 != other.Md5) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Md5.Length != 0) hash ^= Md5.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Md5.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Md5);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Md5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Md5);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionInfo other) {
      if (other == null) {
        return;
      }
      if (other.Md5.Length != 0) {
        Md5 = other.Md5;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Md5 = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VersionDetail : pb::IMessage<VersionDetail> {
    private static readonly pb::MessageParser<VersionDetail> _parser = new pb::MessageParser<VersionDetail>(() => new VersionDetail());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionDetail> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gen.msg.EntryPointReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionDetail() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionDetail(VersionDetail other) : this() {
      dataVersion_ = other.dataVersion_;
      androidVersion_ = other.androidVersion_ != null ? other.androidVersion_.Clone() : null;
      iOSVersion_ = other.iOSVersion_ != null ? other.iOSVersion_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionDetail Clone() {
      return new VersionDetail(this);
    }

    /// <summary>Field number for the "DataVersion" field.</summary>
    public const int DataVersionFieldNumber = 1;
    private string dataVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DataVersion {
      get { return dataVersion_; }
      set {
        dataVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "AndroidVersion" field.</summary>
    public const int AndroidVersionFieldNumber = 2;
    private global::gen.msg.VersionInfo androidVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::gen.msg.VersionInfo AndroidVersion {
      get { return androidVersion_; }
      set {
        androidVersion_ = value;
      }
    }

    /// <summary>Field number for the "IOSVersion" field.</summary>
    public const int IOSVersionFieldNumber = 3;
    private global::gen.msg.VersionInfo iOSVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::gen.msg.VersionInfo IOSVersion {
      get { return iOSVersion_; }
      set {
        iOSVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionDetail);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionDetail other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DataVersion != other.DataVersion) return false;
      if (!object.Equals(AndroidVersion, other.AndroidVersion)) return false;
      if (!object.Equals(IOSVersion, other.IOSVersion)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DataVersion.Length != 0) hash ^= DataVersion.GetHashCode();
      if (androidVersion_ != null) hash ^= AndroidVersion.GetHashCode();
      if (iOSVersion_ != null) hash ^= IOSVersion.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DataVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DataVersion);
      }
      if (androidVersion_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AndroidVersion);
      }
      if (iOSVersion_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(IOSVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DataVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DataVersion);
      }
      if (androidVersion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AndroidVersion);
      }
      if (iOSVersion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IOSVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionDetail other) {
      if (other == null) {
        return;
      }
      if (other.DataVersion.Length != 0) {
        DataVersion = other.DataVersion;
      }
      if (other.androidVersion_ != null) {
        if (androidVersion_ == null) {
          AndroidVersion = new global::gen.msg.VersionInfo();
        }
        AndroidVersion.MergeFrom(other.AndroidVersion);
      }
      if (other.iOSVersion_ != null) {
        if (iOSVersion_ == null) {
          IOSVersion = new global::gen.msg.VersionInfo();
        }
        IOSVersion.MergeFrom(other.IOSVersion);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            DataVersion = input.ReadString();
            break;
          }
          case 18: {
            if (androidVersion_ == null) {
              AndroidVersion = new global::gen.msg.VersionInfo();
            }
            input.ReadMessage(AndroidVersion);
            break;
          }
          case 26: {
            if (iOSVersion_ == null) {
              IOSVersion = new global::gen.msg.VersionInfo();
            }
            input.ReadMessage(IOSVersion);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EntryPointResponse : pb::IMessage<EntryPointResponse> {
    private static readonly pb::MessageParser<EntryPointResponse> _parser = new pb::MessageParser<EntryPointResponse>(() => new EntryPointResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EntryPointResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gen.msg.EntryPointReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntryPointResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntryPointResponse(EntryPointResponse other) : this() {
      lighthouseId_ = other.lighthouseId_;
      forceUpdate_ = other.forceUpdate_;
      resourceDetail_ = other.resourceDetail_ != null ? other.resourceDetail_.Clone() : null;
      maintenance_ = other.maintenance_;
      redirectURL_ = other.redirectURL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntryPointResponse Clone() {
      return new EntryPointResponse(this);
    }

    /// <summary>Field number for the "LighthouseId" field.</summary>
    public const int LighthouseIdFieldNumber = 1;
    private string lighthouseId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LighthouseId {
      get { return lighthouseId_; }
      set {
        lighthouseId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ForceUpdate" field.</summary>
    public const int ForceUpdateFieldNumber = 2;
    private bool forceUpdate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForceUpdate {
      get { return forceUpdate_; }
      set {
        forceUpdate_ = value;
      }
    }

    /// <summary>Field number for the "ResourceDetail" field.</summary>
    public const int ResourceDetailFieldNumber = 3;
    private global::gen.msg.VersionDetail resourceDetail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::gen.msg.VersionDetail ResourceDetail {
      get { return resourceDetail_; }
      set {
        resourceDetail_ = value;
      }
    }

    /// <summary>Field number for the "Maintenance" field.</summary>
    public const int MaintenanceFieldNumber = 4;
    private bool maintenance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Maintenance {
      get { return maintenance_; }
      set {
        maintenance_ = value;
      }
    }

    /// <summary>Field number for the "RedirectURL" field.</summary>
    public const int RedirectURLFieldNumber = 5;
    private string redirectURL_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RedirectURL {
      get { return redirectURL_; }
      set {
        redirectURL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EntryPointResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EntryPointResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LighthouseId != other.LighthouseId) return false;
      if (ForceUpdate != other.ForceUpdate) return false;
      if (!object.Equals(ResourceDetail, other.ResourceDetail)) return false;
      if (Maintenance != other.Maintenance) return false;
      if (RedirectURL != other.RedirectURL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LighthouseId.Length != 0) hash ^= LighthouseId.GetHashCode();
      if (ForceUpdate != false) hash ^= ForceUpdate.GetHashCode();
      if (resourceDetail_ != null) hash ^= ResourceDetail.GetHashCode();
      if (Maintenance != false) hash ^= Maintenance.GetHashCode();
      if (RedirectURL.Length != 0) hash ^= RedirectURL.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (LighthouseId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LighthouseId);
      }
      if (ForceUpdate != false) {
        output.WriteRawTag(16);
        output.WriteBool(ForceUpdate);
      }
      if (resourceDetail_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ResourceDetail);
      }
      if (Maintenance != false) {
        output.WriteRawTag(32);
        output.WriteBool(Maintenance);
      }
      if (RedirectURL.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RedirectURL);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LighthouseId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LighthouseId);
      }
      if (ForceUpdate != false) {
        size += 1 + 1;
      }
      if (resourceDetail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResourceDetail);
      }
      if (Maintenance != false) {
        size += 1 + 1;
      }
      if (RedirectURL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RedirectURL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EntryPointResponse other) {
      if (other == null) {
        return;
      }
      if (other.LighthouseId.Length != 0) {
        LighthouseId = other.LighthouseId;
      }
      if (other.ForceUpdate != false) {
        ForceUpdate = other.ForceUpdate;
      }
      if (other.resourceDetail_ != null) {
        if (resourceDetail_ == null) {
          ResourceDetail = new global::gen.msg.VersionDetail();
        }
        ResourceDetail.MergeFrom(other.ResourceDetail);
      }
      if (other.Maintenance != false) {
        Maintenance = other.Maintenance;
      }
      if (other.RedirectURL.Length != 0) {
        RedirectURL = other.RedirectURL;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            LighthouseId = input.ReadString();
            break;
          }
          case 16: {
            ForceUpdate = input.ReadBool();
            break;
          }
          case 26: {
            if (resourceDetail_ == null) {
              ResourceDetail = new global::gen.msg.VersionDetail();
            }
            input.ReadMessage(ResourceDetail);
            break;
          }
          case 32: {
            Maintenance = input.ReadBool();
            break;
          }
          case 42: {
            RedirectURL = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
