using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MenShoes : IShoes
    {
        public string Name { get; set; }
        public MenShoes(string name)
        {
            Name = name;
        }
    }
}
