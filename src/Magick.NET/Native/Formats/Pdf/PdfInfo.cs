// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick.Formats;

public partial class PdfInfo
{
    [SuppressUnmanagedCodeSecurity]
    private static unsafe class NativeMethods
    {
        #if PLATFORM_x64 || PLATFORM_AnyCPU
        public static class X64
        {
            [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr PdfInfo_PageCount(IntPtr fileName, IntPtr password, out IntPtr exception);
        }
        #endif
        #if PLATFORM_arm64 || PLATFORM_AnyCPU
        public static class ARM64
        {
            [DllImport(NativeLibrary.ARM64Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr PdfInfo_PageCount(IntPtr fileName, IntPtr password, out IntPtr exception);
        }
        #endif
        #if PLATFORM_x86 || PLATFORM_AnyCPU
        public static class X86
        {
            [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
            public static extern UIntPtr PdfInfo_PageCount(IntPtr fileName, IntPtr password, out IntPtr exception);
        }
        #endif
    }
    private unsafe sealed partial class NativePdfInfo : NativeHelper
    {
        static NativePdfInfo() { Environment.Initialize(); }
        public int PageCount(string fileName, string password)
        {
            using var fileNameNative = UTF8Marshaler.CreateInstance(fileName);
            using var passwordNative = UTF8Marshaler.CreateInstance(password);
            IntPtr exception = IntPtr.Zero;
            UIntPtr result;
            #if PLATFORM_AnyCPU
            if (Runtime.IsArm64)
            #endif
            #if PLATFORM_arm64 || PLATFORM_AnyCPU
            result = NativeMethods.ARM64.PdfInfo_PageCount(fileNameNative.Instance, passwordNative.Instance, out exception);
            #endif
            #if PLATFORM_AnyCPU
            else if (Runtime.Is64Bit)
            #endif
            #if PLATFORM_x64 || PLATFORM_AnyCPU
            result = NativeMethods.X64.PdfInfo_PageCount(fileNameNative.Instance, passwordNative.Instance, out exception);
            #endif
            #if PLATFORM_AnyCPU
            else
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            result = NativeMethods.X86.PdfInfo_PageCount(fileNameNative.Instance, passwordNative.Instance, out exception);
            #endif
            CheckException(exception);
            return (int)result;
        }
    }
}
