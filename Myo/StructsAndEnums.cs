using System;

namespace Myo
{
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

	//TLMPose
	public enum TLMPoseType
	{
		TLMPoseTypeRest			= 0,
		TLMPoseTypeFist			= 1,
		TLMPoseTypeWaveIn		= 2,
		TLMPoseTypeWaveOut		= 3,
		TLMPoseTypeFingersSpread= 4,
		TLMPoseTypeThumbToPinky = 6,
		TLMPoseTypeUnknown		= 0xffff
	}

	//TLMArmRecognizedEvent
	public enum TLMArm
	{
		TLMArmRight,
		TLMArmLeft
	}
	public enum TLMArmXDirection
	{
		TLMArmXDirectionTowardWrist,
		TLMArmXDirectionTowardElbow
	}
}

