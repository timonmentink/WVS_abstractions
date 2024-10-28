using System;
using System.Collections.Generic;
using System.Text;
using WVS.Abstractions.SensorSettings.Noise;

namespace WVS.Abstractions.SensorSettings
{
    public interface IGpsSettings : IBaseSettings
    {
        INoise<double> HorizontalPositionNoise { get; }
        NoiseType HorizontalPositionNoiseType { get; }
        INoise<double> VerticalPositionNoise { get; }
        NoiseType VerticalPositionNoiseType { get; }
        INoise<double> HorizontalVelocityNoise { get; }
        NoiseType HorizontalVelocityNoiseType { get; }
        INoise<double> VerticalVelocityNoise { get; }
        NoiseType VerticalVelocityNoiseType { get; }
    }
}
