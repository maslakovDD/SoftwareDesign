using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MenShirt : IShirt
    {
        public string Name { get; set; }
        public MenShirt(string name)
        {
            Name = name;
        }
    }
}
