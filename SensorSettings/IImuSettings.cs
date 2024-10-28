using System;
using System.Collections.Generic;
using System.Text;
using WVS.Abstractions.SensorSettings.Noise;

namespace WVS.Abstractions.SensorSettings
{
    public interface IImuSettings : IBaseSettings
    {
        public NoiseType AngularVelocityXNoiseType { get; }
        public NoiseType AngularVelocityYNoiseType { get; }
        public NoiseType AngularVelocityZNoiseType { get; }

        public INoise<double> AngularVelocityXNoise { get; }
        public INoise<double> AngularVelocityYNoise { get; }
        public INoise<double> AngularVelocityZNoise { get; }

        public NoiseType LinearAccelerationXNoiseType { get; }
        public NoiseType LinearAccelerationYNoiseType { get; }
        public NoiseType LinearAccelerationZNoiseType { get; }

        public INoise<double> LinearAccelerationXNoise { get; }
        public INoise<double> LinearAccelerationYNoise { get; }
        public INoise<double> LinearAccelerationZNoise { get; }
    }
}
