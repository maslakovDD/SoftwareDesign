using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WomenHat : IHat
    {
        public string Name { get; set; }
        public WomenHat(string name)
        {
            Name = name;
        }  
    }
}
