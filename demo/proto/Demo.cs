// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: demo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Demo {

  #region Enums
  public enum JobType {
    None = 0,
    Student = 1,
  }

  #endregion

  #region Messages
  public sealed class Address : pb::IMessage
  {
    private static readonly pb::MessageParser<Address> _parser = new pb::MessageParser<Address>(() => new Address());
    private pb::UnknownFieldSet _unknownFields;
    public static pb::MessageParser<Address> Parser { get { return _parser; } }

    public Address() {
    }

    public Address(Address other) : this() {
      address1_ = other.address1_;
      address2_ = other.address2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    public Address Clone() {
      return new Address(this);
    }

    private string address1_ = "";
    public string Address1 {
      get { return address1_; }
      set {
        address1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string address2_;
    public string Address2 {
      get { return address2_ ?? ""; }
      set {
        address2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "address2" field is set</summary>
    public bool HasAddress2 {
      get { return address2_ != null; }
    }
    /// <summary>Clears the value of the "address2" field</summary>
    public void ClearAddress2() {
      address2_ = null;
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Address1.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address1);
      }
      if (HasAddress2) {
        output.WriteRawTag(18);
        output.WriteString(Address2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Address1.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address1);
      }
      if (HasAddress2) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Address1 = input.ReadString();
            break;
          }
          case 18: {
            Address2 = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed class Person : pb::IMessage
  {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    public Person() {
    }

    public Person(Person other) : this() {
      _hasBits0 = other._hasBits0;
      id1_ = other.id1_;
      id2_ = other.id2_;
      name1_ = other.name1_;
      name2_ = other.name2_;
      homeAddr_ = other.homeAddr_ != null ? other.homeAddr_.Clone() : null;
      schoolAddr_ = other.schoolAddr_ != null ? other.schoolAddr_.Clone() : null;
      mainJob_ = other.mainJob_;
      secondJob_ = other.secondJob_;
      allhomes_ = other.allhomes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    public Person Clone() {
      return new Person(this);
    }

    private int id1_;
    public int Id1 {
      get { return id1_; }
      set {
        id1_ = value;
      }
    }

    private int id2_;
    public int Id2 {
      get { if ((_hasBits0 & 1) != 0) { return id2_; } else { return 0; } }
      set {
        _hasBits0 |= 1;
        id2_ = value;
      }
    }
    /// <summary>Gets whether the "id2" field is set</summary>
    public bool HasId2 {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id2" field</summary>
    public void ClearId2() {
      _hasBits0 &= ~1;
    }

    private string name1_ = "";
    public string Name1 {
      get { return name1_; }
      set {
        name1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string name2_;
    public string Name2 {
      get { return name2_ ?? ""; }
      set {
        name2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name2" field is set</summary>
    public bool HasName2 {
      get { return name2_ != null; }
    }
    /// <summary>Clears the value of the "name2" field</summary>
    public void ClearName2() {
      name2_ = null;
    }

    private global::Demo.Address homeAddr_;
    public global::Demo.Address HomeAddr {
      get { return homeAddr_; }
      set {
        homeAddr_ = value;
      }
    }

    private global::Demo.Address schoolAddr_;
    public global::Demo.Address SchoolAddr {
      get { return schoolAddr_; }
      set {
        schoolAddr_ = value;
      }
    }

    private global::Demo.JobType mainJob_ = global::Demo.JobType.None;
    public global::Demo.JobType MainJob {
      get { return mainJob_; }
      set {
        mainJob_ = value;
      }
    }

    private global::Demo.JobType secondJob_;
    public global::Demo.JobType SecondJob {
      get { if ((_hasBits0 & 2) != 0) { return secondJob_; } else { return global::Demo.JobType.None; } }
      set {
        _hasBits0 |= 2;
        secondJob_ = value;
      }
    }
    /// <summary>Gets whether the "second_job" field is set</summary>
    public bool HasSecondJob {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "second_job" field</summary>
    public void ClearSecondJob() {
      _hasBits0 &= ~2;
    }

    private static readonly pb::FieldCodec<global::Demo.Address> _repeated_allhomes_codec 
            = pb::FieldCodec.ForMessage(74, global::Demo.Address.Parser);
    private readonly pbc::RepeatedField<global::Demo.Address> allhomes_ = new pbc::RepeatedField<global::Demo.Address>();
    public pbc::RepeatedField<global::Demo.Address> Allhomes {
      get { return allhomes_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id1);
      }
      if (HasId2) {
        output.WriteRawTag(16);
        output.WriteInt32(Id2);
      }
      if (Name1.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name1);
      }
      if (HasName2) {
        output.WriteRawTag(34);
        output.WriteString(Name2);
      }
      if (homeAddr_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(HomeAddr);
      }
      if (schoolAddr_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SchoolAddr);
      }
      if (MainJob != global::Demo.JobType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) MainJob);
      }
      if (HasSecondJob) {
        output.WriteRawTag(64);
        output.WriteEnum((int) SecondJob);
      }
      allhomes_.WriteTo(output, _repeated_allhomes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id1);
      }
      if (HasId2) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id2);
      }
      if (Name1.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name1);
      }
      if (HasName2) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name2);
      }
      if (homeAddr_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HomeAddr);
      }
      if (schoolAddr_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SchoolAddr);
      }
      if (MainJob != global::Demo.JobType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MainJob);
      }
      if (HasSecondJob) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SecondJob);
      }
      size += allhomes_.CalculateSize(_repeated_allhomes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id1 = input.ReadInt32();
            break;
          }
          case 16: {
            Id2 = input.ReadInt32();
            break;
          }
          case 26: {
            Name1 = input.ReadString();
            break;
          }
          case 34: {
            Name2 = input.ReadString();
            break;
          }
          case 42: {
            if (homeAddr_ == null) {
              HomeAddr = new global::Demo.Address();
            }
            input.ReadMessage(HomeAddr);
            break;
          }
          case 50: {
            if (schoolAddr_ == null) {
              SchoolAddr = new global::Demo.Address();
            }
            input.ReadMessage(SchoolAddr);
            break;
          }
          case 56: {
            MainJob = (global::Demo.JobType) input.ReadEnum();
            break;
          }
          case 64: {
            SecondJob = (global::Demo.JobType) input.ReadEnum();
            break;
          }
          case 74: {
            allhomes_.AddEntriesFrom(input, _repeated_allhomes_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
