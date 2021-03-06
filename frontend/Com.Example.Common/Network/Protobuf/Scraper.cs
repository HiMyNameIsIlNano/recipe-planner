// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: scraper.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Example.Common.Network.Protobuf.Scraper {

  /// <summary>Holder for reflection information generated from scraper.proto</summary>
  public static partial class ScraperReflection {

    #region Descriptor
    /// <summary>File descriptor for scraper.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScraperReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1zY3JhcGVyLnByb3RvIogBChBJdGVtTGlzdFJlc3BvbnNlEg8KB2NvbnRl",
            "eHQYASABKAkSDAoEdHlwZRgCIAEoCRInChFpdGVtX2xpc3RfZWxlbWVudBgD",
            "IAMoCzIMLkxpc3RJdGVtRFRPEhcKD251bWJlcl9vZl9pdGVtcxgEIAEoBRIT",
            "Cgt0b3RhbF9wYWdlcxgFIAEoBSI6CgtMaXN0SXRlbURUTxIMCgR0eXBlGAEg",
            "ASgJEhAKCHBvc2l0aW9uGAIgASgFEgsKA3VybBgDIAEoCUJXChljb20uZXhh",
            "bXBsZS5kZW1vLnByb3RvYnVmQgxTY3JhcGVyUHJvdG+qAitDb20uRXhhbXBs",
            "ZS5Db21tb24uTmV0d29yay5Qcm90b2J1Zi5TY3JhcGVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Common.Network.Protobuf.Scraper.ItemListResponse), global::Com.Example.Common.Network.Protobuf.Scraper.ItemListResponse.Parser, new[]{ "Context", "Type", "ItemListElement", "NumberOfItems", "TotalPages" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO), global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO.Parser, new[]{ "Type", "Position", "Url" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ItemListResponse : pb::IMessage<ItemListResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ItemListResponse> _parser = new pb::MessageParser<ItemListResponse>(() => new ItemListResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemListResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Common.Network.Protobuf.Scraper.ScraperReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemListResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemListResponse(ItemListResponse other) : this() {
      context_ = other.context_;
      type_ = other.type_;
      itemListElement_ = other.itemListElement_.Clone();
      numberOfItems_ = other.numberOfItems_;
      totalPages_ = other.totalPages_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemListResponse Clone() {
      return new ItemListResponse(this);
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 1;
    private string context_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Context {
      get { return context_; }
      set {
        context_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "item_list_element" field.</summary>
    public const int ItemListElementFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO> _repeated_itemListElement_codec
        = pb::FieldCodec.ForMessage(26, global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO.Parser);
    private readonly pbc::RepeatedField<global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO> itemListElement_ = new pbc::RepeatedField<global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.Example.Common.Network.Protobuf.Scraper.ListItemDTO> ItemListElement {
      get { return itemListElement_; }
    }

    /// <summary>Field number for the "number_of_items" field.</summary>
    public const int NumberOfItemsFieldNumber = 4;
    private int numberOfItems_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumberOfItems {
      get { return numberOfItems_; }
      set {
        numberOfItems_ = value;
      }
    }

    /// <summary>Field number for the "total_pages" field.</summary>
    public const int TotalPagesFieldNumber = 5;
    private int totalPages_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalPages {
      get { return totalPages_; }
      set {
        totalPages_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemListResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemListResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Context != other.Context) return false;
      if (Type != other.Type) return false;
      if(!itemListElement_.Equals(other.itemListElement_)) return false;
      if (NumberOfItems != other.NumberOfItems) return false;
      if (TotalPages != other.TotalPages) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Context.Length != 0) hash ^= Context.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= itemListElement_.GetHashCode();
      if (NumberOfItems != 0) hash ^= NumberOfItems.GetHashCode();
      if (TotalPages != 0) hash ^= TotalPages.GetHashCode();
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
      if (Context.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Context);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      itemListElement_.WriteTo(output, _repeated_itemListElement_codec);
      if (NumberOfItems != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NumberOfItems);
      }
      if (TotalPages != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(TotalPages);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Context.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Context);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
      itemListElement_.WriteTo(ref output, _repeated_itemListElement_codec);
      if (NumberOfItems != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NumberOfItems);
      }
      if (TotalPages != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(TotalPages);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Context.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Context);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += itemListElement_.CalculateSize(_repeated_itemListElement_codec);
      if (NumberOfItems != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumberOfItems);
      }
      if (TotalPages != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalPages);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemListResponse other) {
      if (other == null) {
        return;
      }
      if (other.Context.Length != 0) {
        Context = other.Context;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      itemListElement_.Add(other.itemListElement_);
      if (other.NumberOfItems != 0) {
        NumberOfItems = other.NumberOfItems;
      }
      if (other.TotalPages != 0) {
        TotalPages = other.TotalPages;
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
            Context = input.ReadString();
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            itemListElement_.AddEntriesFrom(input, _repeated_itemListElement_codec);
            break;
          }
          case 32: {
            NumberOfItems = input.ReadInt32();
            break;
          }
          case 40: {
            TotalPages = input.ReadInt32();
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
            Context = input.ReadString();
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
          case 26: {
            itemListElement_.AddEntriesFrom(ref input, _repeated_itemListElement_codec);
            break;
          }
          case 32: {
            NumberOfItems = input.ReadInt32();
            break;
          }
          case 40: {
            TotalPages = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ListItemDTO : pb::IMessage<ListItemDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListItemDTO> _parser = new pb::MessageParser<ListItemDTO>(() => new ListItemDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListItemDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Example.Common.Network.Protobuf.Scraper.ScraperReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListItemDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListItemDTO(ListItemDTO other) : this() {
      type_ = other.type_;
      position_ = other.position_;
      url_ = other.url_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListItemDTO Clone() {
      return new ListItemDTO(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private int position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 3;
    private string url_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListItemDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListItemDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Position != other.Position) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Position != 0) hash ^= Position.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Position != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Position);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Position != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Position);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Position != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Position);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListItemDTO other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Position != 0) {
        Position = other.Position;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
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
            Type = input.ReadString();
            break;
          }
          case 16: {
            Position = input.ReadInt32();
            break;
          }
          case 26: {
            Url = input.ReadString();
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
            Type = input.ReadString();
            break;
          }
          case 16: {
            Position = input.ReadInt32();
            break;
          }
          case 26: {
            Url = input.ReadString();
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
