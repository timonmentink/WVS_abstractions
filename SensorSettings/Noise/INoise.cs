using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.SensorSettings.Noise
{
    public interface INoise<T>
    {
        T Mean { get; }
        T StdDev { get; }
        T BiasMean { get; }
        T BiasStdDev { get; }
        T DynamicBiasStdDev { get; }
        T DynamicBiasCorrelationTime { get; }
        T Precision { get; }
    }
}
