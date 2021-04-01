// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata_exclude/TextConf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata_exclude/TextConf.proto</summary>
  public static partial class TextConfReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata_exclude/TextConf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5yYXdkYXRhX2V4Y2x1ZGUvVGV4dENvbmYucHJvdG8SB3Jhd2RhdGEiMQoE",
            "VGV4dBIKCgJpZBgBIAEoCRIOCgZyZWZfaWQYAiABKAkSDQoFdmFsdWUYBCAB",
            "KAkiegoIVGV4dENvbmYSLwoHVGV4dE1hcBgBIAMoCzIeLnJhd2RhdGEuVGV4",
            "dENvbmYuVGV4dE1hcEVudHJ5Gj0KDFRleHRNYXBFbnRyeRILCgNrZXkYASAB",
            "KAkSHAoFdmFsdWUYAiABKAsyDS5yYXdkYXRhLlRleHQ6AjgBQkdaO2JpdGJ1",
            "Y2tldC5vcmcvZnVucGx1cy9zaG9wcGluZy1tYWxsLWRhdGEvZ2VuL2dvbGFu",
            "Zy9yYXdkYXRhqgIHcmF3ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.Text), global::rawdata.Text.Parser, new[]{ "Id", "RefId", "Value" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.TextConf), global::rawdata.TextConf.Parser, new[]{ "TextMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Text : pb::IMessage<Text> {
    private static readonly pb::MessageParser<Text> _parser = new pb::MessageParser<Text>(() => new Text());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Text> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.TextConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Text() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Text(Text other) : this() {
      id_ = other.id_;
      refId_ = other.refId_;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Text Clone() {
      return new Text(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// id_目标标识
    /// (如_等级，_用途)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ref_id" field.</summary>
    public const int RefIdFieldNumber = 2;
    private string refId_ = "";
    /// <summary>
    /// 复用id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RefId {
      get { return refId_; }
      set {
        refId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 4;
    private string value_ = "";
    /// <summary>
    /// 通用变量替换符：%s（暂不支持顺序）
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Text);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Text other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (RefId != other.RefId) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (RefId.Length != 0) hash ^= RefId.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (RefId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RefId);
      }
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (RefId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RefId);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Text other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.RefId.Length != 0) {
        RefId = other.RefId;
      }
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            RefId = input.ReadString();
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

  public sealed partial class TextConf : pb::IMessage<TextConf> {
    private static readonly pb::MessageParser<TextConf> _parser = new pb::MessageParser<TextConf>(() => new TextConf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TextConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.TextConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextConf(TextConf other) : this() {
      textMap_ = other.textMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextConf Clone() {
      return new TextConf(this);
    }

    /// <summary>Field number for the "TextMap" field.</summary>
    public const int TextMapFieldNumber = 1;
    private static readonly pbc::MapField<string, global::rawdata.Text>.Codec _map_textMap_codec
        = new pbc::MapField<string, global::rawdata.Text>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::rawdata.Text.Parser), 10);
    private readonly pbc::MapField<string, global::rawdata.Text> textMap_ = new pbc::MapField<string, global::rawdata.Text>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::rawdata.Text> TextMap {
      get { return textMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TextConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TextConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!TextMap.Equals(other.TextMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= TextMap.GetHashCode();
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
      textMap_.WriteTo(output, _map_textMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += textMap_.CalculateSize(_map_textMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TextConf other) {
      if (other == null) {
        return;
      }
      textMap_.Add(other.textMap_);
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
            textMap_.AddEntriesFrom(input, _map_textMap_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code