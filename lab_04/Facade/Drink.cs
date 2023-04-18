using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Drink
    {
        public string Name { get; set; } = "CocaCola";
        public int Price { get; } = 25;
        public Drink(string name)
        {
            Name = name;
        }
        public string GetDrink()
        {
            return $"There is a {Name} drink";
        }
    }
}
