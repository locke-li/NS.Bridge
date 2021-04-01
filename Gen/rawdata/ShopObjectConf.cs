// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata_exclude/ShopObjectConf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata_exclude/ShopObjectConf.proto</summary>
  public static partial class ShopObjectConfReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata_exclude/ShopObjectConf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopObjectConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRyYXdkYXRhX2V4Y2x1ZGUvU2hvcE9iamVjdENvbmYucHJvdG8SB3Jhd2Rh",
            "dGEingQKClNob3BPYmplY3QSEwoLc2hvcF9vYmplY3QYASABKAUSEgoKYWRk",
            "aXRpb25hbBgCIAEoAhI0Cgljb3N0X3R5cGUYAyADKAsyIS5yYXdkYXRhLlNo",
            "b3BPYmplY3QuQ29zdFR5cGVFbnRyeRIPCgdjcmV3X2lkGAQgASgFEjYKCmxl",
            "dmVsX2J1ZmYYBSADKAsyIi5yYXdkYXRhLlNob3BPYmplY3QuTGV2ZWxCdWZm",
            "RW50cnkSNgoKbGV2ZWxfY29zdBgGIAMoCzIiLnJhd2RhdGEuU2hvcE9iamVj",
            "dC5MZXZlbENvc3RFbnRyeRI2CgpsZXZlbF9zdGFyGAcgAygLMiIucmF3ZGF0",
            "YS5TaG9wT2JqZWN0LkxldmVsU3RhckVudHJ5EhAKCGxpbmVfbWF4GAggASgF",
            "EhEKCXBhcmVudF9pZBgJIAEoBRIMCgR0eXBlGAogASgJGi8KDUNvc3RUeXBl",
            "RW50cnkSCwoDa2V5GAEgASgFEg0KBXZhbHVlGAIgASgFOgI4ARowCg5MZXZl",
            "bEJ1ZmZFbnRyeRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAI6AjgBGjAK",
            "DkxldmVsQ29zdEVudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoBToC",
            "OAEaMAoOTGV2ZWxTdGFyRW50cnkSCwoDa2V5GAEgASgFEg0KBXZhbHVlGAIg",
            "ASgCOgI4ASKeAQoOU2hvcE9iamVjdENvbmYSQQoNU2hvcE9iamVjdE1hcBgB",
            "IAMoCzIqLnJhd2RhdGEuU2hvcE9iamVjdENvbmYuU2hvcE9iamVjdE1hcEVu",
            "dHJ5GkkKElNob3BPYmplY3RNYXBFbnRyeRILCgNrZXkYASABKAUSIgoFdmFs",
            "dWUYAiABKAsyEy5yYXdkYXRhLlNob3BPYmplY3Q6AjgBQkdaO2JpdGJ1Y2tl",
            "dC5vcmcvZnVucGx1cy9zaG9wcGluZy1tYWxsLWRhdGEvZ2VuL2dvbGFuZy9y",
            "YXdkYXRhqgIHcmF3ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.ShopObject), global::rawdata.ShopObject.Parser, new[]{ "ShopObject_", "Additional", "CostType", "CrewId", "LevelBuff", "LevelCost", "LevelStar", "LineMax", "ParentId", "Type" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.ShopObjectConf), global::rawdata.ShopObjectConf.Parser, new[]{ "ShopObjectMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ShopObject : pb::IMessage<ShopObject> {
    private static readonly pb::MessageParser<ShopObject> _parser = new pb::MessageParser<ShopObject>(() => new ShopObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ShopObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.ShopObjectConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShopObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShopObject(ShopObject other) : this() {
      shopObject_ = other.shopObject_;
      additional_ = other.additional_;
      costType_ = other.costType_.Clone();
      crewId_ = other.crewId_;
      levelBuff_ = other.levelBuff_.Clone();
      levelCost_ = other.levelCost_.Clone();
      levelStar_ = other.levelStar_.Clone();
      lineMax_ = other.lineMax_;
      parentId_ = other.parentId_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShopObject Clone() {
      return new ShopObject(this);
    }

    /// <summary>Field number for the "shop_object" field.</summary>
    public const int ShopObject_FieldNumber = 1;
    private int shopObject_;
    /// <summary>
    /// 物品id
    /// YYY1XX
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ShopObject_ {
      get { return shopObject_; }
      set {
        shopObject_ = value;
      }
    }

    /// <summary>Field number for the "additional" field.</summary>
    public const int AdditionalFieldNumber = 2;
    private float additional_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Additional {
      get { return additional_; }
      set {
        additional_ = value;
      }
    }

    /// <summary>Field number for the "cost_type" field.</summary>
    public const int CostTypeFieldNumber = 3;
    private static readonly pbc::MapField<int, int>.Codec _map_costType_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 26);
    private readonly pbc::MapField<int, int> costType_ = new pbc::MapField<int, int>();
    /// <summary>
    /// 1:绿钞
    /// 2:点赞币
    /// 3:钻石
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> CostType {
      get { return costType_; }
    }

    /// <summary>Field number for the "crew_id" field.</summary>
    public const int CrewIdFieldNumber = 4;
    private int crewId_;
    /// <summary>
    /// 同时解锁的
    /// npcid(3000+)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CrewId {
      get { return crewId_; }
      set {
        crewId_ = value;
      }
    }

    /// <summary>Field number for the "level_buff" field.</summary>
    public const int LevelBuffFieldNumber = 5;
    private static readonly pbc::MapField<int, float>.Codec _map_levelBuff_codec
        = new pbc::MapField<int, float>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 42);
    private readonly pbc::MapField<int, float> levelBuff_ = new pbc::MapField<int, float>();
    /// <summary>
    /// 一般是加快使用时间，单位为秒
    /// （等级对应的时间）
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, float> LevelBuff {
      get { return levelBuff_; }
    }

    /// <summary>Field number for the "level_cost" field.</summary>
    public const int LevelCostFieldNumber = 6;
    private static readonly pbc::MapField<int, int>.Codec _map_levelCost_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 50);
    private readonly pbc::MapField<int, int> levelCost_ = new pbc::MapField<int, int>();
    /// <summary>
    /// 升到每级的花费，0为直接送
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> LevelCost {
      get { return levelCost_; }
    }

    /// <summary>Field number for the "level_star" field.</summary>
    public const int LevelStarFieldNumber = 7;
    private static readonly pbc::MapField<int, float>.Codec _map_levelStar_codec
        = new pbc::MapField<int, float>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 58);
    private readonly pbc::MapField<int, float> levelStar_ = new pbc::MapField<int, float>();
    /// <summary>
    /// 各个等级的给商店加的分数，不累计
    /// 1级为0.1，5级为0.5
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, float> LevelStar {
      get { return levelStar_; }
    }

    /// <summary>Field number for the "line_max" field.</summary>
    public const int LineMaxFieldNumber = 8;
    private int lineMax_;
    /// <summary>
    /// 队伍最大值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LineMax {
      get { return lineMax_; }
      set {
        lineMax_ = value;
      }
    }

    /// <summary>Field number for the "parent_id" field.</summary>
    public const int ParentIdFieldNumber = 9;
    private int parentId_;
    /// <summary>
    /// 所属店铺
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ParentId {
      get { return parentId_; }
      set {
        parentId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 10;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ShopObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ShopObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShopObject_ != other.ShopObject_) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Additional, other.Additional)) return false;
      if (!CostType.Equals(other.CostType)) return false;
      if (CrewId != other.CrewId) return false;
      if (!LevelBuff.Equals(other.LevelBuff)) return false;
      if (!LevelCost.Equals(other.LevelCost)) return false;
      if (!LevelStar.Equals(other.LevelStar)) return false;
      if (LineMax != other.LineMax) return false;
      if (ParentId != other.ParentId) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ShopObject_ != 0) hash ^= ShopObject_.GetHashCode();
      if (Additional != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Additional);
      hash ^= CostType.GetHashCode();
      if (CrewId != 0) hash ^= CrewId.GetHashCode();
      hash ^= LevelBuff.GetHashCode();
      hash ^= LevelCost.GetHashCode();
      hash ^= LevelStar.GetHashCode();
      if (LineMax != 0) hash ^= LineMax.GetHashCode();
      if (ParentId != 0) hash ^= ParentId.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
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
      if (ShopObject_ != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ShopObject_);
      }
      if (Additional != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Additional);
      }
      costType_.WriteTo(output, _map_costType_codec);
      if (CrewId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(CrewId);
      }
      levelBuff_.WriteTo(output, _map_levelBuff_codec);
      levelCost_.WriteTo(output, _map_levelCost_codec);
      levelStar_.WriteTo(output, _map_levelStar_codec);
      if (LineMax != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(LineMax);
      }
      if (ParentId != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(ParentId);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ShopObject_ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ShopObject_);
      }
      if (Additional != 0F) {
        size += 1 + 4;
      }
      size += costType_.CalculateSize(_map_costType_codec);
      if (CrewId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CrewId);
      }
      size += levelBuff_.CalculateSize(_map_levelBuff_codec);
      size += levelCost_.CalculateSize(_map_levelCost_codec);
      size += levelStar_.CalculateSize(_map_levelStar_codec);
      if (LineMax != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LineMax);
      }
      if (ParentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ParentId);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ShopObject other) {
      if (other == null) {
        return;
      }
      if (other.ShopObject_ != 0) {
        ShopObject_ = other.ShopObject_;
      }
      if (other.Additional != 0F) {
        Additional = other.Additional;
      }
      costType_.Add(other.costType_);
      if (other.CrewId != 0) {
        CrewId = other.CrewId;
      }
      levelBuff_.Add(other.levelBuff_);
      levelCost_.Add(other.levelCost_);
      levelStar_.Add(other.levelStar_);
      if (other.LineMax != 0) {
        LineMax = other.LineMax;
      }
      if (other.ParentId != 0) {
        ParentId = other.ParentId;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
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
            ShopObject_ = input.ReadInt32();
            break;
          }
          case 21: {
            Additional = input.ReadFloat();
            break;
          }
          case 26: {
            costType_.AddEntriesFrom(input, _map_costType_codec);
            break;
          }
          case 32: {
            CrewId = input.ReadInt32();
            break;
          }
          case 42: {
            levelBuff_.AddEntriesFrom(input, _map_levelBuff_codec);
            break;
          }
          case 50: {
            levelCost_.AddEntriesFrom(input, _map_levelCost_codec);
            break;
          }
          case 58: {
            levelStar_.AddEntriesFrom(input, _map_levelStar_codec);
            break;
          }
          case 64: {
            LineMax = input.ReadInt32();
            break;
          }
          case 72: {
            ParentId = input.ReadInt32();
            break;
          }
          case 82: {
            Type = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ShopObjectConf : pb::IMessage<ShopObjectConf> {
    private static readonly pb::MessageParser<ShopObjectConf> _parser = new pb::MessageParser<ShopObjectConf>(() => new ShopObjectConf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ShopObjectConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.ShopObjectConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShopObjectConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShopObjectConf(ShopObjectConf other) : this() {
      shopObjectMap_ = other.shopObjectMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ShopObjectConf Clone() {
      return new ShopObjectConf(this);
    }

    /// <summary>Field number for the "ShopObjectMap" field.</summary>
    public const int ShopObjectMapFieldNumber = 1;
    private static readonly pbc::MapField<int, global::rawdata.ShopObject>.Codec _map_shopObjectMap_codec
        = new pbc::MapField<int, global::rawdata.ShopObject>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::rawdata.ShopObject.Parser), 10);
    private readonly pbc::MapField<int, global::rawdata.ShopObject> shopObjectMap_ = new pbc::MapField<int, global::rawdata.ShopObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::rawdata.ShopObject> ShopObjectMap {
      get { return shopObjectMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ShopObjectConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ShopObjectConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ShopObjectMap.Equals(other.ShopObjectMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ShopObjectMap.GetHashCode();
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
      shopObjectMap_.WriteTo(output, _map_shopObjectMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += shopObjectMap_.CalculateSize(_map_shopObjectMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ShopObjectConf other) {
      if (other == null) {
        return;
      }
      shopObjectMap_.Add(other.shopObjectMap_);
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
            shopObjectMap_.AddEntriesFrom(input, _map_shopObjectMap_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
