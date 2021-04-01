// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: msg/gmt.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Msg {

  /// <summary>Holder for reflection information generated from msg/gmt.proto</summary>
  public static partial class GmtReflection {

    #region Descriptor
    /// <summary>File descriptor for msg/gmt.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GmtReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1tc2cvZ210LnByb3RvEgNtc2caFmdhbWVraXRkYXRhL2dhbWUucHJvdG8a",
            "FmdhbWVraXRkYXRhL21hbGwucHJvdG8aGWdhbWVraXRkYXRhL21pc3Npb24u",
            "cHJvdG8aGGdhbWVraXRkYXRhL3BsYXllci5wcm90byI7CgtVc2VyUmVxdWVz",
            "dBIsCghHYW1lRGF0YRgBIAEoCzIaLmdhbWVraXRkYXRhLkdhbWVEYXRhU3Rh",
            "dGUiDAoKVXNlckRlbGV0ZUI5WjdiaXRidWNrZXQub3JnL2Z1bnBsdXMvc2hv",
            "cHBpbmctbWFsbC1kYXRhL2dlbi9nb2xhbmcvbXNnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gamekitdata.GameReflection.Descriptor, global::Gamekitdata.MallReflection.Descriptor, global::Gamekitdata.MissionReflection.Descriptor, global::Gamekitdata.PlayerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Msg.UserRequest), global::Msg.UserRequest.Parser, new[]{ "GameData" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Msg.UserDelete), global::Msg.UserDelete.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserRequest : pb::IMessage<UserRequest> {
    private static readonly pb::MessageParser<UserRequest> _parser = new pb::MessageParser<UserRequest>(() => new UserRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Msg.GmtReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserRequest(UserRequest other) : this() {
      gameData_ = other.gameData_ != null ? other.gameData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserRequest Clone() {
      return new UserRequest(this);
    }

    /// <summary>Field number for the "GameData" field.</summary>
    public const int GameDataFieldNumber = 1;
    private global::Gamekitdata.GameDataState gameData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Gamekitdata.GameDataState GameData {
      get { return gameData_; }
      set {
        gameData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GameData, other.GameData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (gameData_ != null) hash ^= GameData.GetHashCode();
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
      if (gameData_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(GameData);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (gameData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserRequest other) {
      if (other == null) {
        return;
      }
      if (other.gameData_ != null) {
        if (gameData_ == null) {
          GameData = new global::Gamekitdata.GameDataState();
        }
        GameData.MergeFrom(other.GameData);
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
            if (gameData_ == null) {
              GameData = new global::Gamekitdata.GameDataState();
            }
            input.ReadMessage(GameData);
            break;
          }
        }
      }
    }

  }

  public sealed partial class UserDelete : pb::IMessage<UserDelete> {
    private static readonly pb::MessageParser<UserDelete> _parser = new pb::MessageParser<UserDelete>(() => new UserDelete());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserDelete> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Msg.GmtReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserDelete() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserDelete(UserDelete other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserDelete Clone() {
      return new UserDelete(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserDelete);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserDelete other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserDelete other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code