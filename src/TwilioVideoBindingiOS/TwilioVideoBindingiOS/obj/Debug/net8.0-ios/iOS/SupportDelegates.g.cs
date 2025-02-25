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
	#nullable enable
	public delegate void TVIAVAudioSessionConfigurationBlock ();
	public delegate void TVIAppScreenSourceOptionsBuilderBlock (TwilioVideoBindingiOS.TVIAppScreenSourceOptionsBuilder arg0);
	public delegate void TVIAppScreenSourceStartedBlock (NSError? arg0);
	public delegate void TVIAppScreenSourceStoppedBlock (NSError? arg0);
	public delegate void TVIAudioOptionsBuilderBlock (TwilioVideoBindingiOS.TVIAudioOptionsBuilder arg0);
	public delegate void TVICameraSourceOptionsBuilderBlock (TwilioVideoBindingiOS.TVICameraSourceOptionsBuilder arg0);
	public delegate void TVICameraSourceStartedBlock (AVCaptureDevice arg0, TwilioVideoBindingiOS.TVIVideoFormat arg1, NSError? arg2);
	public delegate void TVICameraSourceStoppedBlock (NSError? arg0);
	public delegate void TVIConnectOptionsBuilderBlock (TwilioVideoBindingiOS.TVIConnectOptionsBuilder arg0);
	public delegate void TVIDataTrackOptionsBuilderBlock (TwilioVideoBindingiOS.TVIDataTrackOptionsBuilder arg0);
	public delegate void TVIIceOptionsBuilderBlock (TwilioVideoBindingiOS.TVIIceOptionsBuilder arg0);
	public delegate void TVIRoomGetStatsBlock (TwilioVideoBindingiOS.TVIStatsReport[] arg0);
	public delegate void TVIVideoBandwidthProfileOptionsBuilderBlock (TwilioVideoBindingiOS.TVIVideoBandwidthProfileOptionsBuilder arg0);
	public delegate void TVIVideoContentPreferencesBuilderBlock (TwilioVideoBindingiOS.TVIVideoContentPreferencesBuilder arg0);
}
