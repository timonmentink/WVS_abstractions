using System;
using System.Collections.Generic;
using System.Text;

namespace WVS.Abstractions.Damage
{
    public interface IDamageable
    {
        void OnHit(DamageData damageData);
    }
}
