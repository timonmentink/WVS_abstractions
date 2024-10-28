using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.SensorSettings
{
    public interface IBaseSettings
    {
        string Name { get; }
        double UpdateRate { get; }
        bool EnableMetrics { get; }
        bool Visualize { get; }
        string DataTopic { get; }
    }
}
