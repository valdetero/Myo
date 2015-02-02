using System;

namespace Myo
{
	//TLMHub
	public enum TLMLockingPolicy
	{
		TLMLockingPolicyStandard,
		TLMLockingPolicyNone
	}

	//TLMMyo
	public enum TLMMyoConnectionState
	{
		TLMMyoConnectionStateConnected,
		TLMMyoConnectionStateConnecting,
		TLMMyoConnectionStateDisconnected
	}
	public enum TLMVibrationLength 
	{
		TLMVibrationLengthShort,
		TLMVibrationLengthMedium,
		TLMVibrationLengthLong
	}
	public enum TLMUnlockType
	{
		TLMUnlockTypeTimed,
		TLMUnlockTypeHold
	}

	//TLMPose
	public enum TLMPoseType
	{
		TLMPoseTypeRest			= 0,
		TLMPoseTypeFist			= 1,
		TLMPoseTypeWaveIn		= 2,
		TLMPoseTypeWaveOut		= 3,
		TLMPoseTypeFingersSpread= 4,
		TLMPoseTypeDoubleTap	= 6,
		TLMPoseTypeUnknown		= 0xffff
	}

	//TLMArmRecognizedEvent
	public enum TLMArm
	{
		TLMArmUnknown,
		TLMArmRight,
		TLMArmLeft
	}
	public enum TLMArmXDirection
	{
		TLMArmXDirectionUnknown,
		TLMArmXDirectionTowardWrist,
		TLMArmXDirectionTowardElbow
	}
}

