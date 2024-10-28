using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.SensorSettings.Datatypes
{
    public enum PixelFormatType
    {
            UNKNOWN_PIXEL_FORMAT,
            L_INT8,
            L_INT16,
            RGB_INT8,
            RGBA_INT8,
            BGRA_INT8,
            RGB_INT16,
            RGB_INT32,
            BGR_INT8,
            BGR_INT16,
            BGR_INT32,
            R_FLOAT16,
            RGB_FLOAT16,
            R_FLOAT32,
            RGB_FLOAT32,
            BAYER_RGGB8,
            BAYER_BGGR8,
            BAYER_GBRG8,
            BAYER_GRBG8
    }
}
