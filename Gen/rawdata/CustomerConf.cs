// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata_exclude/CustomerConf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata_exclude/CustomerConf.proto</summary>
  public static partial class CustomerConfReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata_exclude/CustomerConf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJyYXdkYXRhX2V4Y2x1ZGUvQ3VzdG9tZXJDb25mLnByb3RvEgdyYXdkYXRh",
            "IqsCCghDdXN0b21lchITCgtjdXN0b21lcl9pZBgBIAEoBRIQCghjb2luX21h",
            "eBgHIAEoBRIQCghjb2luX21pbhgIIAEoBRI6Cg1mYXZvcml0ZV9zaG9wGAQg",
            "AygLMiMucmF3ZGF0YS5DdXN0b21lci5GYXZvcml0ZVNob3BFbnRyeRI0Cgpv",
            "dGhlcl9zaG9wGAUgAygLMiAucmF3ZGF0YS5DdXN0b21lci5PdGhlclNob3BF",
            "bnRyeRINCgVzcGVlZBgGIAEoAhozChFGYXZvcml0ZVNob3BFbnRyeRILCgNr",
            "ZXkYASABKAUSDQoFdmFsdWUYAiABKAI6AjgBGjAKDk90aGVyU2hvcEVudHJ5",
            "EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgCIAEoAjoCOAEikgEKDEN1c3RvbWVy",
            "Q29uZhI7CgtDdXN0b21lck1hcBgBIAMoCzImLnJhd2RhdGEuQ3VzdG9tZXJD",
            "b25mLkN1c3RvbWVyTWFwRW50cnkaRQoQQ3VzdG9tZXJNYXBFbnRyeRILCgNr",
            "ZXkYASABKAUSIAoFdmFsdWUYAiABKAsyES5yYXdkYXRhLkN1c3RvbWVyOgI4",
            "AUJHWjtiaXRidWNrZXQub3JnL2Z1bnBsdXMvc2hvcHBpbmctbWFsbC1kYXRh",
            "L2dlbi9nb2xhbmcvcmF3ZGF0YaoCB3Jhd2RhdGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.Customer), global::rawdata.Customer.Parser, new[]{ "CustomerId", "CoinMax", "CoinMin", "FavoriteShop", "OtherShop", "Speed" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.CustomerConf), global::rawdata.CustomerConf.Parser, new[]{ "CustomerMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Customer : pb::IMessage<Customer> {
    private static readonly pb::MessageParser<Customer> _parser = new pb::MessageParser<Customer>(() => new Customer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Customer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.CustomerConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer(Customer other) : this() {
      customerId_ = other.customerId_;
      coinMax_ = other.coinMax_;
      coinMin_ = other.coinMin_;
      favoriteShop_ = other.favoriteShop_.Clone();
      otherShop_ = other.otherShop_.Clone();
      speed_ = other.speed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Customer Clone() {
      return new Customer(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private int customerId_;
    /// <summary>
    /// 顾客id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CustomerId {
      get { return customerId_; }
      set {
        customerId_ = value;
      }
    }

    /// <summary>Field number for the "coin_max" field.</summary>
    public const int CoinMaxFieldNumber = 7;
    private int coinMax_;
    /// <summary>
    /// 随机的最大值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CoinMax {
      get { return coinMax_; }
      set {
        coinMax_ = value;
      }
    }

    /// <summary>Field number for the "coin_min" field.</summary>
    public const int CoinMinFieldNumber = 8;
    private int coinMin_;
    /// <summary>
    /// 随机的最小值
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CoinMin {
      get { return coinMin_; }
      set {
        coinMin_ = value;
      }
    }

    /// <summary>Field number for the "favorite_shop" field.</summary>
    public const int FavoriteShopFieldNumber = 4;
    private static readonly pbc::MapField<int, float>.Codec _map_favoriteShop_codec
        = new pbc::MapField<int, float>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 34);
    private readonly pbc::MapField<int, float> favoriteShop_ = new pbc::MapField<int, float>();
    /// <summary>
    /// 可能会最喜欢的店铺，可能有多个，也可能没有
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, float> FavoriteShop {
      get { return favoriteShop_; }
    }

    /// <summary>Field number for the "other_shop" field.</summary>
    public const int OtherShopFieldNumber = 5;
    private static readonly pbc::MapField<int, float>.Codec _map_otherShop_codec
        = new pbc::MapField<int, float>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 42);
    private readonly pbc::MapField<int, float> otherShop_ = new pbc::MapField<int, float>();
    /// <summary>
    /// 其余店铺几率，没配就是没概率
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, float> OtherShop {
      get { return otherShop_; }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 6;
    private float speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Customer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Customer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (CoinMax != other.CoinMax) return false;
      if (CoinMin != other.CoinMin) return false;
      if (!FavoriteShop.Equals(other.FavoriteShop)) return false;
      if (!OtherShop.Equals(other.OtherShop)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId != 0) hash ^= CustomerId.GetHashCode();
      if (CoinMax != 0) hash ^= CoinMax.GetHashCode();
      if (CoinMin != 0) hash ^= CoinMin.GetHashCode();
      hash ^= FavoriteShop.GetHashCode();
      hash ^= OtherShop.GetHashCode();
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
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
      if (CustomerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CustomerId);
      }
      favoriteShop_.WriteTo(output, _map_favoriteShop_codec);
      otherShop_.WriteTo(output, _map_otherShop_codec);
      if (Speed != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Speed);
      }
      if (CoinMax != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(CoinMax);
      }
      if (CoinMin != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CoinMin);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CustomerId);
      }
      if (CoinMax != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CoinMax);
      }
      if (CoinMin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CoinMin);
      }
      size += favoriteShop_.CalculateSize(_map_favoriteShop_codec);
      size += otherShop_.CalculateSize(_map_otherShop_codec);
      if (Speed != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Customer other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.CoinMax != 0) {
        CoinMax = other.CoinMax;
      }
      if (other.CoinMin != 0) {
        CoinMin = other.CoinMin;
      }
      favoriteShop_.Add(other.favoriteShop_);
      otherShop_.Add(other.otherShop_);
      if (other.Speed != 0F) {
        Speed = other.Speed;
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
            CustomerId = input.ReadInt32();
            break;
          }
          case 34: {
            favoriteShop_.AddEntriesFrom(input, _map_favoriteShop_codec);
            break;
          }
          case 42: {
            otherShop_.AddEntriesFrom(input, _map_otherShop_codec);
            break;
          }
          case 53: {
            Speed = input.ReadFloat();
            break;
          }
          case 56: {
            CoinMax = input.ReadInt32();
            break;
          }
          case 64: {
            CoinMin = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CustomerConf : pb::IMessage<CustomerConf> {
    private static readonly pb::MessageParser<CustomerConf> _parser = new pb::MessageParser<CustomerConf>(() => new CustomerConf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.CustomerConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerConf(CustomerConf other) : this() {
      customerMap_ = other.customerMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerConf Clone() {
      return new CustomerConf(this);
    }

    /// <summary>Field number for the "CustomerMap" field.</summary>
    public const int CustomerMapFieldNumber = 1;
    private static readonly pbc::MapField<int, global::rawdata.Customer>.Codec _map_customerMap_codec
        = new pbc::MapField<int, global::rawdata.Customer>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::rawdata.Customer.Parser), 10);
    private readonly pbc::MapField<int, global::rawdata.Customer> customerMap_ = new pbc::MapField<int, global::rawdata.Customer>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::rawdata.Customer> CustomerMap {
      get { return customerMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!CustomerMap.Equals(other.CustomerMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= CustomerMap.GetHashCode();
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
      customerMap_.WriteTo(output, _map_customerMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += customerMap_.CalculateSize(_map_customerMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerConf other) {
      if (other == null) {
        return;
      }
      customerMap_.Add(other.customerMap_);
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
            customerMap_.AddEntriesFrom(input, _map_customerMap_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
