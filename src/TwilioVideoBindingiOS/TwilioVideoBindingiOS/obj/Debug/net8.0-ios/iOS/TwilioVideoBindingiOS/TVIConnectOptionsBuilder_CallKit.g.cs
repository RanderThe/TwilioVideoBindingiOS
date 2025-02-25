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
	public unsafe static partial class TVIConnectOptionsBuilder_CallKit  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("TVIConnectOptionsBuilder");
		[Export ("uuid")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUuid GetUuid (this TVIConnectOptionsBuilder This)
		{
			return  Runtime.GetNSObject<NSUuid> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("uuid")))!;
		}
		[Export ("setUuid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUuid (this TVIConnectOptionsBuilder This, NSUuid uuid)
		{
			var uuid__handle__ = uuid!.GetNonNullHandle (nameof (uuid));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setUuid:"), uuid__handle__);
		}
	} /* class TVIConnectOptionsBuilder_CallKit */
}
