using Decorator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    abstract class Inventory : Character
    {
        public Inventory(Character character) : base(character)
        {
        }

        public override void ShowStats()
        {
            base.ShowStats();
        }
    }
}
