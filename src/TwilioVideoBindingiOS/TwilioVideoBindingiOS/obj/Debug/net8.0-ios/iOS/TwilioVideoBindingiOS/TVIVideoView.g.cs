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
	[Register("TVIVideoView", true)]
	public unsafe partial class TVIVideoView : global::UIKit.UIView, ITVIVideoRenderer {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("TVIVideoView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="TVIVideoView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TVIVideoView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public TVIVideoView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
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
		protected TVIVideoView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		protected internal TVIVideoView (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:delegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TVIVideoView (CGRect frame, TVIVideoViewDelegate? @delegate)
			: base (NSObjectFlag.Empty)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("initWithFrame:delegate:"), frame, @delegate__handle__), "initWithFrame:delegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithFrame:delegate:"), frame, @delegate__handle__), "initWithFrame:delegate:");
			}
		}
		[Export ("invalidateRenderer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateRenderer ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidateRenderer"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("invalidateRenderer"));
			}
		}
		[Export ("renderFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenderFrame (TVIVideoFrame frame)
		{
			var frame__handle__ = frame!.GetNonNullHandle (nameof (frame));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("renderFrame:"), frame__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("renderFrame:"), frame__handle__);
			}
		}
		[Export ("updateVideoSize:orientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateVideoSize (global::CoreMedia.CMVideoDimensions videoSize, TVIVideoOrientation orientation)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CMVideoDimensions_UIntPtr (this.Handle, Selector.GetHandle ("updateVideoSize:orientation:"), videoSize, (UIntPtr) (ulong) orientation);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMVideoDimensions_UIntPtr (this.SuperHandle, Selector.GetHandle ("updateVideoSize:orientation:"), videoSize, (UIntPtr) (ulong) orientation);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TVIVideoViewDelegate? Delegate {
			get {
				return (WeakDelegate as TVIVideoViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasVideoData {
			[Export ("hasVideoData")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasVideoData"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasVideoData"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Mirror {
			[Export ("shouldMirror")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldMirror"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldMirror"));
				}
				return ret != 0;
			}
			[Export ("setMirror:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMirror:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMirror:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreMedia.CMVideoDimensions VideoDimensions {
			[Export ("videoDimensions", ArgumentSemantic.Assign)]
			get {
				global::CoreMedia.CMVideoDimensions ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSend (this.Handle, Selector.GetHandle ("videoDimensions"));
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSend (this.Handle, Selector.GetHandle ("videoDimensions"));
					} else if (Runtime.Arch == Arch.DEVICE) {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSend_stret (this.Handle, Selector.GetHandle ("videoDimensions"));
					} else {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSend (this.Handle, Selector.GetHandle ("videoDimensions"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoDimensions"));
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoDimensions"));
					} else if (Runtime.Arch == Arch.DEVICE) {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSendSuper_stret (this.SuperHandle, Selector.GetHandle ("videoDimensions"));
					} else {
						ret = global::ApiDefinition.Messaging.CMVideoDimensions_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoDimensions"));
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TVIVideoOrientation VideoOrientation {
			[Export ("videoOrientation", ArgumentSemantic.Assign)]
			get {
				TVIVideoOrientation ret;
				if (IsDirectBinding) {
					ret = (TwilioVideoBindingiOS.TVIVideoOrientation) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoOrientation"));
				} else {
					ret = (TwilioVideoBindingiOS.TVIVideoOrientation) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoOrientation"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ViewShouldRotateContent {
			[Export ("viewShouldRotateContent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("viewShouldRotateContent"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewShouldRotateContent"));
				}
				return ret != 0;
			}
			[Export ("setViewShouldRotateContent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setViewShouldRotateContent:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setViewShouldRotateContent:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")))!;
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")))!;
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::TwilioVideoBindingiOS.TVIVideoView.Appearance" /> property or by calling <see cref="global::TwilioVideoBindingiOS.TVIVideoView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class TVIVideoViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal TVIVideoViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />, they should use the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance Appearance {
			get { return new TVIVideoViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::TwilioVideoBindingiOS.TVIVideoView.TVIVideoViewAppearance" /> for the subclass of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.Appearance" /> property, or the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = TVIVideoView.GetAppearance<MyTVIVideoViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance GetAppearance<T> () where T: TVIVideoView {
			return new TVIVideoViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />, they should use the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new TVIVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::TwilioVideoBindingiOS.TVIVideoView.TVIVideoViewAppearance" /> for <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = TVIVideoView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />, they should use the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance GetAppearance (UITraitCollection traits) {
			return new TVIVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::TwilioVideoBindingiOS.TVIVideoView.TVIVideoViewAppearance" /> for <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = TVIVideoView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />, they should use the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new TVIVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::TwilioVideoBindingiOS.TVIVideoView.TVIVideoViewAppearance" /> for the subclass of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.Appearance" /> property, or the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = TVIVideoView.GetAppearance<MyTVIVideoViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance GetAppearance<T> (UITraitCollection traits) where T: TVIVideoView {
			return new TVIVideoViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::TwilioVideoBindingiOS.TVIVideoView.TVIVideoViewAppearance" /> for the subclass of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::TwilioVideoBindingiOS.TVIVideoView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.Appearance" /> property, or the <see cref="global::TwilioVideoBindingiOS.TVIVideoView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = TVIVideoView.GetAppearance<MyTVIVideoViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new TVIVideoViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: TVIVideoView{
			return new TVIVideoViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class TVIVideoView */
}
