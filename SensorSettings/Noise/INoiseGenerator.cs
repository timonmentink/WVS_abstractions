using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WVS.Abstractions.SensorSettings.Noise
{
    public interface INoiseGenerator
    {
        void Apply(ref float data);
    }
}
