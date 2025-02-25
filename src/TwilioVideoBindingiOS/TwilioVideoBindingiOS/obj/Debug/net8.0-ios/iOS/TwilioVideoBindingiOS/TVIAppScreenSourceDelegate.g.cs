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
	[Protocol (Name = "TVIAppScreenSourceDelegate", WrapperType = typeof (TVIAppScreenSourceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AppScreenSourceDidBecomeAvailable", Selector = "appScreenSourceDidBecomeAvailable:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIAppScreenSource) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AppScreenSourceDidBecomeUnavailable", Selector = "appScreenSourceDidBecomeUnavailable:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIAppScreenSource) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AppScreenSourceDidReceiveCaptureError", Selector = "appScreenSource:didReceiveCaptureError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIAppScreenSource), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AppScreenSourceDidStopCapturingWithError", Selector = "appScreenSource:didStopCapturingWithError:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIAppScreenSource), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ITVIAppScreenSourceDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("appScreenSourceDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidBecomeAvailable (TVIAppScreenSource source)
		{
			_AppScreenSourceDidBecomeAvailable (this, source);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AppScreenSourceDidBecomeAvailable (ITVIAppScreenSourceDelegate This, TVIAppScreenSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSourceDidBecomeAvailable:"), source__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("appScreenSourceDidBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidBecomeUnavailable (TVIAppScreenSource source)
		{
			_AppScreenSourceDidBecomeUnavailable (this, source);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AppScreenSourceDidBecomeUnavailable (ITVIAppScreenSourceDelegate This, TVIAppScreenSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSourceDidBecomeUnavailable:"), source__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("appScreenSource:didReceiveCaptureError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidReceiveCaptureError (TVIAppScreenSource source, NSError error)
		{
			_AppScreenSourceDidReceiveCaptureError (this, source, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AppScreenSourceDidReceiveCaptureError (ITVIAppScreenSourceDelegate This, TVIAppScreenSource source, NSError error)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSource:didReceiveCaptureError:"), source__handle__, error__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("appScreenSource:didStopCapturingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidStopCapturingWithError (TVIAppScreenSource source, NSError? error)
		{
			_AppScreenSourceDidStopCapturingWithError (this, source, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AppScreenSourceDidStopCapturingWithError (ITVIAppScreenSourceDelegate This, TVIAppScreenSource source, NSError? error)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var error__handle__ = error.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSource:didStopCapturingWithError:"), source__handle__, error__handle__);
		}
		[DynamicDependencyAttribute ("AppScreenSourceDidBecomeAvailable(TwilioVideoBindingiOS.TVIAppScreenSource)")]
		[DynamicDependencyAttribute ("AppScreenSourceDidBecomeUnavailable(TwilioVideoBindingiOS.TVIAppScreenSource)")]
		[DynamicDependencyAttribute ("AppScreenSourceDidReceiveCaptureError(TwilioVideoBindingiOS.TVIAppScreenSource,Foundation.NSError)")]
		[DynamicDependencyAttribute ("AppScreenSourceDidStopCapturingWithError(TwilioVideoBindingiOS.TVIAppScreenSource,Foundation.NSError)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVIAppScreenSourceDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ITVIAppScreenSourceDelegate" /> interface to support all the methods from the TVIAppScreenSourceDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVIAppScreenSourceDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVIAppScreenSourceDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVIAppScreenSourceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AppScreenSourceDidBecomeAvailable (this ITVIAppScreenSourceDelegate This, TVIAppScreenSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSourceDidBecomeAvailable:"), source__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AppScreenSourceDidBecomeUnavailable (this ITVIAppScreenSourceDelegate This, TVIAppScreenSource source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSourceDidBecomeUnavailable:"), source__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AppScreenSourceDidReceiveCaptureError (this ITVIAppScreenSourceDelegate This, TVIAppScreenSource source, NSError error)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSource:didReceiveCaptureError:"), source__handle__, error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AppScreenSourceDidStopCapturingWithError (this ITVIAppScreenSourceDelegate This, TVIAppScreenSource source, NSError? error)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var error__handle__ = error.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("appScreenSource:didStopCapturingWithError:"), source__handle__, error__handle__);
		}
	}
	internal unsafe sealed class TVIAppScreenSourceDelegateWrapper : BaseWrapper, ITVIAppScreenSourceDelegate {
		[Preserve (Conditional = true)]
		public TVIAppScreenSourceDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace TwilioVideoBindingiOS {
	[Protocol()]
	[Register("ApiDefinition__TwilioVideoBindingiOS_TVIAppScreenSourceDelegate", false)]
	[Model]
	public unsafe partial class TVIAppScreenSourceDelegate : NSObject, ITVIAppScreenSourceDelegate {
		/// <summary>Creates a new <see cref="TVIAppScreenSourceDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVIAppScreenSourceDelegate () : base (NSObjectFlag.Empty)
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
		protected TVIAppScreenSourceDelegate (NSObjectFlag t) : base (t)
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
		protected internal TVIAppScreenSourceDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("appScreenSourceDidBecomeAvailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidBecomeAvailable (TVIAppScreenSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("appScreenSourceDidBecomeUnavailable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidBecomeUnavailable (TVIAppScreenSource source)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("appScreenSource:didReceiveCaptureError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidReceiveCaptureError (TVIAppScreenSource source, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("appScreenSource:didStopCapturingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppScreenSourceDidStopCapturingWithError (TVIAppScreenSource source, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TVIAppScreenSourceDelegate */
}
