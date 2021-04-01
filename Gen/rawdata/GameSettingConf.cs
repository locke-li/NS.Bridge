// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata_exclude/GameSettingConf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata_exclude/GameSettingConf.proto</summary>
  public static partial class GameSettingConfReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata_exclude/GameSettingConf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameSettingConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVyYXdkYXRhX2V4Y2x1ZGUvR2FtZVNldHRpbmdDb25mLnByb3RvEgdyYXdk",
            "YXRhIpQBCgtHYW1lU2V0dGluZxIMCgRuYW1lGAEgASgJEioKA21hcBgCIAMo",
            "CzIdLnJhd2RhdGEuR2FtZVNldHRpbmcuTWFwRW50cnkSEAoIcmVwZWF0ZWQY",
            "AyADKAISDQoFdmFsdWUYBCABKAkaKgoITWFwRW50cnkSCwoDa2V5GAEgASgF",
            "Eg0KBXZhbHVlGAIgASgFOgI4ASKkAQoPR2FtZVNldHRpbmdDb25mEkQKDkdh",
            "bWVTZXR0aW5nTWFwGAEgAygLMiwucmF3ZGF0YS5HYW1lU2V0dGluZ0NvbmYu",
            "R2FtZVNldHRpbmdNYXBFbnRyeRpLChNHYW1lU2V0dGluZ01hcEVudHJ5EgsK",
            "A2tleRgBIAEoCRIjCgV2YWx1ZRgCIAEoCzIULnJhd2RhdGEuR2FtZVNldHRp",
            "bmc6AjgBQkdaO2JpdGJ1Y2tldC5vcmcvZnVucGx1cy9zaG9wcGluZy1tYWxs",
            "LWRhdGEvZ2VuL2dvbGFuZy9yYXdkYXRhqgIHcmF3ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.GameSetting), global::rawdata.GameSetting.Parser, new[]{ "Name", "Map", "Repeated", "Value" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.GameSettingConf), global::rawdata.GameSettingConf.Parser, new[]{ "GameSettingMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameSetting : pb::IMessage<GameSetting> {
    private static readonly pb::MessageParser<GameSetting> _parser = new pb::MessageParser<GameSetting>(() => new GameSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.GameSettingConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameSetting(GameSetting other) : this() {
      name_ = other.name_;
      map_ = other.map_.Clone();
      repeated_ = other.repeated_.Clone();
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameSetting Clone() {
      return new GameSetting(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "map" field.</summary>
    public const int MapFieldNumber = 2;
    private static readonly pbc::MapField<int, int>.Codec _map_map_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 18);
    private readonly pbc::MapField<int, int> map_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> Map {
      get { return map_; }
    }

    /// <summary>Field number for the "repeated" field.</summary>
    public const int RepeatedFieldNumber = 3;
    private static readonly pb::FieldCodec<float> _repeated_repeated_codec
        = pb::FieldCodec.ForFloat(26);
    private readonly pbc::RepeatedField<float> repeated_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> Repeated {
      get { return repeated_; }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 4;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Map.Equals(other.Map)) return false;
      if(!repeated_.Equals(other.repeated_)) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Map.GetHashCode();
      hash ^= repeated_.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      map_.WriteTo(output, _map_map_codec);
      repeated_.WriteTo(output, _repeated_repeated_codec);
      if (Value.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += map_.CalculateSize(_map_map_codec);
      size += repeated_.CalculateSize(_repeated_repeated_codec);
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameSetting other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      map_.Add(other.map_);
      repeated_.Add(other.repeated_);
      if (other.Value.Length != 0) {
        Value = other.Value;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            map_.AddEntriesFrom(input, _map_map_codec);
            break;
          }
          case 26:
          case 29: {
            repeated_.AddEntriesFrom(input, _repeated_repeated_codec);
            break;
          }
          case 34: {
            Value = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GameSettingConf : pb::IMessage<GameSettingConf> {
    private static readonly pb::MessageParser<GameSettingConf> _parser = new pb::MessageParser<GameSettingConf>(() => new GameSettingConf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameSettingConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.GameSettingConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameSettingConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameSettingConf(GameSettingConf other) : this() {
      gameSettingMap_ = other.gameSettingMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameSettingConf Clone() {
      return new GameSettingConf(this);
    }

    /// <summary>Field number for the "GameSettingMap" field.</summary>
    public const int GameSettingMapFieldNumber = 1;
    private static readonly pbc::MapField<string, global::rawdata.GameSetting>.Codec _map_gameSettingMap_codec
        = new pbc::MapField<string, global::rawdata.GameSetting>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::rawdata.GameSetting.Parser), 10);
    private readonly pbc::MapField<string, global::rawdata.GameSetting> gameSettingMap_ = new pbc::MapField<string, global::rawdata.GameSetting>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::rawdata.GameSetting> GameSettingMap {
      get { return gameSettingMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameSettingConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameSettingConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!GameSettingMap.Equals(other.GameSettingMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= GameSettingMap.GetHashCode();
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
      gameSettingMap_.WriteTo(output, _map_gameSettingMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += gameSettingMap_.CalculateSize(_map_gameSettingMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameSettingConf other) {
      if (other == null) {
        return;
      }
      gameSettingMap_.Add(other.gameSettingMap_);
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
            gameSettingMap_.AddEntriesFrom(input, _map_gameSettingMap_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
