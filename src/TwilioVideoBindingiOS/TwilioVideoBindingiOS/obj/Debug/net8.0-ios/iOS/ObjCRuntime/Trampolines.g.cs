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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock))]
		unsafe internal delegate void DTVIAVAudioSessionConfigurationBlock (IntPtr block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIAVAudioSessionConfigurationBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock))]
			internal static unsafe void Invoke (IntPtr block) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock> (block);
				if (del is not null) {
					del ();
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock callback)
			{
				delegate* unmanaged<IntPtr, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIAVAudioSessionConfigurationBlock), nameof (Invoke));
			}
		} /* class SDTVIAVAudioSessionConfigurationBlock */
		internal sealed class NIDTVIAVAudioSessionConfigurationBlock : TrampolineBlockBase {
			DTVIAVAudioSessionConfigurationBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIAVAudioSessionConfigurationBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIAVAudioSessionConfigurationBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIAVAudioSessionConfigurationBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIAVAudioSessionConfigurationBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDTVIAVAudioSessionConfigurationBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock))]
		unsafe internal delegate void DTVIAppScreenSourceOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIAppScreenSourceOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIAppScreenSourceOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIAppScreenSourceOptionsBuilderBlock */
		internal sealed class NIDTVIAppScreenSourceOptionsBuilderBlock : TrampolineBlockBase {
			DTVIAppScreenSourceOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIAppScreenSourceOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIAppScreenSourceOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIAppScreenSourceOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIAppScreenSourceOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock))]
		unsafe internal delegate void DTVIAppScreenSourceStartedBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIAppScreenSourceStartedBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSError> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIAppScreenSourceStartedBlock), nameof (Invoke));
			}
		} /* class SDTVIAppScreenSourceStartedBlock */
		internal sealed class NIDTVIAppScreenSourceStartedBlock : TrampolineBlockBase {
			DTVIAppScreenSourceStartedBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIAppScreenSourceStartedBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIAppScreenSourceStartedBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIAppScreenSourceStartedBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIAppScreenSourceStartedBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError? arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIAppScreenSourceStartedBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock))]
		unsafe internal delegate void DTVIAppScreenSourceStoppedBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIAppScreenSourceStoppedBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSError> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIAppScreenSourceStoppedBlock), nameof (Invoke));
			}
		} /* class SDTVIAppScreenSourceStoppedBlock */
		internal sealed class NIDTVIAppScreenSourceStoppedBlock : TrampolineBlockBase {
			DTVIAppScreenSourceStoppedBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIAppScreenSourceStoppedBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIAppScreenSourceStoppedBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIAppScreenSourceStoppedBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIAppScreenSourceStoppedBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError? arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIAppScreenSourceStoppedBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock))]
		unsafe internal delegate void DTVIAudioOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIAudioOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIAudioOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIAudioOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIAudioOptionsBuilderBlock */
		internal sealed class NIDTVIAudioOptionsBuilderBlock : TrampolineBlockBase {
			DTVIAudioOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIAudioOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIAudioOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIAudioOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIAudioOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIAudioOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIAudioOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock))]
		unsafe internal delegate void DTVICameraSourceOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVICameraSourceOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVICameraSourceOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVICameraSourceOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVICameraSourceOptionsBuilderBlock */
		internal sealed class NIDTVICameraSourceOptionsBuilderBlock : TrampolineBlockBase {
			DTVICameraSourceOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVICameraSourceOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVICameraSourceOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVICameraSourceOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVICameraSourceOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVICameraSourceOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock))]
		unsafe internal delegate void DTVICameraSourceStartedBlock (IntPtr block, NativeHandle arg0, NativeHandle arg1, NativeHandle arg2);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVICameraSourceStartedBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0, NativeHandle arg1, NativeHandle arg2) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<AVCaptureDevice> (arg0)!,  Runtime.GetNSObject<TwilioVideoBindingiOS.TVIVideoFormat> (arg1)!,  Runtime.GetNSObject<NSError> (arg2)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, NativeHandle, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVICameraSourceStartedBlock), nameof (Invoke));
			}
		} /* class SDTVICameraSourceStartedBlock */
		internal sealed class NIDTVICameraSourceStartedBlock : TrampolineBlockBase {
			DTVICameraSourceStartedBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVICameraSourceStartedBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVICameraSourceStartedBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVICameraSourceStartedBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVICameraSourceStartedBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::AVFoundation.AVCaptureDevice arg0, global::TwilioVideoBindingiOS.TVIVideoFormat arg1, NSError? arg2)
			{
				var arg0__handle__ = arg0.GetHandle ();
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				invoker (BlockPointer, arg0__handle__, arg1__handle__, arg2__handle__);
			}
		} /* class NIDTVICameraSourceStartedBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock))]
		unsafe internal delegate void DTVICameraSourceStoppedBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVICameraSourceStoppedBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<NSError> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVICameraSourceStoppedBlock), nameof (Invoke));
			}
		} /* class SDTVICameraSourceStoppedBlock */
		internal sealed class NIDTVICameraSourceStoppedBlock : TrampolineBlockBase {
			DTVICameraSourceStoppedBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVICameraSourceStoppedBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVICameraSourceStoppedBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVICameraSourceStoppedBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVICameraSourceStoppedBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSError? arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVICameraSourceStoppedBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock))]
		unsafe internal delegate void DTVIConnectOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIConnectOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIConnectOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIConnectOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIConnectOptionsBuilderBlock */
		internal sealed class NIDTVIConnectOptionsBuilderBlock : TrampolineBlockBase {
			DTVIConnectOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIConnectOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIConnectOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIConnectOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIConnectOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIConnectOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIConnectOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock))]
		unsafe internal delegate void DTVIDataTrackOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIDataTrackOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIDataTrackOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIDataTrackOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIDataTrackOptionsBuilderBlock */
		internal sealed class NIDTVIDataTrackOptionsBuilderBlock : TrampolineBlockBase {
			DTVIDataTrackOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIDataTrackOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIDataTrackOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIDataTrackOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIDataTrackOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIDataTrackOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock))]
		unsafe internal delegate void DTVIIceOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIIceOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIIceOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIIceOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIIceOptionsBuilderBlock */
		internal sealed class NIDTVIIceOptionsBuilderBlock : TrampolineBlockBase {
			DTVIIceOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIIceOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIIceOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIIceOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIIceOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIIceOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIIceOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock))]
		unsafe internal delegate void DTVIRoomGetStatsBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIRoomGetStatsBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock> (block);
				if (del is not null) {
					del (CFArray.ArrayFromHandle<global::TwilioVideoBindingiOS.TVIStatsReport> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIRoomGetStatsBlock), nameof (Invoke));
			}
		} /* class SDTVIRoomGetStatsBlock */
		internal sealed class NIDTVIRoomGetStatsBlock : TrampolineBlockBase {
			DTVIRoomGetStatsBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIRoomGetStatsBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIRoomGetStatsBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIRoomGetStatsBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIRoomGetStatsBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIStatsReport[] arg0)
			{
				if (arg0 is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arg0));
				var nsa_arg0 = arg0 is null ? null : NSArray.FromNSObjects (arg0);
				invoker (BlockPointer, nsa_arg0.GetHandle ());
				if (nsa_arg0 is not null)
					nsa_arg0.Dispose ();
			}
		} /* class NIDTVIRoomGetStatsBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock))]
		unsafe internal delegate void DTVIVideoBandwidthProfileOptionsBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIVideoBandwidthProfileOptionsBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIVideoBandwidthProfileOptionsBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIVideoBandwidthProfileOptionsBuilderBlock */
		internal sealed class NIDTVIVideoBandwidthProfileOptionsBuilderBlock : TrampolineBlockBase {
			DTVIVideoBandwidthProfileOptionsBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIVideoBandwidthProfileOptionsBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIVideoBandwidthProfileOptionsBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIVideoBandwidthProfileOptionsBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIVideoBandwidthProfileOptionsBuilderBlock */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock))]
		unsafe internal delegate void DTVIVideoContentPreferencesBuilderBlock (IntPtr block, NativeHandle arg0);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDTVIVideoContentPreferencesBuilderBlock {
			[Preserve (Conditional = true)]
			[UnmanagedCallersOnly]
			[UserDelegateType (typeof (global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock))]
			internal static unsafe void Invoke (IntPtr block, NativeHandle arg0) {
				var del = BlockLiteral.GetTarget<global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock> (block);
				if (del is not null) {
					del ( Runtime.GetNSObject<TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilder> (arg0)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock callback)
			{
				delegate* unmanaged<IntPtr, NativeHandle, void> trampoline = &Invoke;
				return new BlockLiteral (trampoline, callback, typeof (SDTVIVideoContentPreferencesBuilderBlock), nameof (Invoke));
			}
		} /* class SDTVIVideoContentPreferencesBuilderBlock */
		internal sealed class NIDTVIVideoContentPreferencesBuilderBlock : TrampolineBlockBase {
			DTVIVideoContentPreferencesBuilderBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDTVIVideoContentPreferencesBuilderBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DTVIVideoContentPreferencesBuilderBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilderBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDTVIVideoContentPreferencesBuilderBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilder arg0)
			{
				var arg0__handle__ = arg0.GetHandle ();
				invoker (BlockPointer, arg0__handle__);
			}
		} /* class NIDTVIVideoContentPreferencesBuilderBlock */
	}
}
