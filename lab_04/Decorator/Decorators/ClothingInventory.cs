using Decorator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class ClothingInventory : Inventory
    {
        public ClothingInventory(Character character, string clothes) : base(character) 
        {
            this.Armor = clothes;
        }

        public override void ShowStats()
        {
            base.ShowStats();
        }
    }
}
