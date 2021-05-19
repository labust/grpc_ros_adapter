// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: remote_control.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Remotecontrol {
  public static partial class RemoteControl
  {
    static readonly string __ServiceName = "remotecontrol.RemoteControl";

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

    static readonly grpc::Marshaller<global::Remotecontrol.ForceRequest> __Marshaller_remotecontrol_ForceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Remotecontrol.ForceRequest.Parser));
    static readonly grpc::Marshaller<global::Remotecontrol.ForceResponse> __Marshaller_remotecontrol_ForceResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Remotecontrol.ForceResponse.Parser));

    static readonly grpc::Method<global::Remotecontrol.ForceRequest, global::Remotecontrol.ForceResponse> __Method_ApplyForce = new grpc::Method<global::Remotecontrol.ForceRequest, global::Remotecontrol.ForceResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ApplyForce",
        __Marshaller_remotecontrol_ForceRequest,
        __Marshaller_remotecontrol_ForceResponse);

    static readonly grpc::Method<global::Remotecontrol.ForceRequest, global::Remotecontrol.ForceResponse> __Method_StopRemoteControl = new grpc::Method<global::Remotecontrol.ForceRequest, global::Remotecontrol.ForceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "StopRemoteControl",
        __Marshaller_remotecontrol_ForceRequest,
        __Marshaller_remotecontrol_ForceResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Remotecontrol.RemoteControlReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteControl</summary>
    [grpc::BindServiceMethod(typeof(RemoteControl), "BindService")]
    public abstract partial class RemoteControlBase
    {
      public virtual global::System.Threading.Tasks.Task ApplyForce(global::Remotecontrol.ForceRequest request, grpc::IServerStreamWriter<global::Remotecontrol.ForceResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Remotecontrol.ForceResponse> StopRemoteControl(global::Remotecontrol.ForceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RemoteControl</summary>
    public partial class RemoteControlClient : grpc::ClientBase<RemoteControlClient>
    {
      /// <summary>Creates a new client for RemoteControl</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemoteControlClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemoteControl that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemoteControlClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemoteControlClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemoteControlClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Remotecontrol.ForceResponse> ApplyForce(global::Remotecontrol.ForceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ApplyForce(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Remotecontrol.ForceResponse> ApplyForce(global::Remotecontrol.ForceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ApplyForce, null, options, request);
      }
      public virtual global::Remotecontrol.ForceResponse StopRemoteControl(global::Remotecontrol.ForceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StopRemoteControl(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Remotecontrol.ForceResponse StopRemoteControl(global::Remotecontrol.ForceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_StopRemoteControl, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Remotecontrol.ForceResponse> StopRemoteControlAsync(global::Remotecontrol.ForceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StopRemoteControlAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Remotecontrol.ForceResponse> StopRemoteControlAsync(global::Remotecontrol.ForceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_StopRemoteControl, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RemoteControlClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemoteControlClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemoteControlBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ApplyForce, serviceImpl.ApplyForce)
          .AddMethod(__Method_StopRemoteControl, serviceImpl.StopRemoteControl).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RemoteControlBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ApplyForce, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Remotecontrol.ForceRequest, global::Remotecontrol.ForceResponse>(serviceImpl.ApplyForce));
      serviceBinder.AddMethod(__Method_StopRemoteControl, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Remotecontrol.ForceRequest, global::Remotecontrol.ForceResponse>(serviceImpl.StopRemoteControl));
    }

  }
}
#endregion
