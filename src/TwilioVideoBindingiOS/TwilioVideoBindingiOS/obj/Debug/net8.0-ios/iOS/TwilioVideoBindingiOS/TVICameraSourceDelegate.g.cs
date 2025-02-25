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
	[Protocol (Name = "TVICameraSourceDelegate", WrapperType = typeof (TVICameraSourceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSourceInterruptionEnded", Selector = "cameraSourceInterruptionEnded:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVICameraSource) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSourceWasInterrupted", Selector = "cameraSourceWasInterrupted:reason:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVICameraSource), typeof (AVCaptureSessionInterruptionReason) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CameraSource", Selector = "cameraSource:didFailWithError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVICameraSource), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ITVICameraSourceDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("cameraSourceInterruptionEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraSourceInterruptionEnded (TVICameraSource source)
		{
			_CameraSourceInterruptionEnded (this, source);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CameraSourceInterruptionEnded (ITVICameraSourceDelegate This, TVICameraSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraSourceInterruptionEnded:"), source__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraSourceWasInterrupted:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraSourceWasInterrupted (TVICameraSource source, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			_CameraSourceWasInterrupted (this, source, reason);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CameraSourceWasInterrupted (ITVICameraSourceDelegate This, TVICameraSource source, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("cameraSourceWasInterrupted:reason:"), source__handle__, (IntPtr) (long) reason);
		}
		[global::Foundation.OptionalMember]
		[Export ("cameraSource:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraSource (TVICameraSource source, NSError error)
		{
			_CameraSource (this, source, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CameraSource (ITVICameraSourceDelegate This, TVICameraSource source, NSError error)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraSource:didFailWithError:"), source__handle__, error__handle__);
		}
		[DynamicDependencyAttribute ("CameraSource(TwilioVideoBindingiOS.TVICameraSource,Foundation.NSError)")]
		[DynamicDependencyAttribute ("CameraSourceInterruptionEnded(TwilioVideoBindingiOS.TVICameraSource)")]
		[DynamicDependencyAttribute ("CameraSourceWasInterrupted(TwilioVideoBindingiOS.TVICameraSource,AVFoundation.AVCaptureSessionInterruptionReason)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVICameraSourceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ITVICameraSourceDelegate" /> interface to support all the methods from the TVICameraSourceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVICameraSourceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVICameraSourceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVICameraSourceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraSourceInterruptionEnded (this ITVICameraSourceDelegate This, TVICameraSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cameraSourceInterruptionEnded:"), source__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraSourceWasInterrupted (this ITVICameraSourceDelegate This, TVICameraSource source, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("cameraSourceWasInterrupted:reason:"), source__handle__, (IntPtr) (long) reason);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CameraSource (this ITVICameraSourceDelegate This, TVICameraSource source, NSError error)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("cameraSource:didFailWithError:"), source__handle__, error__handle__);
		}
	}
	internal unsafe sealed class TVICameraSourceDelegateWrapper : BaseWrapper, ITVICameraSourceDelegate {
		[Preserve (Conditional = true)]
		public TVICameraSourceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace TwilioVideoBindingiOS {
	[Protocol()]
	[Register("ApiDefinition__TwilioVideoBindingiOS_TVICameraSourceDelegate", false)]
	[Model]
	public unsafe partial class TVICameraSourceDelegate : NSObject, ITVICameraSourceDelegate {
		/// <summary>Creates a new <see cref="TVICameraSourceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVICameraSourceDelegate () : base (NSObjectFlag.Empty)
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
		protected TVICameraSourceDelegate (NSObjectFlag t) : base (t)
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
		protected internal TVICameraSourceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("cameraSource:didFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraSource (TVICameraSource source, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraSourceInterruptionEnded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraSourceInterruptionEnded (TVICameraSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("cameraSourceWasInterrupted:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CameraSourceWasInterrupted (TVICameraSource source, global::AVFoundation.AVCaptureSessionInterruptionReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVICameraSourceDelegate */
}
