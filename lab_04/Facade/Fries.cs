using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Fries
    {
        public string Name { get; set; } = "Fries";
        public string Size { get; set; } = "Middle";
        public int Price { get; set; } = 45;
        public Fries(string size)
        {
            Size = size;
            switch (Size)
            {
                case "Small":
                    Price = 30;
                    break;
                case "Middle":
                    Price = 45;
                    break;
                case "Large":
                    Price = 60;
                    break;
                default:
                    Price = 45;
                    Size = "Middle";
                    break;
            }
            Name += $" {Size}";
        }
        public string Cook()
        {
            return $"There are cooked {Name}";
        }

    }
}
