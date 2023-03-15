using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WomenShoes : IShoes
    {
        public string Name { get; set; }
        public WomenShoes(string name) 
        {
            Name = name;
        }
    }
}
