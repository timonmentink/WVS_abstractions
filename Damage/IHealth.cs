using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.Damage
{
    public interface IHealth
    {
        float GetHealth();
        
        bool IsDestructed();
    }
}
