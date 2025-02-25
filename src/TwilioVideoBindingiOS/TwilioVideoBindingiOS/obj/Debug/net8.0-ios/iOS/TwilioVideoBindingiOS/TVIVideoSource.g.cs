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
	[Protocol (Name = "TVIVideoSource", WrapperType = typeof (TVIVideoSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestOutputFormat", Selector = "requestOutputFormat:", ParameterType = new Type [] { typeof (TwilioVideoBindingiOS.TVIVideoFormat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Sink", Selector = "sink", PropertyType = typeof (TwilioVideoBindingiOS.TVIVideoSink), GetterSelector = "sink", SetterSelector = "setSink:", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Screencast", Selector = "screencast", PropertyType = typeof (bool), GetterSelector = "isScreencast", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ITVIVideoSource : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("requestOutputFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestOutputFormat (TVIVideoFormat outputFormat)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RequestOutputFormat (ITVIVideoSource This, TVIVideoFormat outputFormat)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[DynamicDependencyAttribute ("RequestOutputFormat(TwilioVideoBindingiOS.TVIVideoFormat)")]
		[DynamicDependencyAttribute ("Screencast")]
		[DynamicDependencyAttribute ("Sink")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVIVideoSource ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual TVIVideoSink? Sink {
			[Export ("sink", ArgumentSemantic.Weak)]
			get {
				return _GetSink (this);
			}
			[Export ("setSink:", ArgumentSemantic.Weak)]
			set {
				_SetSink (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static TVIVideoSink _GetSink (ITVIVideoSource This)
		{
			return  Runtime.GetNSObject<TVIVideoSink> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sink")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSink (ITVIVideoSource This, TVIVideoSink? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSink:"), value__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Screencast {
			[Export ("isScreencast")]
			get {
				return _GetScreencast (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetScreencast (ITVIVideoSource This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isScreencast"));
			return ret != 0;
		}
	}
	internal unsafe sealed class TVIVideoSourceWrapper : BaseWrapper, ITVIVideoSource {
		[Preserve (Conditional = true)]
		public TVIVideoSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("requestOutputFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RequestOutputFormat (TVIVideoFormat outputFormat)
		{
			var outputFormat__handle__ = outputFormat!.GetNonNullHandle (nameof (outputFormat));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("requestOutputFormat:"), outputFormat__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public TVIVideoSink? Sink {
			[Export ("sink", ArgumentSemantic.Weak)]
			get {
				return  Runtime.GetNSObject<TVIVideoSink> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sink")))!;
			}
			[Export ("setSink:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSink:"), value__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Screencast {
			[Export ("isScreencast")]
			get {
				byte ret;
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScreencast"));
				return ret != 0;
			}
		}
	}
}
namespace TwilioVideoBindingiOS {
	[Protocol()]
	[Register("ApiDefinition__TwilioVideoBindingiOS_TVIVideoSource", false)]
	[Model]
	public unsafe abstract partial class TVIVideoSource : NSObject, ITVIVideoSource {
		/// <summary>Creates a new <see cref="TVIVideoSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected TVIVideoSource () : base (NSObjectFlag.Empty)
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
		protected TVIVideoSource (NSObjectFlag t) : base (t)
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
		protected internal TVIVideoSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("requestOutputFormat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestOutputFormat (TVIVideoFormat outputFormat)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Screencast {
			[Export ("isScreencast")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TVIVideoSink? Sink {
			[Export ("sink", ArgumentSemantic.Weak)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSink:", ArgumentSemantic.Weak)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class TVIVideoSource */
}
