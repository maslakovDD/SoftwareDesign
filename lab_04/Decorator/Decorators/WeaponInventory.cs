using Decorator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class WeaponInventory : Inventory
    {
        public WeaponInventory(Character character, int weaponDamage) : base(character)
        {
            this.Damage += weaponDamage;
        }

        public override void ShowStats()
        {
            base.ShowStats();
        }
    }
}
