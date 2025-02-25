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
	public unsafe static partial class Constants  {
		[Field ("TVIAudioChannelsMono",  "__Internal")]
		public static nuint TVIAudioChannelsMono {
			get {
				return Dlfcn.GetUIntPtr (Libraries.__Internal.Handle, "TVIAudioChannelsMono");
			}
		}
		[Field ("TVIAudioChannelsStereo",  "__Internal")]
		public static nuint TVIAudioChannelsStereo {
			get {
				return Dlfcn.GetUIntPtr (Libraries.__Internal.Handle, "TVIAudioChannelsStereo");
			}
		}
		[Field ("TVIAudioSampleRate16000",  "__Internal")]
		public static uint TVIAudioSampleRate16000 {
			get {
				return Dlfcn.GetUInt32 (Libraries.__Internal.Handle, "TVIAudioSampleRate16000");
			}
		}
		[Field ("TVIAudioSampleRate24000",  "__Internal")]
		public static uint TVIAudioSampleRate24000 {
			get {
				return Dlfcn.GetUInt32 (Libraries.__Internal.Handle, "TVIAudioSampleRate24000");
			}
		}
		[Field ("TVIAudioSampleRate32000",  "__Internal")]
		public static uint TVIAudioSampleRate32000 {
			get {
				return Dlfcn.GetUInt32 (Libraries.__Internal.Handle, "TVIAudioSampleRate32000");
			}
		}
		[Field ("TVIAudioSampleRate44100",  "__Internal")]
		public static uint TVIAudioSampleRate44100 {
			get {
				return Dlfcn.GetUInt32 (Libraries.__Internal.Handle, "TVIAudioSampleRate44100");
			}
		}
		[Field ("TVIAudioSampleRate48000",  "__Internal")]
		public static uint TVIAudioSampleRate48000 {
			get {
				return Dlfcn.GetUInt32 (Libraries.__Internal.Handle, "TVIAudioSampleRate48000");
			}
		}
		[Field ("TVIAudioSampleRate8000",  "__Internal")]
		public static uint TVIAudioSampleRate8000 {
			get {
				return Dlfcn.GetUInt32 (Libraries.__Internal.Handle, "TVIAudioSampleRate8000");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIBandwidthProfileModeCollaboration;
		[Field ("TVIBandwidthProfileModeCollaboration",  "__Internal")]
		public static NSString TVIBandwidthProfileModeCollaboration {
			get {
				if (_TVIBandwidthProfileModeCollaboration is null)
					_TVIBandwidthProfileModeCollaboration = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIBandwidthProfileModeCollaboration")!;
				return _TVIBandwidthProfileModeCollaboration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIBandwidthProfileModeGrid;
		[Field ("TVIBandwidthProfileModeGrid",  "__Internal")]
		public static NSString TVIBandwidthProfileModeGrid {
			get {
				if (_TVIBandwidthProfileModeGrid is null)
					_TVIBandwidthProfileModeGrid = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIBandwidthProfileModeGrid")!;
				return _TVIBandwidthProfileModeGrid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIBandwidthProfileModePresentation;
		[Field ("TVIBandwidthProfileModePresentation",  "__Internal")]
		public static NSString TVIBandwidthProfileModePresentation {
			get {
				if (_TVIBandwidthProfileModePresentation is null)
					_TVIBandwidthProfileModePresentation = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIBandwidthProfileModePresentation")!;
				return _TVIBandwidthProfileModePresentation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIClientTrackSwitchOffControlAuto;
		[Field ("TVIClientTrackSwitchOffControlAuto",  "__Internal")]
		public static NSString TVIClientTrackSwitchOffControlAuto {
			get {
				if (_TVIClientTrackSwitchOffControlAuto is null)
					_TVIClientTrackSwitchOffControlAuto = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIClientTrackSwitchOffControlAuto")!;
				return _TVIClientTrackSwitchOffControlAuto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIClientTrackSwitchOffControlManual;
		[Field ("TVIClientTrackSwitchOffControlManual",  "__Internal")]
		public static NSString TVIClientTrackSwitchOffControlManual {
			get {
				if (_TVIClientTrackSwitchOffControlManual is null)
					_TVIClientTrackSwitchOffControlManual = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIClientTrackSwitchOffControlManual")!;
				return _TVIClientTrackSwitchOffControlManual;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVITrackPriorityHigh;
		[Field ("TVITrackPriorityHigh",  "__Internal")]
		public static NSString TVITrackPriorityHigh {
			get {
				if (_TVITrackPriorityHigh is null)
					_TVITrackPriorityHigh = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVITrackPriorityHigh")!;
				return _TVITrackPriorityHigh;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVITrackPriorityLow;
		[Field ("TVITrackPriorityLow",  "__Internal")]
		public static NSString TVITrackPriorityLow {
			get {
				if (_TVITrackPriorityLow is null)
					_TVITrackPriorityLow = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVITrackPriorityLow")!;
				return _TVITrackPriorityLow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVITrackPriorityStandard;
		[Field ("TVITrackPriorityStandard",  "__Internal")]
		public static NSString TVITrackPriorityStandard {
			get {
				if (_TVITrackPriorityStandard is null)
					_TVITrackPriorityStandard = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVITrackPriorityStandard")!;
				return _TVITrackPriorityStandard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVITrackSwitchOffModeDetected;
		[Field ("TVITrackSwitchOffModeDetected",  "__Internal")]
		public static NSString TVITrackSwitchOffModeDetected {
			get {
				if (_TVITrackSwitchOffModeDetected is null)
					_TVITrackSwitchOffModeDetected = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVITrackSwitchOffModeDetected")!;
				return _TVITrackSwitchOffModeDetected;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVITrackSwitchOffModeDisabled;
		[Field ("TVITrackSwitchOffModeDisabled",  "__Internal")]
		public static NSString TVITrackSwitchOffModeDisabled {
			get {
				if (_TVITrackSwitchOffModeDisabled is null)
					_TVITrackSwitchOffModeDisabled = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVITrackSwitchOffModeDisabled")!;
				return _TVITrackSwitchOffModeDisabled;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVITrackSwitchOffModePredicted;
		[Field ("TVITrackSwitchOffModePredicted",  "__Internal")]
		public static NSString TVITrackSwitchOffModePredicted {
			get {
				if (_TVITrackSwitchOffModePredicted is null)
					_TVITrackSwitchOffModePredicted = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVITrackSwitchOffModePredicted")!;
				return _TVITrackSwitchOffModePredicted;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIVideoContentPreferencesModeAuto;
		[Field ("TVIVideoContentPreferencesModeAuto",  "__Internal")]
		public static NSString TVIVideoContentPreferencesModeAuto {
			get {
				if (_TVIVideoContentPreferencesModeAuto is null)
					_TVIVideoContentPreferencesModeAuto = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIVideoContentPreferencesModeAuto")!;
				return _TVIVideoContentPreferencesModeAuto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIVideoContentPreferencesModeManual;
		[Field ("TVIVideoContentPreferencesModeManual",  "__Internal")]
		public static NSString TVIVideoContentPreferencesModeManual {
			get {
				if (_TVIVideoContentPreferencesModeManual is null)
					_TVIVideoContentPreferencesModeManual = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIVideoContentPreferencesModeManual")!;
				return _TVIVideoContentPreferencesModeManual;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TVIVideoEncodingModeAuto;
		[Field ("TVIVideoEncodingModeAuto",  "__Internal")]
		public static NSString TVIVideoEncodingModeAuto {
			get {
				if (_TVIVideoEncodingModeAuto is null)
					_TVIVideoEncodingModeAuto = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TVIVideoEncodingModeAuto")!;
				return _TVIVideoEncodingModeAuto;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _kTVIAppScreenSourceErrorDomain;
		[Field ("kTVIAppScreenSourceErrorDomain",  "__Internal")]
		public static NSString kTVIAppScreenSourceErrorDomain {
			get {
				if (_kTVIAppScreenSourceErrorDomain is null)
					_kTVIAppScreenSourceErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "kTVIAppScreenSourceErrorDomain")!;
				return _kTVIAppScreenSourceErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _kTVICameraSourceErrorDomain;
		[Field ("kTVICameraSourceErrorDomain",  "__Internal")]
		public static NSString kTVICameraSourceErrorDomain {
			get {
				if (_kTVICameraSourceErrorDomain is null)
					_kTVICameraSourceErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "kTVICameraSourceErrorDomain")!;
				return _kTVICameraSourceErrorDomain;
			}
		}
		[Field ("kTVIDataTrackOptionsDefaultMaxPacketLifeTime",  "__Internal")]
		public static int kTVIDataTrackOptionsDefaultMaxPacketLifeTime {
			get {
				return Dlfcn.GetInt32 (Libraries.__Internal.Handle, "kTVIDataTrackOptionsDefaultMaxPacketLifeTime");
			}
		}
		[Field ("kTVIDataTrackOptionsDefaultMaxRetransmits",  "__Internal")]
		public static int kTVIDataTrackOptionsDefaultMaxRetransmits {
			get {
				return Dlfcn.GetInt32 (Libraries.__Internal.Handle, "kTVIDataTrackOptionsDefaultMaxRetransmits");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _kTVIErrorDomain;
		[Field ("kTVIErrorDomain",  "__Internal")]
		public static NSString kTVIErrorDomain {
			get {
				if (_kTVIErrorDomain is null)
					_kTVIErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "kTVIErrorDomain")!;
				return _kTVIErrorDomain;
			}
		}
	} /* class Constants */
}
