using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Characters
{
    internal class Mage : Character
    {
        public Mage() : base()
        {
            ArtefactsPower = "magic wand";
        }
    }
}
