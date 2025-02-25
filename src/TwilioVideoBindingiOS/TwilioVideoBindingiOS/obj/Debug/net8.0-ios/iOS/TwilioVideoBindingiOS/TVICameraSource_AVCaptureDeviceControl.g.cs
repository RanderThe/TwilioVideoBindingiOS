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
	public unsafe static partial class TVICameraSource_AVCaptureDeviceControl  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("TVICameraSource");
		[Export ("torchLevel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static float GetTorchLevel (this TVICameraSource This)
		{
			return global::ApiDefinition.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("torchLevel"));
		}
		[Export ("torchMode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AVFoundation.AVCaptureTorchMode GetTorchMode (this TVICameraSource This)
		{
			global::AVFoundation.AVCaptureTorchMode ret;
			ret = (AVCaptureTorchMode) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("torchMode"));
			return ret!;
		}
		[Export ("zoomFactor")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetZoomFactor (this TVICameraSource This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("zoomFactor"));
		}
		[Export ("setTorchLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTorchLevel (this TVICameraSource This, float torchLevel)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setTorchLevel:"), torchLevel);
		}
		[Export ("setTorchMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetTorchMode (this TVICameraSource This, global::AVFoundation.AVCaptureTorchMode torchMode)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTorchMode:"), (IntPtr) (long) torchMode);
		}
		[Export ("setZoomFactor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetZoomFactor (this TVICameraSource This, nfloat zoomFactor)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setZoomFactor:"), zoomFactor);
		}
	} /* class TVICameraSource_AVCaptureDeviceControl */
}
