using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.SensorSettings.Datatypes
{
    public interface IPose<T>
    {
        public T X { get; }
        public T Y { get; }
        public T Z { get; }
        public T QX { get; }
        public T QY { get; }
        public T QZ { get; }
        public T QW { get; }
        public T Roll { get; }
        public T Pitch { get; }
        public T Yaw { get; }
        public string RelativeTo { get; }
    }

}
