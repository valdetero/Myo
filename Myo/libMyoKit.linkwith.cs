using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMyoKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "OpenTK")]
