using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.SensorSettings.Datatypes
{
    public interface IVector2<T>
    {
        T X { get; }
        T Y { get; }
    }
}
