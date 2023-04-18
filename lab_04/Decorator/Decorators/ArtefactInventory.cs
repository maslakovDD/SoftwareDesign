using Decorator.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class ArtefactInventory : Inventory
    {
        public ArtefactInventory(Character character, string artefact) : base(character)
        {
            this.ArtefactsPower = artefact;
        }

        public override void ShowStats()
        {
            base.ShowStats();
        }
    }
}
