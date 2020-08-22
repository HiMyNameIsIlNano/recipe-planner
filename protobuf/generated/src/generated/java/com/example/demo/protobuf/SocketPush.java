// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: socket.proto

package com.example.demo.protobuf;

public final class SocketPush {
  private SocketPush() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  public interface SocketPushMessageOrBuilder extends
      // @@protoc_insertion_point(interface_extends:SocketPushMessage)
      com.google.protobuf.MessageOrBuilder {

    /**
     * <code>int32 playerId = 1;</code>
     * @return The playerId.
     */
    int getPlayerId();

    /**
     * <code>string text = 2;</code>
     * @return The text.
     */
    java.lang.String getText();
    /**
     * <code>string text = 2;</code>
     * @return The bytes for text.
     */
    com.google.protobuf.ByteString
        getTextBytes();
  }
  /**
   * Protobuf type {@code SocketPushMessage}
   */
  public static final class SocketPushMessage extends
      com.google.protobuf.GeneratedMessageV3 implements
      // @@protoc_insertion_point(message_implements:SocketPushMessage)
      SocketPushMessageOrBuilder {
  private static final long serialVersionUID = 0L;
    // Use SocketPushMessage.newBuilder() to construct.
    private SocketPushMessage(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
      super(builder);
    }
    private SocketPushMessage() {
      text_ = "";
    }

    @java.lang.Override
    @SuppressWarnings({"unused"})
    protected java.lang.Object newInstance(
        UnusedPrivateParameter unused) {
      return new SocketPushMessage();
    }

    @java.lang.Override
    public final com.google.protobuf.UnknownFieldSet
    getUnknownFields() {
      return this.unknownFields;
    }
    private SocketPushMessage(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      this();
      if (extensionRegistry == null) {
        throw new java.lang.NullPointerException();
      }
      com.google.protobuf.UnknownFieldSet.Builder unknownFields =
          com.google.protobuf.UnknownFieldSet.newBuilder();
      try {
        boolean done = false;
        while (!done) {
          int tag = input.readTag();
          switch (tag) {
            case 0:
              done = true;
              break;
            case 8: {

              playerId_ = input.readInt32();
              break;
            }
            case 18: {
              java.lang.String s = input.readStringRequireUtf8();

              text_ = s;
              break;
            }
            default: {
              if (!parseUnknownField(
                  input, unknownFields, extensionRegistry, tag)) {
                done = true;
              }
              break;
            }
          }
        }
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        throw e.setUnfinishedMessage(this);
      } catch (java.io.IOException e) {
        throw new com.google.protobuf.InvalidProtocolBufferException(
            e).setUnfinishedMessage(this);
      } finally {
        this.unknownFields = unknownFields.build();
        makeExtensionsImmutable();
      }
    }
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.example.demo.protobuf.SocketPush.internal_static_SocketPushMessage_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.example.demo.protobuf.SocketPush.internal_static_SocketPushMessage_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.example.demo.protobuf.SocketPush.SocketPushMessage.class, com.example.demo.protobuf.SocketPush.SocketPushMessage.Builder.class);
    }

    public static final int PLAYERID_FIELD_NUMBER = 1;
    private int playerId_;
    /**
     * <code>int32 playerId = 1;</code>
     * @return The playerId.
     */
    @java.lang.Override
    public int getPlayerId() {
      return playerId_;
    }

    public static final int TEXT_FIELD_NUMBER = 2;
    private volatile java.lang.Object text_;
    /**
     * <code>string text = 2;</code>
     * @return The text.
     */
    @java.lang.Override
    public java.lang.String getText() {
      java.lang.Object ref = text_;
      if (ref instanceof java.lang.String) {
        return (java.lang.String) ref;
      } else {
        com.google.protobuf.ByteString bs = 
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        text_ = s;
        return s;
      }
    }
    /**
     * <code>string text = 2;</code>
     * @return The bytes for text.
     */
    @java.lang.Override
    public com.google.protobuf.ByteString
        getTextBytes() {
      java.lang.Object ref = text_;
      if (ref instanceof java.lang.String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        text_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }

    private byte memoizedIsInitialized = -1;
    @java.lang.Override
    public final boolean isInitialized() {
      byte isInitialized = memoizedIsInitialized;
      if (isInitialized == 1) return true;
      if (isInitialized == 0) return false;

      memoizedIsInitialized = 1;
      return true;
    }

    @java.lang.Override
    public void writeTo(com.google.protobuf.CodedOutputStream output)
                        throws java.io.IOException {
      if (playerId_ != 0) {
        output.writeInt32(1, playerId_);
      }
      if (!getTextBytes().isEmpty()) {
        com.google.protobuf.GeneratedMessageV3.writeString(output, 2, text_);
      }
      unknownFields.writeTo(output);
    }

    @java.lang.Override
    public int getSerializedSize() {
      int size = memoizedSize;
      if (size != -1) return size;

      size = 0;
      if (playerId_ != 0) {
        size += com.google.protobuf.CodedOutputStream
          .computeInt32Size(1, playerId_);
      }
      if (!getTextBytes().isEmpty()) {
        size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, text_);
      }
      size += unknownFields.getSerializedSize();
      memoizedSize = size;
      return size;
    }

    @java.lang.Override
    public boolean equals(final java.lang.Object obj) {
      if (obj == this) {
       return true;
      }
      if (!(obj instanceof com.example.demo.protobuf.SocketPush.SocketPushMessage)) {
        return super.equals(obj);
      }
      com.example.demo.protobuf.SocketPush.SocketPushMessage other = (com.example.demo.protobuf.SocketPush.SocketPushMessage) obj;

      if (getPlayerId()
          != other.getPlayerId()) return false;
      if (!getText()
          .equals(other.getText())) return false;
      if (!unknownFields.equals(other.unknownFields)) return false;
      return true;
    }

    @java.lang.Override
    public int hashCode() {
      if (memoizedHashCode != 0) {
        return memoizedHashCode;
      }
      int hash = 41;
      hash = (19 * hash) + getDescriptor().hashCode();
      hash = (37 * hash) + PLAYERID_FIELD_NUMBER;
      hash = (53 * hash) + getPlayerId();
      hash = (37 * hash) + TEXT_FIELD_NUMBER;
      hash = (53 * hash) + getText().hashCode();
      hash = (29 * hash) + unknownFields.hashCode();
      memoizedHashCode = hash;
      return hash;
    }

    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        java.nio.ByteBuffer data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        java.nio.ByteBuffer data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data, extensionRegistry);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        com.google.protobuf.ByteString data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        com.google.protobuf.ByteString data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data, extensionRegistry);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(byte[] data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        byte[] data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data, extensionRegistry);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(java.io.InputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageV3
          .parseWithIOException(PARSER, input);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageV3
          .parseWithIOException(PARSER, input, extensionRegistry);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseDelimitedFrom(java.io.InputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageV3
          .parseDelimitedWithIOException(PARSER, input);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseDelimitedFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageV3
          .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        com.google.protobuf.CodedInputStream input)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageV3
          .parseWithIOException(PARSER, input);
    }
    public static com.example.demo.protobuf.SocketPush.SocketPushMessage parseFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return com.google.protobuf.GeneratedMessageV3
          .parseWithIOException(PARSER, input, extensionRegistry);
    }

    @java.lang.Override
    public Builder newBuilderForType() { return newBuilder(); }
    public static Builder newBuilder() {
      return DEFAULT_INSTANCE.toBuilder();
    }
    public static Builder newBuilder(com.example.demo.protobuf.SocketPush.SocketPushMessage prototype) {
      return DEFAULT_INSTANCE.toBuilder().mergeFrom(prototype);
    }
    @java.lang.Override
    public Builder toBuilder() {
      return this == DEFAULT_INSTANCE
          ? new Builder() : new Builder().mergeFrom(this);
    }

    @java.lang.Override
    protected Builder newBuilderForType(
        com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
      Builder builder = new Builder(parent);
      return builder;
    }
    /**
     * Protobuf type {@code SocketPushMessage}
     */
    public static final class Builder extends
        com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
        // @@protoc_insertion_point(builder_implements:SocketPushMessage)
        com.example.demo.protobuf.SocketPush.SocketPushMessageOrBuilder {
      public static final com.google.protobuf.Descriptors.Descriptor
          getDescriptor() {
        return com.example.demo.protobuf.SocketPush.internal_static_SocketPushMessage_descriptor;
      }

      @java.lang.Override
      protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
          internalGetFieldAccessorTable() {
        return com.example.demo.protobuf.SocketPush.internal_static_SocketPushMessage_fieldAccessorTable
            .ensureFieldAccessorsInitialized(
                com.example.demo.protobuf.SocketPush.SocketPushMessage.class, com.example.demo.protobuf.SocketPush.SocketPushMessage.Builder.class);
      }

      // Construct using com.example.demo.protobuf.SocketPush.SocketPushMessage.newBuilder()
      private Builder() {
        maybeForceBuilderInitialization();
      }

      private Builder(
          com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
        super(parent);
        maybeForceBuilderInitialization();
      }
      private void maybeForceBuilderInitialization() {
        if (com.google.protobuf.GeneratedMessageV3
                .alwaysUseFieldBuilders) {
        }
      }
      @java.lang.Override
      public Builder clear() {
        super.clear();
        playerId_ = 0;

        text_ = "";

        return this;
      }

      @java.lang.Override
      public com.google.protobuf.Descriptors.Descriptor
          getDescriptorForType() {
        return com.example.demo.protobuf.SocketPush.internal_static_SocketPushMessage_descriptor;
      }

      @java.lang.Override
      public com.example.demo.protobuf.SocketPush.SocketPushMessage getDefaultInstanceForType() {
        return com.example.demo.protobuf.SocketPush.SocketPushMessage.getDefaultInstance();
      }

      @java.lang.Override
      public com.example.demo.protobuf.SocketPush.SocketPushMessage build() {
        com.example.demo.protobuf.SocketPush.SocketPushMessage result = buildPartial();
        if (!result.isInitialized()) {
          throw newUninitializedMessageException(result);
        }
        return result;
      }

      @java.lang.Override
      public com.example.demo.protobuf.SocketPush.SocketPushMessage buildPartial() {
        com.example.demo.protobuf.SocketPush.SocketPushMessage result = new com.example.demo.protobuf.SocketPush.SocketPushMessage(this);
        result.playerId_ = playerId_;
        result.text_ = text_;
        onBuilt();
        return result;
      }

      @java.lang.Override
      public Builder clone() {
        return super.clone();
      }
      @java.lang.Override
      public Builder setField(
          com.google.protobuf.Descriptors.FieldDescriptor field,
          java.lang.Object value) {
        return super.setField(field, value);
      }
      @java.lang.Override
      public Builder clearField(
          com.google.protobuf.Descriptors.FieldDescriptor field) {
        return super.clearField(field);
      }
      @java.lang.Override
      public Builder clearOneof(
          com.google.protobuf.Descriptors.OneofDescriptor oneof) {
        return super.clearOneof(oneof);
      }
      @java.lang.Override
      public Builder setRepeatedField(
          com.google.protobuf.Descriptors.FieldDescriptor field,
          int index, java.lang.Object value) {
        return super.setRepeatedField(field, index, value);
      }
      @java.lang.Override
      public Builder addRepeatedField(
          com.google.protobuf.Descriptors.FieldDescriptor field,
          java.lang.Object value) {
        return super.addRepeatedField(field, value);
      }
      @java.lang.Override
      public Builder mergeFrom(com.google.protobuf.Message other) {
        if (other instanceof com.example.demo.protobuf.SocketPush.SocketPushMessage) {
          return mergeFrom((com.example.demo.protobuf.SocketPush.SocketPushMessage)other);
        } else {
          super.mergeFrom(other);
          return this;
        }
      }

      public Builder mergeFrom(com.example.demo.protobuf.SocketPush.SocketPushMessage other) {
        if (other == com.example.demo.protobuf.SocketPush.SocketPushMessage.getDefaultInstance()) return this;
        if (other.getPlayerId() != 0) {
          setPlayerId(other.getPlayerId());
        }
        if (!other.getText().isEmpty()) {
          text_ = other.text_;
          onChanged();
        }
        this.mergeUnknownFields(other.unknownFields);
        onChanged();
        return this;
      }

      @java.lang.Override
      public final boolean isInitialized() {
        return true;
      }

      @java.lang.Override
      public Builder mergeFrom(
          com.google.protobuf.CodedInputStream input,
          com.google.protobuf.ExtensionRegistryLite extensionRegistry)
          throws java.io.IOException {
        com.example.demo.protobuf.SocketPush.SocketPushMessage parsedMessage = null;
        try {
          parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
        } catch (com.google.protobuf.InvalidProtocolBufferException e) {
          parsedMessage = (com.example.demo.protobuf.SocketPush.SocketPushMessage) e.getUnfinishedMessage();
          throw e.unwrapIOException();
        } finally {
          if (parsedMessage != null) {
            mergeFrom(parsedMessage);
          }
        }
        return this;
      }

      private int playerId_ ;
      /**
       * <code>int32 playerId = 1;</code>
       * @return The playerId.
       */
      @java.lang.Override
      public int getPlayerId() {
        return playerId_;
      }
      /**
       * <code>int32 playerId = 1;</code>
       * @param value The playerId to set.
       * @return This builder for chaining.
       */
      public Builder setPlayerId(int value) {
        
        playerId_ = value;
        onChanged();
        return this;
      }
      /**
       * <code>int32 playerId = 1;</code>
       * @return This builder for chaining.
       */
      public Builder clearPlayerId() {
        
        playerId_ = 0;
        onChanged();
        return this;
      }

      private java.lang.Object text_ = "";
      /**
       * <code>string text = 2;</code>
       * @return The text.
       */
      public java.lang.String getText() {
        java.lang.Object ref = text_;
        if (!(ref instanceof java.lang.String)) {
          com.google.protobuf.ByteString bs =
              (com.google.protobuf.ByteString) ref;
          java.lang.String s = bs.toStringUtf8();
          text_ = s;
          return s;
        } else {
          return (java.lang.String) ref;
        }
      }
      /**
       * <code>string text = 2;</code>
       * @return The bytes for text.
       */
      public com.google.protobuf.ByteString
          getTextBytes() {
        java.lang.Object ref = text_;
        if (ref instanceof String) {
          com.google.protobuf.ByteString b = 
              com.google.protobuf.ByteString.copyFromUtf8(
                  (java.lang.String) ref);
          text_ = b;
          return b;
        } else {
          return (com.google.protobuf.ByteString) ref;
        }
      }
      /**
       * <code>string text = 2;</code>
       * @param value The text to set.
       * @return This builder for chaining.
       */
      public Builder setText(
          java.lang.String value) {
        if (value == null) {
    throw new NullPointerException();
  }
  
        text_ = value;
        onChanged();
        return this;
      }
      /**
       * <code>string text = 2;</code>
       * @return This builder for chaining.
       */
      public Builder clearText() {
        
        text_ = getDefaultInstance().getText();
        onChanged();
        return this;
      }
      /**
       * <code>string text = 2;</code>
       * @param value The bytes for text to set.
       * @return This builder for chaining.
       */
      public Builder setTextBytes(
          com.google.protobuf.ByteString value) {
        if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
        
        text_ = value;
        onChanged();
        return this;
      }
      @java.lang.Override
      public final Builder setUnknownFields(
          final com.google.protobuf.UnknownFieldSet unknownFields) {
        return super.setUnknownFields(unknownFields);
      }

      @java.lang.Override
      public final Builder mergeUnknownFields(
          final com.google.protobuf.UnknownFieldSet unknownFields) {
        return super.mergeUnknownFields(unknownFields);
      }


      // @@protoc_insertion_point(builder_scope:SocketPushMessage)
    }

    // @@protoc_insertion_point(class_scope:SocketPushMessage)
    private static final com.example.demo.protobuf.SocketPush.SocketPushMessage DEFAULT_INSTANCE;
    static {
      DEFAULT_INSTANCE = new com.example.demo.protobuf.SocketPush.SocketPushMessage();
    }

    public static com.example.demo.protobuf.SocketPush.SocketPushMessage getDefaultInstance() {
      return DEFAULT_INSTANCE;
    }

    private static final com.google.protobuf.Parser<SocketPushMessage>
        PARSER = new com.google.protobuf.AbstractParser<SocketPushMessage>() {
      @java.lang.Override
      public SocketPushMessage parsePartialFrom(
          com.google.protobuf.CodedInputStream input,
          com.google.protobuf.ExtensionRegistryLite extensionRegistry)
          throws com.google.protobuf.InvalidProtocolBufferException {
        return new SocketPushMessage(input, extensionRegistry);
      }
    };

    public static com.google.protobuf.Parser<SocketPushMessage> parser() {
      return PARSER;
    }

    @java.lang.Override
    public com.google.protobuf.Parser<SocketPushMessage> getParserForType() {
      return PARSER;
    }

    @java.lang.Override
    public com.example.demo.protobuf.SocketPush.SocketPushMessage getDefaultInstanceForType() {
      return DEFAULT_INSTANCE;
    }

  }

  private static final com.google.protobuf.Descriptors.Descriptor
    internal_static_SocketPushMessage_descriptor;
  private static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_SocketPushMessage_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\014socket.proto\"3\n\021SocketPushMessage\022\020\n\010p" +
      "layerId\030\001 \001(\005\022\014\n\004text\030\002 \001(\tBJ\n\031com.examp" +
      "le.demo.protobufB\nSocketPush\252\002 Com.Examp" +
      "le.Demo.Protobuf.Socketb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
        });
    internal_static_SocketPushMessage_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_SocketPushMessage_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_SocketPushMessage_descriptor,
        new java.lang.String[] { "PlayerId", "Text", });
  }

  // @@protoc_insertion_point(outer_class_scope)
}
