// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    public partial class ChannelMoments
    {
        [SuppressUnmanagedCodeSecurity]
        private static unsafe class NativeMethods
        {
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            public static class X64
            {
                #if PLATFORM_AnyCPU
                static X64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr ChannelMoments_Centroid_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseAngle_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr ChannelMoments_EllipseAxis_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseEccentricity_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseIntensity_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_GetHuInvariants(IntPtr Instance, UIntPtr index);
            }
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            public static class ARM64
            {
                #if PLATFORM_AnyCPU
                static ARM64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr ChannelMoments_Centroid_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseAngle_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr ChannelMoments_EllipseAxis_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseEccentricity_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseIntensity_Get(IntPtr instance);
                [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_GetHuInvariants(IntPtr Instance, UIntPtr index);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr ChannelMoments_Centroid_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseAngle_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr ChannelMoments_EllipseAxis_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseEccentricity_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_EllipseIntensity_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double ChannelMoments_GetHuInvariants(IntPtr Instance, UIntPtr index);
            }
            #endif
        }
        private unsafe sealed class NativeChannelMoments : ConstNativeInstance
        {
            static NativeChannelMoments() { Environment.Initialize(); }
            public NativeChannelMoments(IntPtr instance)
            {
                Instance = instance;
            }
            protected override string TypeName
            {
                get
                {
                    return nameof(ChannelMoments);
                }
            }
            public PointInfo Centroid
            {
                get
                {
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelMoments_Centroid_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelMoments_Centroid_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelMoments_Centroid_Get(Instance);
                    #endif
                    return PointInfo.CreateInstance(result);
                }
            }
            public double EllipseAngle
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelMoments_EllipseAngle_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelMoments_EllipseAngle_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelMoments_EllipseAngle_Get(Instance);
                    #endif
                    return result;
                }
            }
            public PointInfo EllipseAxis
            {
                get
                {
                    IntPtr result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelMoments_EllipseAxis_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelMoments_EllipseAxis_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelMoments_EllipseAxis_Get(Instance);
                    #endif
                    return PointInfo.CreateInstance(result);
                }
            }
            public double EllipseEccentricity
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelMoments_EllipseEccentricity_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelMoments_EllipseEccentricity_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelMoments_EllipseEccentricity_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double EllipseIntensity
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.IsArm64)
                    #endif
                    #if PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.ARM64.ChannelMoments_EllipseIntensity_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.ChannelMoments_EllipseIntensity_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.ChannelMoments_EllipseIntensity_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double GetHuInvariants(int index)
            {
                double result;
                #if PLATFORM_AnyCPU
                if (OperatingSystem.IsArm64)
                #endif
                #if PLATFORM_arm64 || PLATFORM_AnyCPU
                result = NativeMethods.ARM64.ChannelMoments_GetHuInvariants(Instance, (UIntPtr)index);
                #endif
                #if PLATFORM_AnyCPU
                else if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_AnyCPU
                result = NativeMethods.X64.ChannelMoments_GetHuInvariants(Instance, (UIntPtr)index);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                result = NativeMethods.X86.ChannelMoments_GetHuInvariants(Instance, (UIntPtr)index);
                #endif
                return result;
            }
        }
    }
}
