using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MenHat : IHat
    {
        public string Name { get; set; }
        public MenHat(string name)
        {
            Name = name;
        }
    }
}
