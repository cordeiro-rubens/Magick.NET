﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System.Collections.Generic;

namespace ImageMagick.Formats;

/// <summary>
/// Class for defines that are used when a <see cref="MagickFormat.Png"/> image is written.
/// </summary>
public sealed class PngWriteDefines : IWriteDefines
{
    /// <summary>
    /// Gets or sets the bit depth for the PNG image.
    /// Valid values: 1, 2, 4, 8, 16.
    /// </summary>
    public uint? BitDepth { get; set; }

    /// <summary>
    /// Gets or sets the color type of the image.
    /// </summary>
    public ColorType? ColorType { get; set; }

    /// <summary>
    /// Gets or sets the compression filter for the PNG image.
    /// For compression level 0 (quality value less than 10), the Huffman-only strategy is used, which is fastest but not necessarily the worst compression.
    /// </summary>
    public PngCompressionFilter? CompressionFilter { get; set; }

    /// <summary>
    /// Gets or sets the compression level for the PNG image.
    /// The compression level ranges from 0 to 9, where 0 indicates no compression and 9 indicates maximum compression.
    /// For compression level 0 (quality value less than 10), the Huffman-only strategy is used, which is the fastest but not necessarily the worst compression.
    /// </summary>
    public uint? CompressionLevel { get; set; }

    /// <summary>
    /// Gets or sets the compression strategy for the PNG image.
    /// </summary>
    public PngCompressionStrategy? CompressionStrategy { get; set; }

    /// <summary>
    /// Gets or sets the chunks to be excluded.
    /// </summary>
    public PngChunkFlags? ExcludeChunks { get; set; }

    /// <summary>
    /// Gets the format where the defines are for.
    /// </summary>
    public MagickFormat Format
        => MagickFormat.Png;

    /// <summary>
    /// Gets the defines that should be set as a define on an image.
    /// </summary>
    public IEnumerable<IDefine> Defines
    {
        get
        {
            if (BitDepth.HasValue)
                yield return new MagickDefine(Format, "bit-depth", BitDepth.Value);

            if (ColorType.HasValue)
                yield return new MagickDefine(Format, "color-type", ColorType.Value);

            if (CompressionLevel.HasValue)
                yield return new MagickDefine(Format, "compression-level", CompressionLevel.Value);

            if (CompressionFilter.HasValue)
                yield return new MagickDefine(Format, "compression-filter", CompressionFilter.Value);

            if (CompressionStrategy.HasValue)
                yield return new MagickDefine(Format, "compression-strategy", CompressionStrategy.Value);

            if (ExcludeChunks.HasValue)
                yield return new MagickDefine(Format, "exclude-chunks", EnumHelper.ConvertFlags(ExcludeChunks.Value));
        }
    }
}
