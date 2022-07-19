// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PluginToBot/RoleQuery.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SCPDiscord.Interface {

  /// <summary>Holder for reflection information generated from PluginToBot/RoleQuery.proto</summary>
  public static partial class RoleQueryReflection {

    #region Descriptor
    /// <summary>File descriptor for PluginToBot/RoleQuery.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoleQueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbHVnaW5Ub0JvdC9Sb2xlUXVlcnkucHJvdG8SFFNDUERpc2NvcmQuSW50",
            "ZXJmYWNlIjMKCVJvbGVRdWVyeRITCgtTdGVhbUlET3JJUBgBIAEoCRIRCglE",
            "aXNjb3JkSUQYAiABKARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SCPDiscord.Interface.RoleQuery), global::SCPDiscord.Interface.RoleQuery.Parser, new[]{ "SteamIDOrIP", "DiscordID" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoleQuery : pb::IMessage<RoleQuery>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoleQuery> _parser = new pb::MessageParser<RoleQuery>(() => new RoleQuery());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoleQuery> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SCPDiscord.Interface.RoleQueryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoleQuery() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoleQuery(RoleQuery other) : this() {
      steamIDOrIP_ = other.steamIDOrIP_;
      discordID_ = other.discordID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoleQuery Clone() {
      return new RoleQuery(this);
    }

    /// <summary>Field number for the "SteamIDOrIP" field.</summary>
    public const int SteamIDOrIPFieldNumber = 1;
    private string steamIDOrIP_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SteamIDOrIP {
      get { return steamIDOrIP_; }
      set {
        steamIDOrIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DiscordID" field.</summary>
    public const int DiscordIDFieldNumber = 2;
    private ulong discordID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DiscordID {
      get { return discordID_; }
      set {
        discordID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoleQuery);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoleQuery other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SteamIDOrIP != other.SteamIDOrIP) return false;
      if (DiscordID != other.DiscordID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SteamIDOrIP.Length != 0) hash ^= SteamIDOrIP.GetHashCode();
      if (DiscordID != 0UL) hash ^= DiscordID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (SteamIDOrIP.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SteamIDOrIP);
      }
      if (DiscordID != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(DiscordID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SteamIDOrIP.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SteamIDOrIP);
      }
      if (DiscordID != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(DiscordID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (SteamIDOrIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SteamIDOrIP);
      }
      if (DiscordID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DiscordID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoleQuery other) {
      if (other == null) {
        return;
      }
      if (other.SteamIDOrIP.Length != 0) {
        SteamIDOrIP = other.SteamIDOrIP;
      }
      if (other.DiscordID != 0UL) {
        DiscordID = other.DiscordID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            SteamIDOrIP = input.ReadString();
            break;
          }
          case 16: {
            DiscordID = input.ReadUInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            SteamIDOrIP = input.ReadString();
            break;
          }
          case 16: {
            DiscordID = input.ReadUInt64();
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
