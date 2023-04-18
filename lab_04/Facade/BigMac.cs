using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class BigMac
    {
        public string Name { get; set; } = "BigMac";
        public int Price { get; } = 120;
        public string Cook()
        {
            return $"There is a {Name} burger";
        }

    }
}
