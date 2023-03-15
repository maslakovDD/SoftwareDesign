using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WomenShirt : IShirt
    {
        public string Name { get; set; }
        public WomenShirt(string name)
        {
            Name = name;
        }
    }
}
