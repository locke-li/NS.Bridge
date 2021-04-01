// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rawdata_exclude/DefaultConf.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace rawdata {

  /// <summary>Holder for reflection information generated from rawdata_exclude/DefaultConf.proto</summary>
  public static partial class DefaultConfReflection {

    #region Descriptor
    /// <summary>File descriptor for rawdata_exclude/DefaultConf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DefaultConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFyYXdkYXRhX2V4Y2x1ZGUvRGVmYXVsdENvbmYucHJvdG8SB3Jhd2RhdGEi",
            "yQEKB0RlZmF1bHQSFAoMZGVmYXVsdF9jb2luGAggASgNEhcKD2RlZmF1bHRf",
            "ZGlhbW9uZBgCIAEoDRIUCgxkZWZhdWx0X2xpa2UYCSABKA0SFAoMZGVmYXVs",
            "dF9tYWxsGAQgASgFEhQKDGRlZmF1bHRfc2hvcBgFIAEoBRIWCg50dXRvcmlh",
            "bF9zdGFmZhgGIAEoBRIaChJ0dXRvcmlhbF9zdGFmZl9udW0YCiABKAUSGQoR",
            "dHV0b3J0aWFsX2RpYW1vbmQYByABKA0iNQoLRGVmYXVsdENvbmYSJgoMRGVm",
            "YXVsdFNsaWNlGAEgAygLMhAucmF3ZGF0YS5EZWZhdWx0QkdaO2JpdGJ1Y2tl",
            "dC5vcmcvZnVucGx1cy9zaG9wcGluZy1tYWxsLWRhdGEvZ2VuL2dvbGFuZy9y",
            "YXdkYXRhqgIHcmF3ZGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.Default), global::rawdata.Default.Parser, new[]{ "DefaultCoin", "DefaultDiamond", "DefaultLike", "DefaultMall", "DefaultShop", "TutorialStaff", "TutorialStaffNum", "TutortialDiamond" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::rawdata.DefaultConf), global::rawdata.DefaultConf.Parser, new[]{ "DefaultSlice" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Default : pb::IMessage<Default> {
    private static readonly pb::MessageParser<Default> _parser = new pb::MessageParser<Default>(() => new Default());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Default> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.DefaultConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Default() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Default(Default other) : this() {
      defaultCoin_ = other.defaultCoin_;
      defaultDiamond_ = other.defaultDiamond_;
      defaultLike_ = other.defaultLike_;
      defaultMall_ = other.defaultMall_;
      defaultShop_ = other.defaultShop_;
      tutorialStaff_ = other.tutorialStaff_;
      tutorialStaffNum_ = other.tutorialStaffNum_;
      tutortialDiamond_ = other.tutortialDiamond_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Default Clone() {
      return new Default(this);
    }

    /// <summary>Field number for the "default_coin" field.</summary>
    public const int DefaultCoinFieldNumber = 8;
    private uint defaultCoin_;
    /// <summary>
    /// 初始金币数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DefaultCoin {
      get { return defaultCoin_; }
      set {
        defaultCoin_ = value;
      }
    }

    /// <summary>Field number for the "default_diamond" field.</summary>
    public const int DefaultDiamondFieldNumber = 2;
    private uint defaultDiamond_;
    /// <summary>
    /// 初始钻石数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DefaultDiamond {
      get { return defaultDiamond_; }
      set {
        defaultDiamond_ = value;
      }
    }

    /// <summary>Field number for the "default_like" field.</summary>
    public const int DefaultLikeFieldNumber = 9;
    private uint defaultLike_;
    /// <summary>
    /// 初始点赞币数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DefaultLike {
      get { return defaultLike_; }
      set {
        defaultLike_ = value;
      }
    }

    /// <summary>Field number for the "default_mall" field.</summary>
    public const int DefaultMallFieldNumber = 4;
    private int defaultMall_;
    /// <summary>
    /// 初始mall的id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DefaultMall {
      get { return defaultMall_; }
      set {
        defaultMall_ = value;
      }
    }

    /// <summary>Field number for the "default_shop" field.</summary>
    public const int DefaultShopFieldNumber = 5;
    private int defaultShop_;
    /// <summary>
    /// 初始商店的id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DefaultShop {
      get { return defaultShop_; }
      set {
        defaultShop_ = value;
      }
    }

    /// <summary>Field number for the "tutorial_staff" field.</summary>
    public const int TutorialStaffFieldNumber = 6;
    private int tutorialStaff_;
    /// <summary>
    /// 引导固定的NPC
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TutorialStaff {
      get { return tutorialStaff_; }
      set {
        tutorialStaff_ = value;
      }
    }

    /// <summary>Field number for the "tutorial_staff_num" field.</summary>
    public const int TutorialStaffNumFieldNumber = 10;
    private int tutorialStaffNum_;
    /// <summary>
    /// 引导固定的卡数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TutorialStaffNum {
      get { return tutorialStaffNum_; }
      set {
        tutorialStaffNum_ = value;
      }
    }

    /// <summary>Field number for the "tutortial_diamond" field.</summary>
    public const int TutortialDiamondFieldNumber = 7;
    private uint tutortialDiamond_;
    /// <summary>
    /// 引导送的钻石数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint TutortialDiamond {
      get { return tutortialDiamond_; }
      set {
        tutortialDiamond_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Default);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Default other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DefaultCoin != other.DefaultCoin) return false;
      if (DefaultDiamond != other.DefaultDiamond) return false;
      if (DefaultLike != other.DefaultLike) return false;
      if (DefaultMall != other.DefaultMall) return false;
      if (DefaultShop != other.DefaultShop) return false;
      if (TutorialStaff != other.TutorialStaff) return false;
      if (TutorialStaffNum != other.TutorialStaffNum) return false;
      if (TutortialDiamond != other.TutortialDiamond) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DefaultCoin != 0) hash ^= DefaultCoin.GetHashCode();
      if (DefaultDiamond != 0) hash ^= DefaultDiamond.GetHashCode();
      if (DefaultLike != 0) hash ^= DefaultLike.GetHashCode();
      if (DefaultMall != 0) hash ^= DefaultMall.GetHashCode();
      if (DefaultShop != 0) hash ^= DefaultShop.GetHashCode();
      if (TutorialStaff != 0) hash ^= TutorialStaff.GetHashCode();
      if (TutorialStaffNum != 0) hash ^= TutorialStaffNum.GetHashCode();
      if (TutortialDiamond != 0) hash ^= TutortialDiamond.GetHashCode();
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
      if (DefaultDiamond != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DefaultDiamond);
      }
      if (DefaultMall != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(DefaultMall);
      }
      if (DefaultShop != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(DefaultShop);
      }
      if (TutorialStaff != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(TutorialStaff);
      }
      if (TutortialDiamond != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TutortialDiamond);
      }
      if (DefaultCoin != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DefaultCoin);
      }
      if (DefaultLike != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DefaultLike);
      }
      if (TutorialStaffNum != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(TutorialStaffNum);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DefaultCoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DefaultCoin);
      }
      if (DefaultDiamond != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DefaultDiamond);
      }
      if (DefaultLike != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DefaultLike);
      }
      if (DefaultMall != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefaultMall);
      }
      if (DefaultShop != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DefaultShop);
      }
      if (TutorialStaff != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TutorialStaff);
      }
      if (TutorialStaffNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TutorialStaffNum);
      }
      if (TutortialDiamond != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TutortialDiamond);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Default other) {
      if (other == null) {
        return;
      }
      if (other.DefaultCoin != 0) {
        DefaultCoin = other.DefaultCoin;
      }
      if (other.DefaultDiamond != 0) {
        DefaultDiamond = other.DefaultDiamond;
      }
      if (other.DefaultLike != 0) {
        DefaultLike = other.DefaultLike;
      }
      if (other.DefaultMall != 0) {
        DefaultMall = other.DefaultMall;
      }
      if (other.DefaultShop != 0) {
        DefaultShop = other.DefaultShop;
      }
      if (other.TutorialStaff != 0) {
        TutorialStaff = other.TutorialStaff;
      }
      if (other.TutorialStaffNum != 0) {
        TutorialStaffNum = other.TutorialStaffNum;
      }
      if (other.TutortialDiamond != 0) {
        TutortialDiamond = other.TutortialDiamond;
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
          case 16: {
            DefaultDiamond = input.ReadUInt32();
            break;
          }
          case 32: {
            DefaultMall = input.ReadInt32();
            break;
          }
          case 40: {
            DefaultShop = input.ReadInt32();
            break;
          }
          case 48: {
            TutorialStaff = input.ReadInt32();
            break;
          }
          case 56: {
            TutortialDiamond = input.ReadUInt32();
            break;
          }
          case 64: {
            DefaultCoin = input.ReadUInt32();
            break;
          }
          case 72: {
            DefaultLike = input.ReadUInt32();
            break;
          }
          case 80: {
            TutorialStaffNum = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DefaultConf : pb::IMessage<DefaultConf> {
    private static readonly pb::MessageParser<DefaultConf> _parser = new pb::MessageParser<DefaultConf>(() => new DefaultConf());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DefaultConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::rawdata.DefaultConfReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultConf(DefaultConf other) : this() {
      defaultSlice_ = other.defaultSlice_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DefaultConf Clone() {
      return new DefaultConf(this);
    }

    /// <summary>Field number for the "DefaultSlice" field.</summary>
    public const int DefaultSliceFieldNumber = 1;
    private static readonly pb::FieldCodec<global::rawdata.Default> _repeated_defaultSlice_codec
        = pb::FieldCodec.ForMessage(10, global::rawdata.Default.Parser);
    private readonly pbc::RepeatedField<global::rawdata.Default> defaultSlice_ = new pbc::RepeatedField<global::rawdata.Default>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::rawdata.Default> DefaultSlice {
      get { return defaultSlice_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DefaultConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DefaultConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!defaultSlice_.Equals(other.defaultSlice_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= defaultSlice_.GetHashCode();
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
      defaultSlice_.WriteTo(output, _repeated_defaultSlice_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += defaultSlice_.CalculateSize(_repeated_defaultSlice_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DefaultConf other) {
      if (other == null) {
        return;
      }
      defaultSlice_.Add(other.defaultSlice_);
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
            defaultSlice_.AddEntriesFrom(input, _repeated_defaultSlice_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code