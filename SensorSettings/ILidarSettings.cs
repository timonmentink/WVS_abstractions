using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using WVS.Abstractions.SensorSettings.Noise;

namespace WVS.Abstractions.SensorSettings
{
    public interface ILidarSettings : IBaseSettings
    {
        public double HorizontalScanMinAngleDegree { get; }
        public double HorizontalScanMaxAngleDegree { get; }
        public double VerticalScanMinAngleDegree { get; }
        public double VerticalScanMaxAngleDegree { get; }

        public uint HorizontalScanSamples { get; }
        public uint VerticalScanSamples { get; }

        public double RangeMax { get; }
        public double RangeMin { get; }
    }
}
