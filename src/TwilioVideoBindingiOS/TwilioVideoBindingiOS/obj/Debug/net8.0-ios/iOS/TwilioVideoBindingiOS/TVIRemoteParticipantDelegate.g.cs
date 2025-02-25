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
	[Protocol (Name = "TVIRemoteParticipantDelegate", WrapperType = typeof (TVIRemoteParticipantDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidPublishVideoTrack", Selector = "remoteParticipant:didPublishVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidUnpublishVideoTrack", Selector = "remoteParticipant:didUnpublishVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidPublishAudioTrack", Selector = "remoteParticipant:didPublishAudioTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidUnpublishAudioTrack", Selector = "remoteParticipant:didUnpublishAudioTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidPublishDataTrack", Selector = "remoteParticipant:didPublishDataTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteDataTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidUnpublishDataTrack", Selector = "remoteParticipant:didUnpublishDataTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteDataTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidEnableVideoTrack", Selector = "remoteParticipant:didEnableVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidDisableVideoTrack", Selector = "remoteParticipant:didDisableVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidEnableAudioTrack", Selector = "remoteParticipant:didEnableAudioTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidDisableAudioTrack", Selector = "remoteParticipant:didDisableAudioTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSubscribeToVideoTrack", Selector = "didSubscribeToVideoTrack:publication:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrack), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToSubscribeToVideoTrack", Selector = "didFailToSubscribeToVideoTrack:error:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication), typeof (NSError), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnsubscribeFromVideoTrack", Selector = "didUnsubscribeFromVideoTrack:publication:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrack), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSubscribeToAudioTrack", Selector = "didSubscribeToAudioTrack:publication:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrack), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToSubscribeToAudioTrack", Selector = "didFailToSubscribeToAudioTrack:error:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication), typeof (NSError), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnsubscribeFromAudioTrack", Selector = "didUnsubscribeFromAudioTrack:publication:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrack), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSubscribeToDataTrack", Selector = "didSubscribeToDataTrack:publication:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteDataTrack), typeof (TwilioVideoBindingiOS.TVIRemoteDataTrackPublication), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToSubscribeToDataTrack", Selector = "didFailToSubscribeToDataTrack:error:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteDataTrackPublication), typeof (NSError), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUnsubscribeFromDataTrack", Selector = "didUnsubscribeFromDataTrack:publication:forParticipant:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteDataTrack), typeof (TwilioVideoBindingiOS.TVIRemoteDataTrackPublication), typeof (TwilioVideoBindingiOS.TVIRemoteParticipant) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantNetworkQualityLevelDidChange", Selector = "remoteParticipant:networkQualityLevelDidChange:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVINetworkQualityLevel) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantSwitchedOffVideoTrack", Selector = "remoteParticipant:switchedOffVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrack) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantSwitchedOnVideoTrack", Selector = "remoteParticipant:switchedOnVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrack) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidChangePublishPriorityForAudioTrack", Selector = "remoteParticipant:didChangePublishPriority:forAudioTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (string), typeof (TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidChangePublishPriorityForVideoTrack", Selector = "remoteParticipant:didChangePublishPriority:forVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (string), typeof (TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteParticipantDidChangePublishPriorityForDataTrack", Selector = "remoteParticipant:didChangePublishPriority:forDataTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIRemoteParticipant), typeof (string), typeof (TwilioVideoBindingiOS.TVIRemoteDataTrackPublication) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ITVIRemoteParticipantDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didPublishVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidPublishVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			_RemoteParticipantDidPublishVideoTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidPublishVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didPublishVideoTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didUnpublishVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidUnpublishVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			_RemoteParticipantDidUnpublishVideoTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidUnpublishVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didUnpublishVideoTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didPublishAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidPublishAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			_RemoteParticipantDidPublishAudioTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidPublishAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didPublishAudioTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didUnpublishAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidUnpublishAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			_RemoteParticipantDidUnpublishAudioTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidUnpublishAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didUnpublishAudioTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didPublishDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidPublishDataTrack (TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			_RemoteParticipantDidPublishDataTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidPublishDataTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didPublishDataTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didUnpublishDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidUnpublishDataTrack (TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			_RemoteParticipantDidUnpublishDataTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidUnpublishDataTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didUnpublishDataTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didEnableVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidEnableVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			_RemoteParticipantDidEnableVideoTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidEnableVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didEnableVideoTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didDisableVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidDisableVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			_RemoteParticipantDidDisableVideoTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidDisableVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didDisableVideoTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didEnableAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidEnableAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			_RemoteParticipantDidEnableAudioTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidEnableAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didEnableAudioTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didDisableAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidDisableAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			_RemoteParticipantDidDisableAudioTrack (this, participant, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidDisableAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didDisableAudioTrack:"), participant__handle__, publication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didSubscribeToVideoTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSubscribeToVideoTrack (TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			_DidSubscribeToVideoTrack (this, videoTrack, publication, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSubscribeToVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			var videoTrack__handle__ = videoTrack!.GetNonNullHandle (nameof (videoTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didSubscribeToVideoTrack:publication:forParticipant:"), videoTrack__handle__, publication__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didFailToSubscribeToVideoTrack:error:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToSubscribeToVideoTrack (TVIRemoteVideoTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			_DidFailToSubscribeToVideoTrack (this, publication, error, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToSubscribeToVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteVideoTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToSubscribeToVideoTrack:error:forParticipant:"), publication__handle__, error__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didUnsubscribeFromVideoTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnsubscribeFromVideoTrack (TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			_DidUnsubscribeFromVideoTrack (this, videoTrack, publication, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUnsubscribeFromVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			var videoTrack__handle__ = videoTrack!.GetNonNullHandle (nameof (videoTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUnsubscribeFromVideoTrack:publication:forParticipant:"), videoTrack__handle__, publication__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didSubscribeToAudioTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSubscribeToAudioTrack (TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			_DidSubscribeToAudioTrack (this, audioTrack, publication, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSubscribeToAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			var audioTrack__handle__ = audioTrack!.GetNonNullHandle (nameof (audioTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didSubscribeToAudioTrack:publication:forParticipant:"), audioTrack__handle__, publication__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didFailToSubscribeToAudioTrack:error:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToSubscribeToAudioTrack (TVIRemoteAudioTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			_DidFailToSubscribeToAudioTrack (this, publication, error, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToSubscribeToAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteAudioTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToSubscribeToAudioTrack:error:forParticipant:"), publication__handle__, error__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didUnsubscribeFromAudioTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnsubscribeFromAudioTrack (TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			_DidUnsubscribeFromAudioTrack (this, audioTrack, publication, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUnsubscribeFromAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			var audioTrack__handle__ = audioTrack!.GetNonNullHandle (nameof (audioTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUnsubscribeFromAudioTrack:publication:forParticipant:"), audioTrack__handle__, publication__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didSubscribeToDataTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSubscribeToDataTrack (TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			_DidSubscribeToDataTrack (this, dataTrack, publication, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSubscribeToDataTrack (ITVIRemoteParticipantDelegate This, TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			var dataTrack__handle__ = dataTrack!.GetNonNullHandle (nameof (dataTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didSubscribeToDataTrack:publication:forParticipant:"), dataTrack__handle__, publication__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didFailToSubscribeToDataTrack:error:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToSubscribeToDataTrack (TVIRemoteDataTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			_DidFailToSubscribeToDataTrack (this, publication, error, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToSubscribeToDataTrack (ITVIRemoteParticipantDelegate This, TVIRemoteDataTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToSubscribeToDataTrack:error:forParticipant:"), publication__handle__, error__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("didUnsubscribeFromDataTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnsubscribeFromDataTrack (TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			_DidUnsubscribeFromDataTrack (this, dataTrack, publication, participant);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUnsubscribeFromDataTrack (ITVIRemoteParticipantDelegate This, TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			var dataTrack__handle__ = dataTrack!.GetNonNullHandle (nameof (dataTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUnsubscribeFromDataTrack:publication:forParticipant:"), dataTrack__handle__, publication__handle__, participant__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:networkQualityLevelDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantNetworkQualityLevelDidChange (TVIRemoteParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			_RemoteParticipantNetworkQualityLevelDidChange (this, participant, networkQualityLevel);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantNetworkQualityLevelDidChange (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("remoteParticipant:networkQualityLevelDidChange:"), participant__handle__, (IntPtr) (long) networkQualityLevel);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:switchedOffVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantSwitchedOffVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			_RemoteParticipantSwitchedOffVideoTrack (this, participant, track);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantSwitchedOffVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:switchedOffVideoTrack:"), participant__handle__, track__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:switchedOnVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantSwitchedOnVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			_RemoteParticipantSwitchedOnVideoTrack (this, participant, track);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantSwitchedOnVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:switchedOnVideoTrack:"), participant__handle__, track__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didChangePublishPriority:forAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidChangePublishPriorityForAudioTrack (TVIRemoteParticipant participant, string priority, TVIRemoteAudioTrackPublication publication)
		{
			_RemoteParticipantDidChangePublishPriorityForAudioTrack (this, participant, priority, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidChangePublishPriorityForAudioTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, string priority, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			if (priority is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (priority));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var nspriority = CFString.CreateNative (priority);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didChangePublishPriority:forAudioTrack:"), participant__handle__, nspriority, publication__handle__);
			CFString.ReleaseNative (nspriority);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didChangePublishPriority:forVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidChangePublishPriorityForVideoTrack (TVIRemoteParticipant participant, string priority, TVIRemoteVideoTrackPublication publication)
		{
			_RemoteParticipantDidChangePublishPriorityForVideoTrack (this, participant, priority, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidChangePublishPriorityForVideoTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, string priority, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			if (priority is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (priority));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var nspriority = CFString.CreateNative (priority);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didChangePublishPriority:forVideoTrack:"), participant__handle__, nspriority, publication__handle__);
			CFString.ReleaseNative (nspriority);
		}
		[global::Foundation.OptionalMember]
		[Export ("remoteParticipant:didChangePublishPriority:forDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidChangePublishPriorityForDataTrack (TVIRemoteParticipant participant, string priority, TVIRemoteDataTrackPublication publication)
		{
			_RemoteParticipantDidChangePublishPriorityForDataTrack (this, participant, priority, publication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoteParticipantDidChangePublishPriorityForDataTrack (ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, string priority, TVIRemoteDataTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			if (priority is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (priority));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var nspriority = CFString.CreateNative (priority);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didChangePublishPriority:forDataTrack:"), participant__handle__, nspriority, publication__handle__);
			CFString.ReleaseNative (nspriority);
		}
		[DynamicDependencyAttribute ("DidFailToSubscribeToAudioTrack(TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication,Foundation.NSError,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidFailToSubscribeToDataTrack(TwilioVideoBindingiOS.TVIRemoteDataTrackPublication,Foundation.NSError,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidFailToSubscribeToVideoTrack(TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication,Foundation.NSError,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidSubscribeToAudioTrack(TwilioVideoBindingiOS.TVIRemoteAudioTrack,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidSubscribeToDataTrack(TwilioVideoBindingiOS.TVIRemoteDataTrack,TwilioVideoBindingiOS.TVIRemoteDataTrackPublication,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidSubscribeToVideoTrack(TwilioVideoBindingiOS.TVIRemoteVideoTrack,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidUnsubscribeFromAudioTrack(TwilioVideoBindingiOS.TVIRemoteAudioTrack,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidUnsubscribeFromDataTrack(TwilioVideoBindingiOS.TVIRemoteDataTrack,TwilioVideoBindingiOS.TVIRemoteDataTrackPublication,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("DidUnsubscribeFromVideoTrack(TwilioVideoBindingiOS.TVIRemoteVideoTrack,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication,TwilioVideoBindingiOS.TVIRemoteParticipant)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidChangePublishPriorityForAudioTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,System.String,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidChangePublishPriorityForDataTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,System.String,TwilioVideoBindingiOS.TVIRemoteDataTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidChangePublishPriorityForVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,System.String,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidDisableAudioTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidDisableVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidEnableAudioTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidEnableVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidPublishAudioTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidPublishDataTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteDataTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidPublishVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidUnpublishAudioTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteAudioTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidUnpublishDataTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteDataTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantDidUnpublishVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteVideoTrackPublication)")]
		[DynamicDependencyAttribute ("RemoteParticipantNetworkQualityLevelDidChange(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVINetworkQualityLevel)")]
		[DynamicDependencyAttribute ("RemoteParticipantSwitchedOffVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteVideoTrack)")]
		[DynamicDependencyAttribute ("RemoteParticipantSwitchedOnVideoTrack(TwilioVideoBindingiOS.TVIRemoteParticipant,TwilioVideoBindingiOS.TVIRemoteVideoTrack)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVIRemoteParticipantDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ITVIRemoteParticipantDelegate" /> interface to support all the methods from the TVIRemoteParticipantDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVIRemoteParticipantDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVIRemoteParticipantDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVIRemoteParticipantDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidPublishVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didPublishVideoTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidUnpublishVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didUnpublishVideoTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidPublishAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didPublishAudioTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidUnpublishAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didUnpublishAudioTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidPublishDataTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didPublishDataTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidUnpublishDataTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didUnpublishDataTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidEnableVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didEnableVideoTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidDisableVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didDisableVideoTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidEnableAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didEnableAudioTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidDisableAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didDisableAudioTrack:"), participant__handle__, publication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSubscribeToVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			var videoTrack__handle__ = videoTrack!.GetNonNullHandle (nameof (videoTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didSubscribeToVideoTrack:publication:forParticipant:"), videoTrack__handle__, publication__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToSubscribeToVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteVideoTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToSubscribeToVideoTrack:error:forParticipant:"), publication__handle__, error__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnsubscribeFromVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			var videoTrack__handle__ = videoTrack!.GetNonNullHandle (nameof (videoTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUnsubscribeFromVideoTrack:publication:forParticipant:"), videoTrack__handle__, publication__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSubscribeToAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			var audioTrack__handle__ = audioTrack!.GetNonNullHandle (nameof (audioTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didSubscribeToAudioTrack:publication:forParticipant:"), audioTrack__handle__, publication__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToSubscribeToAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteAudioTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToSubscribeToAudioTrack:error:forParticipant:"), publication__handle__, error__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnsubscribeFromAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			var audioTrack__handle__ = audioTrack!.GetNonNullHandle (nameof (audioTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUnsubscribeFromAudioTrack:publication:forParticipant:"), audioTrack__handle__, publication__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSubscribeToDataTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			var dataTrack__handle__ = dataTrack!.GetNonNullHandle (nameof (dataTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didSubscribeToDataTrack:publication:forParticipant:"), dataTrack__handle__, publication__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToSubscribeToDataTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteDataTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didFailToSubscribeToDataTrack:error:forParticipant:"), publication__handle__, error__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUnsubscribeFromDataTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			var dataTrack__handle__ = dataTrack!.GetNonNullHandle (nameof (dataTrack));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("didUnsubscribeFromDataTrack:publication:forParticipant:"), dataTrack__handle__, publication__handle__, participant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantNetworkQualityLevelDidChange (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("remoteParticipant:networkQualityLevelDidChange:"), participant__handle__, (IntPtr) (long) networkQualityLevel);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantSwitchedOffVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:switchedOffVideoTrack:"), participant__handle__, track__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantSwitchedOnVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var track__handle__ = track!.GetNonNullHandle (nameof (track));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:switchedOnVideoTrack:"), participant__handle__, track__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidChangePublishPriorityForAudioTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, string priority, TVIRemoteAudioTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			if (priority is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (priority));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var nspriority = CFString.CreateNative (priority);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didChangePublishPriority:forAudioTrack:"), participant__handle__, nspriority, publication__handle__);
			CFString.ReleaseNative (nspriority);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidChangePublishPriorityForVideoTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, string priority, TVIRemoteVideoTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			if (priority is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (priority));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var nspriority = CFString.CreateNative (priority);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didChangePublishPriority:forVideoTrack:"), participant__handle__, nspriority, publication__handle__);
			CFString.ReleaseNative (nspriority);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteParticipantDidChangePublishPriorityForDataTrack (this ITVIRemoteParticipantDelegate This, TVIRemoteParticipant participant, string priority, TVIRemoteDataTrackPublication publication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			if (priority is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (priority));
			var publication__handle__ = publication!.GetNonNullHandle (nameof (publication));
			var nspriority = CFString.CreateNative (priority);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("remoteParticipant:didChangePublishPriority:forDataTrack:"), participant__handle__, nspriority, publication__handle__);
			CFString.ReleaseNative (nspriority);
		}
	}
	internal unsafe sealed class TVIRemoteParticipantDelegateWrapper : BaseWrapper, ITVIRemoteParticipantDelegate {
		[Preserve (Conditional = true)]
		public TVIRemoteParticipantDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace TwilioVideoBindingiOS {
	[Protocol()]
	[Register("ApiDefinition__TwilioVideoBindingiOS_TVIRemoteParticipantDelegate", false)]
	[Model]
	public unsafe partial class TVIRemoteParticipantDelegate : NSObject, ITVIRemoteParticipantDelegate {
		/// <summary>Creates a new <see cref="TVIRemoteParticipantDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVIRemoteParticipantDelegate () : base (NSObjectFlag.Empty)
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
		protected TVIRemoteParticipantDelegate (NSObjectFlag t) : base (t)
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
		protected internal TVIRemoteParticipantDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didFailToSubscribeToAudioTrack:error:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToSubscribeToAudioTrack (TVIRemoteAudioTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToSubscribeToDataTrack:error:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToSubscribeToDataTrack (TVIRemoteDataTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didFailToSubscribeToVideoTrack:error:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToSubscribeToVideoTrack (TVIRemoteVideoTrackPublication publication, NSError error, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didSubscribeToAudioTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSubscribeToAudioTrack (TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didSubscribeToDataTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSubscribeToDataTrack (TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didSubscribeToVideoTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSubscribeToVideoTrack (TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didUnsubscribeFromAudioTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnsubscribeFromAudioTrack (TVIRemoteAudioTrack audioTrack, TVIRemoteAudioTrackPublication publication, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didUnsubscribeFromDataTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnsubscribeFromDataTrack (TVIRemoteDataTrack dataTrack, TVIRemoteDataTrackPublication publication, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("didUnsubscribeFromVideoTrack:publication:forParticipant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUnsubscribeFromVideoTrack (TVIRemoteVideoTrack videoTrack, TVIRemoteVideoTrackPublication publication, TVIRemoteParticipant participant)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didChangePublishPriority:forAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidChangePublishPriorityForAudioTrack (TVIRemoteParticipant participant, string priority, TVIRemoteAudioTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didChangePublishPriority:forDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidChangePublishPriorityForDataTrack (TVIRemoteParticipant participant, string priority, TVIRemoteDataTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didChangePublishPriority:forVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidChangePublishPriorityForVideoTrack (TVIRemoteParticipant participant, string priority, TVIRemoteVideoTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didDisableAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidDisableAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didDisableVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidDisableVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didEnableAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidEnableAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didEnableVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidEnableVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didPublishAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidPublishAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didPublishDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidPublishDataTrack (TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didPublishVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidPublishVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didUnpublishAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidUnpublishAudioTrack (TVIRemoteParticipant participant, TVIRemoteAudioTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didUnpublishDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidUnpublishDataTrack (TVIRemoteParticipant participant, TVIRemoteDataTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:didUnpublishVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantDidUnpublishVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrackPublication publication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:networkQualityLevelDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantNetworkQualityLevelDidChange (TVIRemoteParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:switchedOffVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantSwitchedOffVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("remoteParticipant:switchedOnVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteParticipantSwitchedOnVideoTrack (TVIRemoteParticipant participant, TVIRemoteVideoTrack track)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVIRemoteParticipantDelegate */
}
