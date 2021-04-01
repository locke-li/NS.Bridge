// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gamekitdata/mission.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Gamekitdata {

  /// <summary>Holder for reflection information generated from gamekitdata/mission.proto</summary>
  public static partial class MissionReflection {

    #region Descriptor
    /// <summary>File descriptor for gamekitdata/mission.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MissionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlnYW1la2l0ZGF0YS9taXNzaW9uLnByb3RvEgtnYW1la2l0ZGF0YSKzAQoH",
            "TWlzc2lvbhIKCgJpZBgBIAEoBRINCgV2YWx1ZRgCIAEoBRIQCghyZXF1aXJl",
            "ZBgDIAEoBRI2Cgljb25kaXRpb24YBCADKAsyIy5nYW1la2l0ZGF0YS5NaXNz",
            "aW9uLkNvbmRpdGlvbkVudHJ5EhEKCXRpbWVzdGFtcBgFIAEoBRowCg5Db25k",
            "aXRpb25FbnRyeRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6AjgBIscC",
            "ChdDb21wbGV0aW9uTWlzc2lvblJlY29yZBISCgpzaG9wVW5sb2NrGAEgAygF",
            "EkgKCml0ZW1VbmxvY2sYAiADKAsyNC5nYW1la2l0ZGF0YS5Db21wbGV0aW9u",
            "TWlzc2lvblJlY29yZC5JdGVtVW5sb2NrRW50cnkSTAoMb2JqZWN0VW5sb2Nr",
            "GAMgAygLMjYuZ2FtZWtpdGRhdGEuQ29tcGxldGlvbk1pc3Npb25SZWNvcmQu",
            "T2JqZWN0VW5sb2NrRW50cnkSGAoQbmV4dEd1aWRlTWlzc2lvbhgEIAEoBRox",
            "Cg9JdGVtVW5sb2NrRW50cnkSCwoDa2V5GAEgASgFEg0KBXZhbHVlGAIgASgF",
            "OgI4ARozChFPYmplY3RVbmxvY2tFbnRyeRILCgNrZXkYASABKAUSDQoFdmFs",
            "dWUYAiABKAU6AjgBQkFaP2JpdGJ1Y2tldC5vcmcvZnVucGx1cy9zaG9wcGlu",
            "Zy1tYWxsLWRhdGEvZ2VuL2dvbGFuZy9nYW1la2l0ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Gamekitdata.Mission), global::Gamekitdata.Mission.Parser, new[]{ "Id", "Value", "Required", "Condition", "Timestamp" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Gamekitdata.CompletionMissionRecord), global::Gamekitdata.CompletionMissionRecord.Parser, new[]{ "ShopUnlock", "ItemUnlock", "ObjectUnlock", "NextGuideMission" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///激活的任务信息
  /// </summary>
  public sealed partial class Mission : pb::IMessage<Mission> {
    private static readonly pb::MessageParser<Mission> _parser = new pb::MessageParser<Mission>(() => new Mission());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Mission> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gamekitdata.MissionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mission() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mission(Mission other) : this() {
      id_ = other.id_;
      value_ = other.value_;
      required_ = other.required_;
      condition_ = other.condition_.Clone();
      timestamp_ = other.timestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mission Clone() {
      return new Mission(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private int value_;
    /// <summary>
    ///任务进度值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    /// <summary>Field number for the "required" field.</summary>
    public const int RequiredFieldNumber = 3;
    private int required_;
    /// <summary>
    ///任务需求值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Required {
      get { return required_; }
      set {
        required_ = value;
      }
    }

    /// <summary>Field number for the "condition" field.</summary>
    public const int ConditionFieldNumber = 4;
    private static readonly pbc::MapField<int, int>.Codec _map_condition_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 34);
    private readonly pbc::MapField<int, int> condition_ = new pbc::MapField<int, int>();
    /// <summary>
    ///任务条件, 单条件 id:0, 多条件 id:数值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> Condition {
      get { return condition_; }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 5;
    private int timestamp_;
    /// <summary>
    ///任务创建时间，显示排序用
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Mission);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Mission other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Value != other.Value) return false;
      if (Required != other.Required) return false;
      if (!Condition.Equals(other.Condition)) return false;
      if (Timestamp != other.Timestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Value != 0) hash ^= Value.GetHashCode();
      if (Required != 0) hash ^= Required.GetHashCode();
      hash ^= Condition.GetHashCode();
      if (Timestamp != 0) hash ^= Timestamp.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Value != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Value);
      }
      if (Required != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Required);
      }
      condition_.WriteTo(output, _map_condition_codec);
      if (Timestamp != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      if (Required != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Required);
      }
      size += condition_.CalculateSize(_map_condition_codec);
      if (Timestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Mission other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
      if (other.Required != 0) {
        Required = other.Required;
      }
      condition_.Add(other.condition_);
      if (other.Timestamp != 0) {
        Timestamp = other.Timestamp;
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Value = input.ReadInt32();
            break;
          }
          case 24: {
            Required = input.ReadInt32();
            break;
          }
          case 34: {
            condition_.AddEntriesFrom(input, _map_condition_codec);
            break;
          }
          case 40: {
            Timestamp = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///成就任务进度记录
  /// </summary>
  public sealed partial class CompletionMissionRecord : pb::IMessage<CompletionMissionRecord> {
    private static readonly pb::MessageParser<CompletionMissionRecord> _parser = new pb::MessageParser<CompletionMissionRecord>(() => new CompletionMissionRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompletionMissionRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Gamekitdata.MissionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompletionMissionRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompletionMissionRecord(CompletionMissionRecord other) : this() {
      shopUnlock_ = other.shopUnlock_.Clone();
      itemUnlock_ = other.itemUnlock_.Clone();
      objectUnlock_ = other.objectUnlock_.Clone();
      nextGuideMission_ = other.nextGuideMission_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompletionMissionRecord Clone() {
      return new CompletionMissionRecord(this);
    }

    /// <summary>Field number for the "shopUnlock" field.</summary>
    public const int ShopUnlockFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_shopUnlock_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> shopUnlock_ = new pbc::RepeatedField<int>();
    /// <summary>
    ///解锁商店 已完成的id列表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> ShopUnlock {
      get { return shopUnlock_; }
    }

    /// <summary>Field number for the "itemUnlock" field.</summary>
    public const int ItemUnlockFieldNumber = 2;
    private static readonly pbc::MapField<int, int>.Codec _map_itemUnlock_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 18);
    private readonly pbc::MapField<int, int> itemUnlock_ = new pbc::MapField<int, int>();
    /// <summary>
    ///解锁商品 商店id:已完成的解锁数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> ItemUnlock {
      get { return itemUnlock_; }
    }

    /// <summary>Field number for the "objectUnlock" field.</summary>
    public const int ObjectUnlockFieldNumber = 3;
    private static readonly pbc::MapField<int, int>.Codec _map_objectUnlock_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 26);
    private readonly pbc::MapField<int, int> objectUnlock_ = new pbc::MapField<int, int>();
    /// <summary>
    ///解锁物体 物体id:物体等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> ObjectUnlock {
      get { return objectUnlock_; }
    }

    /// <summary>Field number for the "nextGuideMission" field.</summary>
    public const int NextGuideMissionFieldNumber = 4;
    private int nextGuideMission_;
    /// <summary>
    ///下一个强制引导任务
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NextGuideMission {
      get { return nextGuideMission_; }
      set {
        nextGuideMission_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompletionMissionRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompletionMissionRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!shopUnlock_.Equals(other.shopUnlock_)) return false;
      if (!ItemUnlock.Equals(other.ItemUnlock)) return false;
      if (!ObjectUnlock.Equals(other.ObjectUnlock)) return false;
      if (NextGuideMission != other.NextGuideMission) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= shopUnlock_.GetHashCode();
      hash ^= ItemUnlock.GetHashCode();
      hash ^= ObjectUnlock.GetHashCode();
      if (NextGuideMission != 0) hash ^= NextGuideMission.GetHashCode();
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
      shopUnlock_.WriteTo(output, _repeated_shopUnlock_codec);
      itemUnlock_.WriteTo(output, _map_itemUnlock_codec);
      objectUnlock_.WriteTo(output, _map_objectUnlock_codec);
      if (NextGuideMission != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NextGuideMission);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += shopUnlock_.CalculateSize(_repeated_shopUnlock_codec);
      size += itemUnlock_.CalculateSize(_map_itemUnlock_codec);
      size += objectUnlock_.CalculateSize(_map_objectUnlock_codec);
      if (NextGuideMission != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NextGuideMission);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompletionMissionRecord other) {
      if (other == null) {
        return;
      }
      shopUnlock_.Add(other.shopUnlock_);
      itemUnlock_.Add(other.itemUnlock_);
      objectUnlock_.Add(other.objectUnlock_);
      if (other.NextGuideMission != 0) {
        NextGuideMission = other.NextGuideMission;
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
          case 10:
          case 8: {
            shopUnlock_.AddEntriesFrom(input, _repeated_shopUnlock_codec);
            break;
          }
          case 18: {
            itemUnlock_.AddEntriesFrom(input, _map_itemUnlock_codec);
            break;
          }
          case 26: {
            objectUnlock_.AddEntriesFrom(input, _map_objectUnlock_codec);
            break;
          }
          case 32: {
            NextGuideMission = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code