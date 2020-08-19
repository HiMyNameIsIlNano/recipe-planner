// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ingredient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ingredient.proto</summary>
public static partial class IngredientReflection {

  #region Descriptor
  /// <summary>File descriptor for ingredient.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IngredientReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBpbmdyZWRpZW50LnByb3RvIj0KFkluZ3JlZGllbnRMaXN0UmVzcG9uc2US",
          "IwoLaW5ncmVkaWVudHMYASADKAsyDi5JbmdyZWRpZW50RFRPInoKDUluZ3Jl",
          "ZGllbnREVE8SCgoCaWQYASABKAkSLQoIY2F0ZWdvcnkYAiABKA4yGy5Jbmdy",
          "ZWRpZW50RFRPLkNhdGVnb3J5RW51bSIuCgxDYXRlZ29yeUVudW0SCQoFQkFT",
          "SUMQABIJCgVTUElDRRABEggKBE1FQVQQAiI4ChJJbmdyZWRpZW50UmVzcG9u",
          "c2USIgoKaW5ncmVkaWVudBgBIAEoCzIOLkluZ3JlZGllbnREVE9CLAoZY29t",
          "LmV4YW1wbGUuZGVtby5wcm90b2J1ZkIPSW5ncmVkaWVudFByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IngredientListResponse), global::IngredientListResponse.Parser, new[]{ "Ingredients" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::IngredientDTO), global::IngredientDTO.Parser, new[]{ "Id", "Category" }, null, new[]{ typeof(global::IngredientDTO.Types.CategoryEnum) }, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::IngredientResponse), global::IngredientResponse.Parser, new[]{ "Ingredient" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IngredientListResponse : pb::IMessage<IngredientListResponse> {
  private static readonly pb::MessageParser<IngredientListResponse> _parser = new pb::MessageParser<IngredientListResponse>(() => new IngredientListResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<IngredientListResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IngredientReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientListResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientListResponse(IngredientListResponse other) : this() {
    ingredients_ = other.ingredients_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientListResponse Clone() {
    return new IngredientListResponse(this);
  }

  /// <summary>Field number for the "ingredients" field.</summary>
  public const int IngredientsFieldNumber = 1;
  private static readonly pb::FieldCodec<global::IngredientDTO> _repeated_ingredients_codec
      = pb::FieldCodec.ForMessage(10, global::IngredientDTO.Parser);
  private readonly pbc::RepeatedField<global::IngredientDTO> ingredients_ = new pbc::RepeatedField<global::IngredientDTO>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::IngredientDTO> Ingredients {
    get { return ingredients_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as IngredientListResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(IngredientListResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!ingredients_.Equals(other.ingredients_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= ingredients_.GetHashCode();
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
    ingredients_.WriteTo(output, _repeated_ingredients_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += ingredients_.CalculateSize(_repeated_ingredients_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(IngredientListResponse other) {
    if (other == null) {
      return;
    }
    ingredients_.Add(other.ingredients_);
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
          ingredients_.AddEntriesFrom(input, _repeated_ingredients_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class IngredientDTO : pb::IMessage<IngredientDTO> {
  private static readonly pb::MessageParser<IngredientDTO> _parser = new pb::MessageParser<IngredientDTO>(() => new IngredientDTO());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<IngredientDTO> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IngredientReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientDTO() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientDTO(IngredientDTO other) : this() {
    id_ = other.id_;
    category_ = other.category_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientDTO Clone() {
    return new IngredientDTO(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private string id_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Id {
    get { return id_; }
    set {
      id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "category" field.</summary>
  public const int CategoryFieldNumber = 2;
  private global::IngredientDTO.Types.CategoryEnum category_ = global::IngredientDTO.Types.CategoryEnum.Basic;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::IngredientDTO.Types.CategoryEnum Category {
    get { return category_; }
    set {
      category_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as IngredientDTO);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(IngredientDTO other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (Category != other.Category) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id.Length != 0) hash ^= Id.GetHashCode();
    if (Category != global::IngredientDTO.Types.CategoryEnum.Basic) hash ^= Category.GetHashCode();
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
    if (Category != global::IngredientDTO.Types.CategoryEnum.Basic) {
      output.WriteRawTag(16);
      output.WriteEnum((int) Category);
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
    if (Category != global::IngredientDTO.Types.CategoryEnum.Basic) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(IngredientDTO other) {
    if (other == null) {
      return;
    }
    if (other.Id.Length != 0) {
      Id = other.Id;
    }
    if (other.Category != global::IngredientDTO.Types.CategoryEnum.Basic) {
      Category = other.Category;
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
        case 16: {
          Category = (global::IngredientDTO.Types.CategoryEnum) input.ReadEnum();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the IngredientDTO message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public enum CategoryEnum {
      [pbr::OriginalName("BASIC")] Basic = 0,
      [pbr::OriginalName("SPICE")] Spice = 1,
      [pbr::OriginalName("MEAT")] Meat = 2,
    }

  }
  #endregion

}

public sealed partial class IngredientResponse : pb::IMessage<IngredientResponse> {
  private static readonly pb::MessageParser<IngredientResponse> _parser = new pb::MessageParser<IngredientResponse>(() => new IngredientResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<IngredientResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IngredientReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientResponse(IngredientResponse other) : this() {
    ingredient_ = other.ingredient_ != null ? other.ingredient_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IngredientResponse Clone() {
    return new IngredientResponse(this);
  }

  /// <summary>Field number for the "ingredient" field.</summary>
  public const int IngredientFieldNumber = 1;
  private global::IngredientDTO ingredient_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::IngredientDTO Ingredient {
    get { return ingredient_; }
    set {
      ingredient_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as IngredientResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(IngredientResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Ingredient, other.Ingredient)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (ingredient_ != null) hash ^= Ingredient.GetHashCode();
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
    if (ingredient_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Ingredient);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (ingredient_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ingredient);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(IngredientResponse other) {
    if (other == null) {
      return;
    }
    if (other.ingredient_ != null) {
      if (ingredient_ == null) {
        Ingredient = new global::IngredientDTO();
      }
      Ingredient.MergeFrom(other.Ingredient);
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
          if (ingredient_ == null) {
            Ingredient = new global::IngredientDTO();
          }
          input.ReadMessage(Ingredient);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code