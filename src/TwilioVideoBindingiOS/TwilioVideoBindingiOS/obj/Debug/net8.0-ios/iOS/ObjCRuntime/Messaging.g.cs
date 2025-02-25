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
namespace ApiDefinition {
	static partial class Messaging {
		internal const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";
		static internal System.Reflection.Assembly this_assembly = typeof (Messaging).Assembly;
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend (IntPtr receiever, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper (IntPtr receiever, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend_IntPtr (IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_UIntPtr (IntPtr receiver, IntPtr selector, UIntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_UIntPtr (IntPtr receiver, IntPtr selector, UIntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, nint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, nint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static uint UInt32_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static uint UInt32_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static global::AudioToolbox.AudioStreamBasicDescription AudioStreamBasicDescription_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static global::AudioToolbox.AudioStreamBasicDescription AudioStreamBasicDescription_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		public unsafe extern static global::AudioToolbox.AudioStreamBasicDescription AudioStreamBasicDescription_objc_msgSend_stret (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		public unsafe extern static global::AudioToolbox.AudioStreamBasicDescription AudioStreamBasicDescription_objc_msgSendSuper_stret (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_UIntPtr_UInt32_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1, uint arg2, nuint arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_UIntPtr_UInt32_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1, uint arg2, nuint arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static int int_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static int int_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_bool (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static double Double_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static double Double_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static global::CoreMedia.CMVideoDimensions CMVideoDimensions_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static global::CoreMedia.CMVideoDimensions CMVideoDimensions_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		public unsafe extern static global::CoreMedia.CMVideoDimensions CMVideoDimensions_objc_msgSend_stret (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		public unsafe extern static global::CoreMedia.CMVideoDimensions CMVideoDimensions_objc_msgSendSuper_stret (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_IntPtr_NativeHandle (IntPtr receiver, IntPtr selector, IntPtr arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (IntPtr receiver, IntPtr selector, IntPtr arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_IntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_IntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, IntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nfloat nfloat_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nfloat nfloat_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static float float_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static float float_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_UIntPtr_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_UIntPtr_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static ulong UInt64_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static ulong UInt64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static ushort UInt16_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static ushort UInt16_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_bool_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_bool_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static long Int64_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static long Int64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_bool (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_UIntPtr_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_CMVideoDimensions (IntPtr receiver, IntPtr selector, global::CoreMedia.CMVideoDimensions arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_CMVideoDimensions (IntPtr receiver, IntPtr selector, global::CoreMedia.CMVideoDimensions arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static global::CoreMedia.CMTime CMTime_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static global::CoreMedia.CMTime CMTime_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend_stret")]
		public unsafe extern static global::CoreMedia.CMTime CMTime_objc_msgSend_stret (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper_stret")]
		public unsafe extern static global::CoreMedia.CMTime CMTime_objc_msgSendSuper_stret (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_CMTime_NativeHandle_UIntPtr (IntPtr receiver, IntPtr selector, global::CoreMedia.CMTime arg1, NativeHandle arg2, UIntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_CMTime_NativeHandle_UIntPtr (IntPtr receiver, IntPtr selector, global::CoreMedia.CMTime arg1, NativeHandle arg2, UIntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_Double_NativeHandle_UIntPtr (IntPtr receiver, IntPtr selector, double arg1, NativeHandle arg2, UIntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_Double_NativeHandle_UIntPtr (IntPtr receiver, IntPtr selector, double arg1, NativeHandle arg2, UIntPtr arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_CMVideoDimensions_UIntPtr (IntPtr receiver, IntPtr selector, global::CoreMedia.CMVideoDimensions arg1, UIntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_CMVideoDimensions_UIntPtr (IntPtr receiver, IntPtr selector, global::CoreMedia.CMVideoDimensions arg1, UIntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_CGRect_NativeHandle (IntPtr receiver, IntPtr selector, CGRect arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_CGRect_NativeHandle (IntPtr receiver, IntPtr selector, CGRect arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_CMVideoDimensions (IntPtr receiver, IntPtr selector, NativeHandle arg1, global::CoreMedia.CMVideoDimensions arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_CMVideoDimensions (IntPtr receiver, IntPtr selector, NativeHandle arg1, global::CoreMedia.CMVideoDimensions arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_UIntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, UIntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_UIntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, UIntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSend_UIntPtr (IntPtr receiver, IntPtr selector, UIntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSendSuper_UIntPtr (IntPtr receiver, IntPtr selector, UIntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_UIntPtr_UIntPtr (IntPtr receiver, IntPtr selector, UIntPtr arg1, UIntPtr arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_UIntPtr_UIntPtr (IntPtr receiver, IntPtr selector, UIntPtr arg1, UIntPtr arg2);
	}
}
