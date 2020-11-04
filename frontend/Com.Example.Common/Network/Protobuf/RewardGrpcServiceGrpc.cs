// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rewardGrpcService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Com.Example.Common.Network.Protobuf.Reward.Grpc {
  public static partial class RewardService
  {
    static readonly string __ServiceName = "RewardService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest> __Marshaller_RewardRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest.Parser));
    static readonly grpc::Marshaller<global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> __Marshaller_RewardResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse.Parser));

    static readonly grpc::Method<global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest, global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> __Method_GetRewardsOnGoal = new grpc::Method<global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest, global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRewardsOnGoal",
        __Marshaller_RewardRequest,
        __Marshaller_RewardResponse);

    static readonly grpc::Method<global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest, global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> __Method_GetRewardsOnLevelCleared = new grpc::Method<global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest, global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRewardsOnLevelCleared",
        __Marshaller_RewardRequest,
        __Marshaller_RewardResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.Example.Common.Network.Protobuf.Reward.Grpc.RewardGrpcServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for RewardService</summary>
    public partial class RewardServiceClient : grpc::ClientBase<RewardServiceClient>
    {
      /// <summary>Creates a new client for RewardService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RewardServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RewardService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RewardServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RewardServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RewardServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse GetRewardsOnGoal(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRewardsOnGoal(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse GetRewardsOnGoal(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRewardsOnGoal, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> GetRewardsOnGoalAsync(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRewardsOnGoalAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> GetRewardsOnGoalAsync(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRewardsOnGoal, null, options, request);
      }
      public virtual global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse GetRewardsOnLevelCleared(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRewardsOnLevelCleared(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse GetRewardsOnLevelCleared(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRewardsOnLevelCleared, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> GetRewardsOnLevelClearedAsync(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRewardsOnLevelClearedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Com.Example.Common.Network.Protobuf.Reward.RewardResponse> GetRewardsOnLevelClearedAsync(global::Com.Example.Common.Network.Protobuf.Reward.RewardRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRewardsOnLevelCleared, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RewardServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RewardServiceClient(configuration);
      }
    }

  }
}
#endregion
