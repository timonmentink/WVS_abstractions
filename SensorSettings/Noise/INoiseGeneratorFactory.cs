using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.SensorSettings.Noise
{
    public interface INoiseGeneratorFactory
    {
        INoiseGenerator NoiseGenerator(NoiseType type, INoise<double> parameters);
        INoiseGenerator NoiseGenerator(NoiseType type, INoise<double> parameters, Random rand);
    }
}
