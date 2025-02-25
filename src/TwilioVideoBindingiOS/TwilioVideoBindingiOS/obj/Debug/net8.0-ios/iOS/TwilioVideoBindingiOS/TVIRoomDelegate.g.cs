//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace TwilioVideoBindingiOS {
	[Protocol (Name = "TVIRoomDelegate", WrapperType = typeof (TVIRoomDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidConnectToRoom", Selector = "didConnectToRoom:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomDidFailToConnectWithError", Selector = "room:didFailToConnectWithError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomDidDisconnectWithError", Selector = "room:didDisconnectWithError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomIsReconnectingWithError", Selector = "room:isReconnectingWithError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReconnectToRoom", Selector = "didReconnectToRoom:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomParticipantDidConnect", Selector = "room:participantDidConnect:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomParticipantDidDisconnect", Selector = "room:participantDidDisconnect:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomParticipantIsReconnecting", Selector = "room:participantIsReconnecting:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomParticipantDidReconnect", Selector = "room:participantDidReconnect:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomDidStartRecording", Selector = "roomDidStartRecording:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomDidStopRecording", Selector = "roomDidStopRecording:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RoomDominantSpeakerDidChange", Selector = "room:dominantSpeakerDidChange:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRoom), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ITVIRoomDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("didConnectToRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectToRoom (TVIRoom room)
		{
			_DidConnectToRoom (this, room);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidConnectToRoom (ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didConnectToRoom:"), room__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:didFailToConnectWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidFailToConnectWithError (TVIRoom room, NSError error)
		{
			_RoomDidFailToConnectWithError (this, room, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomDidFailToConnectWithError (ITVIRoomDelegate This, TVIRoom room, NSError error)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:didFailToConnectWithError:"), room__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:didDisconnectWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidDisconnectWithError (TVIRoom room, NSError? error)
		{
			_RoomDidDisconnectWithError (this, room, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomDidDisconnectWithError (ITVIRoomDelegate This, TVIRoom room, NSError? error)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var error__handle__ = error.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:didDisconnectWithError:"), room__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:isReconnectingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomIsReconnectingWithError (TVIRoom room, NSError error)
		{
			_RoomIsReconnectingWithError (this, room, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomIsReconnectingWithError (ITVIRoomDelegate This, TVIRoom room, NSError error)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:isReconnectingWithError:"), room__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didReconnectToRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReconnectToRoom (TVIRoom room)
		{
			_DidReconnectToRoom (this, room);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidReconnectToRoom (ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReconnectToRoom:"), room__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:participantDidConnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantDidConnect (TVIRoom room, TVIRemoteParticipant participant)
		{
			_RoomParticipantDidConnect (this, room, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomParticipantDidConnect (ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantDidConnect:"), room__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:participantDidDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantDidDisconnect (TVIRoom room, TVIRemoteParticipant participant)
		{
			_RoomParticipantDidDisconnect (this, room, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomParticipantDidDisconnect (ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantDidDisconnect:"), room__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:participantIsReconnecting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantIsReconnecting (TVIRoom room, TVIRemoteParticipant participant)
		{
			_RoomParticipantIsReconnecting (this, room, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomParticipantIsReconnecting (ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantIsReconnecting:"), room__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:participantDidReconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantDidReconnect (TVIRoom room, TVIRemoteParticipant participant)
		{
			_RoomParticipantDidReconnect (this, room, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomParticipantDidReconnect (ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantDidReconnect:"), room__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("roomDidStartRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidStartRecording (TVIRoom room)
		{
			_RoomDidStartRecording (this, room);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomDidStartRecording (ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("roomDidStartRecording:"), room__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("roomDidStopRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidStopRecording (TVIRoom room)
		{
			_RoomDidStopRecording (this, room);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomDidStopRecording (ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("roomDidStopRecording:"), room__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("room:dominantSpeakerDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDominantSpeakerDidChange (TVIRoom room, TVIRemoteParticipant? participant)
		{
			_RoomDominantSpeakerDidChange (this, room, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RoomDominantSpeakerDidChange (ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant? participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:dominantSpeakerDidChange:"), room__handle__, participant__handle__);
		}
		[DynamicDependencyAttribute ("DidConnectToRoom(TwilioVideoBindingiOS.TVIRoom)")]
		[DynamicDependencyAttribute ("DidReconnectToRoom(TwilioVideoBindingiOS.TVIRoom)")]
		[DynamicDependencyAttribute ("RoomDidDisconnectWithError(TwilioVideoBindingiOS.TVIRoom,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RoomDidFailToConnectWithError(TwilioVideoBindingiOS.TVIRoom,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RoomDidStartRecording(TwilioVideoBindingiOS.TVIRoom)")]
		[DynamicDependencyAttribute ("RoomDidStopRecording(TwilioVideoBindingiOS.TVIRoom)")]
		[DynamicDependencyAttribute ("RoomDominantSpeakerDidChange(TwilioVideoBindingiOS.TVIRoom,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("RoomIsReconnectingWithError(TwilioVideoBindingiOS.TVIRoom,Foundation.NSError)")]
		[DynamicDependencyAttribute ("RoomParticipantDidConnect(TwilioVideoBindingiOS.TVIRoom,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("RoomParticipantDidDisconnect(TwilioVideoBindingiOS.TVIRoom,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("RoomParticipantDidReconnect(TwilioVideoBindingiOS.TVIRoom,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("RoomParticipantIsReconnecting(TwilioVideoBindingiOS.TVIRoom,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVIRoomDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ITVIRoomDelegate" /> interface to support all the methods from the TVIRoomDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVIRoomDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVIRoomDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVIRoomDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidConnectToRoom (this ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didConnectToRoom:"), room__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomDidFailToConnectWithError (this ITVIRoomDelegate This, TVIRoom room, NSError error)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:didFailToConnectWithError:"), room__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomDidDisconnectWithError (this ITVIRoomDelegate This, TVIRoom room, NSError? error)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var error__handle__ = error.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:didDisconnectWithError:"), room__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomIsReconnectingWithError (this ITVIRoomDelegate This, TVIRoom room, NSError error)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:isReconnectingWithError:"), room__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidReconnectToRoom (this ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didReconnectToRoom:"), room__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomParticipantDidConnect (this ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantDidConnect:"), room__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomParticipantDidDisconnect (this ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantDidDisconnect:"), room__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomParticipantIsReconnecting (this ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantIsReconnecting:"), room__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomParticipantDidReconnect (this ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:participantDidReconnect:"), room__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomDidStartRecording (this ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("roomDidStartRecording:"), room__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomDidStopRecording (this ITVIRoomDelegate This, TVIRoom room)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("roomDidStopRecording:"), room__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RoomDominantSpeakerDidChange (this ITVIRoomDelegate This, TVIRoom room, TVIRemoteParticipant? participant)
		{
			var room__handle__ = room!.GetNonNullHandle (nameof (room));
			var participant__handle__ = participant.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("room:dominantSpeakerDidChange:"), room__handle__, participant__handle__);
		}
	}
	internal unsafe sealed class TVIRoomDelegateWrapper : BaseWrapper, ITVIRoomDelegate {
		[Preserve (Conditional = true)]
		public TVIRoomDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace TwilioVideoBindingiOS {
	[Protocol()]
	[Register("ApiDefinition__TwilioVideoBindingiOS_TVIRoomDelegate", false)]
	[Model]
	public unsafe partial class TVIRoomDelegate : NSObject, ITVIRoomDelegate {
		/// <summary>Creates a new <see cref="TVIRoomDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVIRoomDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, initWithFrame, frame);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected TVIRoomDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TVIRoomDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didConnectToRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidConnectToRoom (TVIRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didReconnectToRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidReconnectToRoom (TVIRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:didDisconnectWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidDisconnectWithError (TVIRoom room, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:didFailToConnectWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidFailToConnectWithError (TVIRoom room, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("roomDidStartRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidStartRecording (TVIRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("roomDidStopRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDidStopRecording (TVIRoom room)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:dominantSpeakerDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomDominantSpeakerDidChange (TVIRoom room, TVIRemoteParticipant? participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:isReconnectingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomIsReconnectingWithError (TVIRoom room, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:participantDidConnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantDidConnect (TVIRoom room, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:participantDidDisconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantDidDisconnect (TVIRoom room, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:participantDidReconnect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantDidReconnect (TVIRoom room, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("room:participantIsReconnecting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RoomParticipantIsReconnecting (TVIRoom room, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVIRoomDelegate */
}
