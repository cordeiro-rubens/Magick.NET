// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using ImageMagick.SourceGenerator;

namespace ImageMagick;

/// <content />
public partial class Moments
{
    [NativeInterop]
    private partial class NativeMoments
    {
        public static partial void DisposeList(IntPtr list);

        public static partial IntPtr GetInstance(IntPtr list, PixelChannel channel);
    }
}
