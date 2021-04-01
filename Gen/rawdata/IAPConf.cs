// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata_exclude/IAPConf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata_exclude/IAPConf.proto</summary>
  public static partial class IAPConfReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata_exclude/IAPConf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IAPConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1yYXdkYXRhX2V4Y2x1ZGUvSUFQQ29uZi5wcm90bxIHcmF3ZGF0YRoVcmF3",
            "ZGF0YS9QYXlUeXBlLnByb3RvIrABCgNJQVASDgoGaWFwX2lkGAEgASgNEhAK",
            "CGFzc2V0X2lkGAIgASgFEhMKC2RpYW1vbmRfbnVtGAMgASgFEgwKBG5hbWUY",
            "BCABKAkSFgoOb2ZmbGluZV9leHRlbmQYBSABKAUSIgoIcGF5X3R5cGUYCCAB",
            "KA4yEC5yYXdkYXRhLlBheVR5cGUSDQoFcHJpY2UYBiABKAISGQoRcHJvZHVj",
            "dF9pZF9nb29nbGUYByABKAkidAoHSUFQQ29uZhIsCgZJQVBNYXAYASADKAsy",
            "HC5yYXdkYXRhLklBUENvbmYuSUFQTWFwRW50cnkaOwoLSUFQTWFwRW50cnkS",
            "CwoDa2V5GAEgASgNEhsKBXZhbHVlGAIgASgLMgwucmF3ZGF0YS5JQVA6AjgB",
            "QkdaO2JpdGJ1Y2tldC5vcmcvZnVucGx1cy9zaG9wcGluZy1tYWxsLWRhdGEv",
            "Z2VuL2dvbGFuZy9yYXdkYXRhqgIHcmF3ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::rawdata.PayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.IAP), global::rawdata.IAP.Parser, new[]{ "IapId", "AssetId", "DiamondNum", "Name", "OfflineExtend", "PayType", "Price", "ProductIdGoogle" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.IAPConf), global::rawdata.IAPConf.Parser, new[]{ "IAPMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IAP : pb::IMessage<IAP> {
    private static readonly pb::MessageParser<IAP> _parser = new pb::MessageParser<IAP>(() => new IAP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IAP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.IAPConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IAP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IAP(IAP other) : this() {
      iapId_ = other.iapId_;
      assetId_ = other.assetId_;
      diamondNum_ = other.diamondNum_;
      name_ = other.name_;
      offlineExtend_ = other.offlineExtend_;
      payType_ = other.payType_;
      price_ = other.price_;
      productIdGoogle_ = other.productIdGoogle_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IAP Clone() {
      return new IAP(this);
    }

    /// <summary>Field number for the "iap_id" field.</summary>
    public const int IapIdFieldNumber = 1;
    private uint iapId_;
    /// <summary>
    /// 510XXXX
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint IapId {
      get { return iapId_; }
      set {
        iapId_ = value;
      }
    }

    /// <summary>Field number for the "asset_id" field.</summary>
    public const int AssetIdFieldNumber = 2;
    private int assetId_;
    /// <summary>
    /// 显示的资源
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AssetId {
      get { return assetId_; }
      set {
        assetId_ = value;
      }
    }

    /// <summary>Field number for the "diamond_num" field.</summary>
    public const int DiamondNumFieldNumber = 3;
    private int diamondNum_;
    /// <summary>
    /// 购买的钻石数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DiamondNum {
      get { return diamondNum_; }
      set {
        diamondNum_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "offline_extend" field.</summary>
    public const int OfflineExtendFieldNumber = 5;
    private int offlineExtend_;
    /// <summary>
    /// 延长多久离线时间（叠加）单位秒
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OfflineExtend {
      get { return offlineExtend_; }
      set {
        offlineExtend_ = value;
      }
    }

    /// <summary>Field number for the "pay_type" field.</summary>
    public const int PayTypeFieldNumber = 8;
    private global::rawdata.PayType payType_ = global::rawdata.PayType.Diamond;
    /// <summary>
    /// 付费类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::rawdata.PayType PayType {
      get { return payType_; }
      set {
        payType_ = value;
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 6;
    private float price_;
    /// <summary>
    /// 美元价格
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "product_id_google" field.</summary>
    public const int ProductIdGoogleFieldNumber = 7;
    private string productIdGoogle_ = "";
    /// <summary>
    /// google iap
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProductIdGoogle {
      get { return productIdGoogle_; }
      set {
        productIdGoogle_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IAP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IAP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IapId != other.IapId) return false;
      if (AssetId != other.AssetId) return false;
      if (DiamondNum != other.DiamondNum) return false;
      if (Name != other.Name) return false;
      if (OfflineExtend != other.OfflineExtend) return false;
      if (PayType != other.PayType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Price, other.Price)) return false;
      if (ProductIdGoogle != other.ProductIdGoogle) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IapId != 0) hash ^= IapId.GetHashCode();
      if (AssetId != 0) hash ^= AssetId.GetHashCode();
      if (DiamondNum != 0) hash ^= DiamondNum.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (OfflineExtend != 0) hash ^= OfflineExtend.GetHashCode();
      if (PayType != global::rawdata.PayType.Diamond) hash ^= PayType.GetHashCode();
      if (Price != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Price);
      if (ProductIdGoogle.Length != 0) hash ^= ProductIdGoogle.GetHashCode();
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
      if (IapId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IapId);
      }
      if (AssetId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AssetId);
      }
      if (DiamondNum != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(DiamondNum);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (OfflineExtend != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(OfflineExtend);
      }
      if (Price != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Price);
      }
      if (ProductIdGoogle.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ProductIdGoogle);
      }
      if (PayType != global::rawdata.PayType.Diamond) {
        output.WriteRawTag(64);
        output.WriteEnum((int) PayType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IapId);
      }
      if (AssetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AssetId);
      }
      if (DiamondNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DiamondNum);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (OfflineExtend != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OfflineExtend);
      }
      if (PayType != global::rawdata.PayType.Diamond) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PayType);
      }
      if (Price != 0F) {
        size += 1 + 4;
      }
      if (ProductIdGoogle.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductIdGoogle);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IAP other) {
      if (other == null) {
        return;
      }
      if (other.IapId != 0) {
        IapId = other.IapId;
      }
      if (other.AssetId != 0) {
        AssetId = other.AssetId;
      }
      if (other.DiamondNum != 0) {
        DiamondNum = other.DiamondNum;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.OfflineExtend != 0) {
        OfflineExtend = other.OfflineExtend;
      }
      if (other.PayType != global::rawdata.PayType.Diamond) {
        PayType = other.PayType;
      }
      if (other.Price != 0F) {
        Price = other.Price;
      }
      if (other.ProductIdGoogle.Length != 0) {
        ProductIdGoogle = other.ProductIdGoogle;
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
            IapId = input.ReadUInt32();
            break;
          }
          case 16: {
            AssetId = input.ReadInt32();
            break;
          }
          case 24: {
            DiamondNum = input.ReadInt32();
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 40: {
            OfflineExtend = input.ReadInt32();
            break;
          }
          case 53: {
            Price = input.ReadFloat();
            break;
          }
          case 58: {
            ProductIdGoogle = input.ReadString();
            break;
          }
          case 64: {
            PayType = (global::rawdata.PayType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class IAPConf : pb::IMessage<IAPConf> {
    private static readonly pb::MessageParser<IAPConf> _parser = new pb::MessageParser<IAPConf>(() => new IAPConf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IAPConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.IAPConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IAPConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IAPConf(IAPConf other) : this() {
      iAPMap_ = other.iAPMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IAPConf Clone() {
      return new IAPConf(this);
    }

    /// <summary>Field number for the "IAPMap" field.</summary>
    public const int IAPMapFieldNumber = 1;
    private static readonly pbc::MapField<uint, global::rawdata.IAP>.Codec _map_iAPMap_codec
        = new pbc::MapField<uint, global::rawdata.IAP>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::rawdata.IAP.Parser), 10);
    private readonly pbc::MapField<uint, global::rawdata.IAP> iAPMap_ = new pbc::MapField<uint, global::rawdata.IAP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<uint, global::rawdata.IAP> IAPMap {
      get { return iAPMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IAPConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IAPConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!IAPMap.Equals(other.IAPMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= IAPMap.GetHashCode();
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
      iAPMap_.WriteTo(output, _map_iAPMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += iAPMap_.CalculateSize(_map_iAPMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IAPConf other) {
      if (other == null) {
        return;
      }
      iAPMap_.Add(other.iAPMap_);
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
            iAPMap_.AddEntriesFrom(input, _map_iAPMap_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code