using System;
using System.Drawing;
using System.Runtime.InteropServices;

using OpenTK;
using Foundation;
using UIKit;

namespace Myo
{
	[BaseType (typeof (NSObject))]
	public partial interface TLMAccelerometerEvent : INSCopying
	{
		[Export("myo")] 
		TLMMyo Myo { get; set; }

		[Export("timestamp")]
		NSDate Timestamp { get; set; }

		[Export("vector")]
		Vector3 Vector { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMAngle : INSCopying
	{
		[Export("initWithAngle:")]
		IntPtr Constructor(TLMAngle angle);

		[Export("initWithDegrees:")]
		IntPtr Constructor(double degrees);

		[Export("initWithRadians:")]
		IntPtr Constructor(float radians);

		[Export("degrees")]
		double Degrees { get; set; }

		[Export("radians")]
		double Radians { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMArmUnsyncEvent : INSCopying
	{
		[Export("myo")] 
		TLMMyo Myo { get; set; }

		[Export("timestamp")]
		NSDate Timestamp { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMArmSyncEvent : INSCopying
	{
		[Export("myo")] 
		TLMMyo Myo { get; set; }

		[Export("arm")] 
		TLMArm Arm { get; set; }

		[Export("xDirection")]
		TLMArmXDirection xDirection { get; set; }

		[Export("timestamp")]
		NSDate Timestamp { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMEulerAngles : INSCopying
	{
		[Export("pitch")] 
		TLMAngle Pitch { get; set; }

		[Export("roll")] 
		TLMAngle Roll { get; set; }

		[Export("yaw")] 
		TLMAngle Yaw { get; set; }

		[Static, Export("anglesWithQuaternion:")]
		TLMEulerAngles GetAnglesWithQuaternion(Quaternion quaternion);
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMGyroscopeEvent : INSCopying
	{
		[Export("myo")] 
		TLMMyo Myo { get; set; }

		[Export("timestamp")]
		NSDate Timestamp { get; set; }

		[Export("vector")]
		Vector3 Vector { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMHub
	{
		[Export("attachByIdentifier:")] 
		void AttachByIdentifier(Guid identifier);

		[Export("attachToAny")] 
		void AttachToAny();

		[Export("attachToAdjacent")] 
		void AttachToAdjacent();

		[Export("detachFromMyo:")] 
		void DetachFromMyo(TLMMyo myo);

		[Export("myoDevices")] 
		TLMMyo[] GetDevices();

		[Static, Export("sharedHub")]
		TLMHub SharedHub();

		[Export("applicationIdentifier")]
		String ApplicationIdentifier { get; set; }

		[Export("myoConnectionAllowance")]
		uint MyoConnectionAllowance { get; set; }

		[Export("shouldNotifyInBackground")]
		bool ShouldNotifyInBackground { get; set; }

		[Export("shouldSendUsageData")]
		bool ShouldSendUsageData { get; set; }

		[Export("lockingPolicy")]
		TLMLockingPolicy LockingPolicy { get; set; }

		[Notification, Field("TLMHubDidAttachDeviceNotification", "__Internal")]
		NSString TLMHubDidAttachDeviceNotification { get; }

		[Notification, Field("TLMHubDidDetachDeviceNotification", "__Internal")]
		NSString TLMHubDidDetachDeviceNotification { get; }

		[Notification, Field("TLMHubDidConnectDeviceNotification", "__Internal")]
		NSString TLMHubDidConnectDeviceNotification { get; }

		[Notification, Field("TLMHubDidDisconnectDeviceNotification", "__Internal")]
		NSString TLMHubDidDisconnectDeviceNotification { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMLockEvent : INSCopying
	{

	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMMyo
	{


		[Export("readSignalStrengthWithResult:")]
		void ReadSignalStrengthWithResultAsync(Func<NSNumber> signalStrength);

		[Export("vibrateWithLength:")]
		void VibrateWithLength(TLMVibrationLength length);

		[Export("identifier")]
		Guid Identifier { get; set; }

		[Export("name")]
		String Name  { get; set; }

		[Export("state")]
		TLMMyoConnectionState State  { get; set; }


		[Notification, Field("TLMMyoDidReceiveOrientationEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveOrientationEventNotification { get; }

		[Notification, Field("TLMMyoDidReceiveAccelerometerEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveAccelerometerEventNotification { get; }

		[Notification, Field("TLMMyoDidReceiveGyroscopeEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveGyroscopeEventNotification { get; }

		[Notification, Field("TLMMyoDidReceivePoseChangedNotification", "__Internal")]
		NSString TLMMyoDidReceivePoseChangedNotification { get; }

		[Notification, Field("TLMMyoDidReceiveArmSyncEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveArmSyncEventNotification { get; }

		[Notification, Field("TLMMyoDidReceiveArmUnsyncEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveArmUnsyncEventNotification { get; }

		[Notification, Field("TLMMyoDidReceiveUnlockEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveUnlockEventNotification { get; }

		[Notification, Field("TLMMyoDidReceiveLockEventNotification", "__Internal")]
		NSString TLMMyoDidReceiveLockEventNotification { get; }

		[Field("kTLMKeyOrientationEvent", "__Internal")]
		NSString TLMKeyOrientationEvent { get; }

		[Field("kTLMKeyAccelerometerEvent", "__Internal")]
		NSString TLMKeyAccelerometerEvent { get; }

		[Field("kTLMKeyGyroscopeEvent", "__Internal")]
		NSString TLMKeyGyroscopeEvent { get; }

		[Field("kTLMKeyPose", "__Internal")]
		NSString TLMKeyPose { get; }

		[Field("kTLMKeyArmSyncEvent", "__Internal")]
		NSString TLMKeyArmSyncEvent { get; }

		[Field("kTLMKeyArmUnsyncEvent", "__Internal")]
		NSString TLMKeyArmUnsyncEvent { get; }

		[Field("kTLMKeyUnlockEvent", "__Internal")]
		NSString TLMKeyUnlockEvent { get; }

		[Field("kTLMKeyLockEvent", "__Internal")]
		NSString TLMKeyLockEvent { get; }

	}


	[BaseType (typeof (NSObject))]
	public partial interface TLMOrientationEvent : INSCopying
	{
		[Export("myo")] 
		TLMMyo Myo { get; set; }

		[Export("timestamp")]
		NSDate Timestamp { get; set; }

		[Export("quaternion")]
		Quaternion Quaternion { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMPose : INSCopying
	{
		[Export("myo")] 
		TLMMyo Myo { get; set; }

		[Export("timestamp")]
		NSDate Timestamp { get; set; }

		[Export("type")]
		TLMPoseType Type { get; set; }
	}

	[BaseType (typeof (UITableViewController))]
	public partial interface TLMSettingsViewController
	{
		[Static, Export("settingsInNavigationController")] 
		UINavigationController SettingsInNavigationController();

		[Static, Export("settingsInPopoverController")] 
		UIPopoverController SettingsInPopoverController();
	}

	[BaseType (typeof (NSObject))]
	public partial interface TLMUnlockEvent : INSCopying
	{

	}
}