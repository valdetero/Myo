using System;
using ObjCRuntime;

[assembly: LinkWith ("libMyoKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "UIKit Foundation")]
