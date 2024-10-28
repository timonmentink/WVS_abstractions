using System;
using System.Collections.Generic;
using System.Text;
using WVS.Abstractions.PluginSettings;
using WVS.Abstractions.SensorSettings;

namespace WVS.Abstractions
{
    public interface IPlugin
    {
        public void OnUnloaded();
        public void OnLoaded(IServiceProvider serviceProvider, IPluginSettings settings, IBaseSettings? sensorSettings = null);
    }
}
