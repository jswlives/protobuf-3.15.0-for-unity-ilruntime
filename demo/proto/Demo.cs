// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: demo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Demo {

  /// <summary>Holder for reflection information generated from demo.proto</summary>
  public static partial class DemoReflection {

    #region Descriptor
    /// <summary>File descriptor for demo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DemoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpkZW1vLnByb3RvEgRkZW1vIj8KB0FkZHJlc3MSEAoIYWRkcmVzczEYASAB",
            "KAkSFQoIYWRkcmVzczIYAiABKAlIAIgBAUILCglfYWRkcmVzczIijwIKBlBl",
            "cnNvbhILCgNpZDEYASABKAUSEAoDaWQyGAIgASgFSACIAQESDQoFbmFtZTEY",
            "AyABKAkSEgoFbmFtZTIYBCABKAlIAYgBARIgCglob21lX2FkZHIYBSABKAsy",
            "DS5kZW1vLkFkZHJlc3MSJwoLc2Nob29sX2FkZHIYBiABKAsyDS5kZW1vLkFk",
            "ZHJlc3NIAogBARIfCghtYWluX2pvYhgHIAEoDjINLmRlbW8uSm9iVHlwZRIm",
            "CgpzZWNvbmRfam9iGAggASgOMg0uZGVtby5Kb2JUeXBlSAOIAQFCBgoEX2lk",
            "MkIICgZfbmFtZTJCDgoMX3NjaG9vbF9hZGRyQg0KC19zZWNvbmRfam9iKiAK",
            "B0pvYlR5cGUSCAoETm9uZRAAEgsKB1NUVURFTlQQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Demo.JobType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Demo.Address), global::Demo.Address.Parser, new[]{ "Address1", "Address2" }, new[]{ "Address2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Demo.Person), global::Demo.Person.Parser, new[]{ "Id1", "Id2", "Name1", "Name2", "HomeAddr", "SchoolAddr", "MainJob", "SecondJob" }, new[]{ "Id2", "Name2", "SchoolAddr", "SecondJob" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum JobType {
    [pbr::OriginalName("None")] None = 0,
    [pbr::OriginalName("STUDENT")] Student = 1,
  }

  #endregion

  #region Messages
  public sealed partial class Address : pb::IMessage<Address>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Address> _parser = new pb::MessageParser<Address>(() => new Address());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Address> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Demo.DemoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Address() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Address(Address other) : this() {
      address1_ = other.address1_;
      address2_ = other.address2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Address Clone() {
      return new Address(this);
    }

    /// <summary>Field number for the "address1" field.</summary>
    public const int Address1FieldNumber = 1;
    private string address1_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address1 {
      get { return address1_; }
      set {
        address1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address2" field.</summary>
    public const int Address2FieldNumber = 2;
    private string address2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address2 {
      get { return address2_ ?? ""; }
      set {
        address2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "address2" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAddress2 {
      get { return address2_ != null; }
    }
    /// <summary>Clears the value of the "address2" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAddress2() {
      address2_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Address);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Address other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Address1 != other.Address1) return false;
      if (Address2 != other.Address2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Address1.Length != 0) hash ^= Address1.GetHashCode();
      if (HasAddress2) hash ^= Address2.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
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
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Address1.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address1);
      }
      if (HasAddress2) {
        output.WriteRawTag(18);
        output.WriteString(Address2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Address other) {
      if (other == null) {
        return;
      }
      if (other.Address1.Length != 0) {
        Address1 = other.Address1;
      }
      if (other.HasAddress2) {
        Address2 = other.Address2;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
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
    #endif

  }

  public sealed partial class Person : pb::IMessage<Person>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Demo.DemoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "id1" field.</summary>
    public const int Id1FieldNumber = 1;
    private int id1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id1 {
      get { return id1_; }
      set {
        id1_ = value;
      }
    }

    /// <summary>Field number for the "id2" field.</summary>
    public const int Id2FieldNumber = 2;
    private int id2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id2 {
      get { if ((_hasBits0 & 1) != 0) { return id2_; } else { return 0; } }
      set {
        _hasBits0 |= 1;
        id2_ = value;
      }
    }
    /// <summary>Gets whether the "id2" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId2 {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id2" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId2() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "name1" field.</summary>
    public const int Name1FieldNumber = 3;
    private string name1_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name1 {
      get { return name1_; }
      set {
        name1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name2" field.</summary>
    public const int Name2FieldNumber = 4;
    private string name2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name2 {
      get { return name2_ ?? ""; }
      set {
        name2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name2" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasName2 {
      get { return name2_ != null; }
    }
    /// <summary>Clears the value of the "name2" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearName2() {
      name2_ = null;
    }

    /// <summary>Field number for the "home_addr" field.</summary>
    public const int HomeAddrFieldNumber = 5;
    private global::Demo.Address homeAddr_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Demo.Address HomeAddr {
      get { return homeAddr_; }
      set {
        homeAddr_ = value;
      }
    }

    /// <summary>Field number for the "school_addr" field.</summary>
    public const int SchoolAddrFieldNumber = 6;
    private global::Demo.Address schoolAddr_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Demo.Address SchoolAddr {
      get { return schoolAddr_; }
      set {
        schoolAddr_ = value;
      }
    }

    /// <summary>Field number for the "main_job" field.</summary>
    public const int MainJobFieldNumber = 7;
    private global::Demo.JobType mainJob_ = global::Demo.JobType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Demo.JobType MainJob {
      get { return mainJob_; }
      set {
        mainJob_ = value;
      }
    }

    /// <summary>Field number for the "second_job" field.</summary>
    public const int SecondJobFieldNumber = 8;
    private global::Demo.JobType secondJob_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Demo.JobType SecondJob {
      get { if ((_hasBits0 & 2) != 0) { return secondJob_; } else { return global::Demo.JobType.None; } }
      set {
        _hasBits0 |= 2;
        secondJob_ = value;
      }
    }
    /// <summary>Gets whether the "second_job" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasSecondJob {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "second_job" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSecondJob() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id1 != other.Id1) return false;
      if (Id2 != other.Id2) return false;
      if (Name1 != other.Name1) return false;
      if (Name2 != other.Name2) return false;
      if (!object.Equals(HomeAddr, other.HomeAddr)) return false;
      if (!object.Equals(SchoolAddr, other.SchoolAddr)) return false;
      if (MainJob != other.MainJob) return false;
      if (SecondJob != other.SecondJob) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id1 != 0) hash ^= Id1.GetHashCode();
      if (HasId2) hash ^= Id2.GetHashCode();
      if (Name1.Length != 0) hash ^= Name1.GetHashCode();
      if (HasName2) hash ^= Name2.GetHashCode();
      if (homeAddr_ != null) hash ^= HomeAddr.GetHashCode();
      if (schoolAddr_ != null) hash ^= SchoolAddr.GetHashCode();
      if (MainJob != global::Demo.JobType.None) hash ^= MainJob.GetHashCode();
      if (HasSecondJob) hash ^= SecondJob.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Id1 != 0) {
        Id1 = other.Id1;
      }
      if (other.HasId2) {
        Id2 = other.Id2;
      }
      if (other.Name1.Length != 0) {
        Name1 = other.Name1;
      }
      if (other.HasName2) {
        Name2 = other.Name2;
      }
      if (other.homeAddr_ != null) {
        if (homeAddr_ == null) {
          HomeAddr = new global::Demo.Address();
        }
        HomeAddr.MergeFrom(other.HomeAddr);
      }
      if (other.schoolAddr_ != null) {
        if (schoolAddr_ == null) {
          SchoolAddr = new global::Demo.Address();
        }
        SchoolAddr.MergeFrom(other.SchoolAddr);
      }
      if (other.MainJob != global::Demo.JobType.None) {
        MainJob = other.MainJob;
      }
      if (other.HasSecondJob) {
        SecondJob = other.SecondJob;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
