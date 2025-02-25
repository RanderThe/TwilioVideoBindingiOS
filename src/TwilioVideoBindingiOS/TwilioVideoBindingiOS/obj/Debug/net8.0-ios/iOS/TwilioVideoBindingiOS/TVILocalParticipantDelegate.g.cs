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
	[Protocol (Name = "TVILocalParticipantDelegate", WrapperType = typeof (TVILocalParticipantDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPublishAudioTrack", Selector = "localParticipant:didPublishAudioTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVILocalAudioTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToPublishAudioTrack", Selector = "localParticipant:didFailToPublishAudioTrack:withError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVILocalAudioTrack), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPublishDataTrack", Selector = "localParticipant:didPublishDataTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVILocalDataTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToPublishDataTrack", Selector = "localParticipant:didFailToPublishDataTrack:withError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVILocalDataTrack), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPublishVideoTrack", Selector = "localParticipant:didPublishVideoTrack:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVILocalVideoTrackPublication) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToPublishVideoTrack", Selector = "localParticipant:didFailToPublishVideoTrack:withError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVILocalVideoTrack), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NetworkQualityLevelDidChange", Selector = "localParticipant:networkQualityLevelDidChange:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVILocalParticipant), typeof (TwilioVideoBindingiOS.TVINetworkQualityLevel) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ITVILocalParticipantDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:didPublishAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishAudioTrack (TVILocalParticipant participant, TVILocalAudioTrackPublication audioTrackPublication)
		{
			_DidPublishAudioTrack (this, participant, audioTrackPublication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPublishAudioTrack (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalAudioTrackPublication audioTrackPublication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var audioTrackPublication__handle__ = audioTrackPublication!.GetNonNullHandle (nameof (audioTrackPublication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didPublishAudioTrack:"), participant__handle__, audioTrackPublication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:didFailToPublishAudioTrack:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPublishAudioTrack (TVILocalParticipant participant, TVILocalAudioTrack audioTrack, NSError error)
		{
			_DidFailToPublishAudioTrack (this, participant, audioTrack, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToPublishAudioTrack (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalAudioTrack audioTrack, NSError error)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var audioTrack__handle__ = audioTrack!.GetNonNullHandle (nameof (audioTrack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didFailToPublishAudioTrack:withError:"), participant__handle__, audioTrack__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:didPublishDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishDataTrack (TVILocalParticipant participant, TVILocalDataTrackPublication dataTrackPublication)
		{
			_DidPublishDataTrack (this, participant, dataTrackPublication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPublishDataTrack (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalDataTrackPublication dataTrackPublication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var dataTrackPublication__handle__ = dataTrackPublication!.GetNonNullHandle (nameof (dataTrackPublication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didPublishDataTrack:"), participant__handle__, dataTrackPublication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:didFailToPublishDataTrack:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPublishDataTrack (TVILocalParticipant participant, TVILocalDataTrack dataTrack, NSError error)
		{
			_DidFailToPublishDataTrack (this, participant, dataTrack, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToPublishDataTrack (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalDataTrack dataTrack, NSError error)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var dataTrack__handle__ = dataTrack!.GetNonNullHandle (nameof (dataTrack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didFailToPublishDataTrack:withError:"), participant__handle__, dataTrack__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:didPublishVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishVideoTrack (TVILocalParticipant participant, TVILocalVideoTrackPublication videoTrackPublication)
		{
			_DidPublishVideoTrack (this, participant, videoTrackPublication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPublishVideoTrack (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalVideoTrackPublication videoTrackPublication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var videoTrackPublication__handle__ = videoTrackPublication!.GetNonNullHandle (nameof (videoTrackPublication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didPublishVideoTrack:"), participant__handle__, videoTrackPublication__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:didFailToPublishVideoTrack:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPublishVideoTrack (TVILocalParticipant participant, TVILocalVideoTrack videoTrack, NSError error)
		{
			_DidFailToPublishVideoTrack (this, participant, videoTrack, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFailToPublishVideoTrack (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalVideoTrack videoTrack, NSError error)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var videoTrack__handle__ = videoTrack!.GetNonNullHandle (nameof (videoTrack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didFailToPublishVideoTrack:withError:"), participant__handle__, videoTrack__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("localParticipant:networkQualityLevelDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NetworkQualityLevelDidChange (TVILocalParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			_NetworkQualityLevelDidChange (this, participant, networkQualityLevel);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NetworkQualityLevelDidChange (ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("localParticipant:networkQualityLevelDidChange:"), participant__handle__, (IntPtr) (long) networkQualityLevel);
		}
		[DynamicDependencyAttribute ("DidFailToPublishAudioTrack(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVILocalAudioTrack,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFailToPublishDataTrack(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVILocalDataTrack,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidFailToPublishVideoTrack(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVILocalVideoTrack,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DidPublishAudioTrack(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVILocalAudioTrackPublication)")]
		[DynamicDependencyAttribute ("DidPublishDataTrack(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVILocalDataTrackPublication)")]
		[DynamicDependencyAttribute ("DidPublishVideoTrack(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVILocalVideoTrackPublication)")]
		[DynamicDependencyAttribute ("NetworkQualityLevelDidChange(TwilioVideoBindingiOS.TVILocalParticipant,TwilioVideoBindingiOS.TVINetworkQualityLevel)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVILocalParticipantDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ITVILocalParticipantDelegate" /> interface to support all the methods from the TVILocalParticipantDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVILocalParticipantDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVILocalParticipantDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVILocalParticipantDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPublishAudioTrack (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalAudioTrackPublication audioTrackPublication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var audioTrackPublication__handle__ = audioTrackPublication!.GetNonNullHandle (nameof (audioTrackPublication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didPublishAudioTrack:"), participant__handle__, audioTrackPublication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToPublishAudioTrack (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalAudioTrack audioTrack, NSError error)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var audioTrack__handle__ = audioTrack!.GetNonNullHandle (nameof (audioTrack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didFailToPublishAudioTrack:withError:"), participant__handle__, audioTrack__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPublishDataTrack (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalDataTrackPublication dataTrackPublication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var dataTrackPublication__handle__ = dataTrackPublication!.GetNonNullHandle (nameof (dataTrackPublication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didPublishDataTrack:"), participant__handle__, dataTrackPublication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToPublishDataTrack (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalDataTrack dataTrack, NSError error)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var dataTrack__handle__ = dataTrack!.GetNonNullHandle (nameof (dataTrack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didFailToPublishDataTrack:withError:"), participant__handle__, dataTrack__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPublishVideoTrack (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalVideoTrackPublication videoTrackPublication)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var videoTrackPublication__handle__ = videoTrackPublication!.GetNonNullHandle (nameof (videoTrackPublication));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didPublishVideoTrack:"), participant__handle__, videoTrackPublication__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToPublishVideoTrack (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVILocalVideoTrack videoTrack, NSError error)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			var videoTrack__handle__ = videoTrack!.GetNonNullHandle (nameof (videoTrack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("localParticipant:didFailToPublishVideoTrack:withError:"), participant__handle__, videoTrack__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NetworkQualityLevelDidChange (this ITVILocalParticipantDelegate This, TVILocalParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			var participant__handle__ = participant!.GetNonNullHandle (nameof (participant));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("localParticipant:networkQualityLevelDidChange:"), participant__handle__, (IntPtr) (long) networkQualityLevel);
		}
	}
	internal unsafe sealed class TVILocalParticipantDelegateWrapper : BaseWrapper, ITVILocalParticipantDelegate {
		[Preserve (Conditional = true)]
		public TVILocalParticipantDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace TwilioVideoBindingiOS {
	[Protocol()]
	[Register("ApiDefinition__TwilioVideoBindingiOS_TVILocalParticipantDelegate", false)]
	[Model]
	public unsafe partial class TVILocalParticipantDelegate : NSObject, ITVILocalParticipantDelegate {
		/// <summary>Creates a new <see cref="TVILocalParticipantDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVILocalParticipantDelegate () : base (NSObjectFlag.Empty)
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
		protected TVILocalParticipantDelegate (NSObjectFlag t) : base (t)
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
		protected internal TVILocalParticipantDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("localParticipant:didFailToPublishAudioTrack:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPublishAudioTrack (TVILocalParticipant participant, TVILocalAudioTrack audioTrack, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("localParticipant:didFailToPublishDataTrack:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPublishDataTrack (TVILocalParticipant participant, TVILocalDataTrack dataTrack, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("localParticipant:didFailToPublishVideoTrack:withError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToPublishVideoTrack (TVILocalParticipant participant, TVILocalVideoTrack videoTrack, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("localParticipant:didPublishAudioTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishAudioTrack (TVILocalParticipant participant, TVILocalAudioTrackPublication audioTrackPublication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("localParticipant:didPublishDataTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishDataTrack (TVILocalParticipant participant, TVILocalDataTrackPublication dataTrackPublication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("localParticipant:didPublishVideoTrack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPublishVideoTrack (TVILocalParticipant participant, TVILocalVideoTrackPublication videoTrackPublication)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("localParticipant:networkQualityLevelDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NetworkQualityLevelDidChange (TVILocalParticipant participant, TVINetworkQualityLevel networkQualityLevel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVILocalParticipantDelegate */
}
