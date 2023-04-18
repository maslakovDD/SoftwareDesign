using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Package
    {
        private BigMac _bigMac;
        private Drink _drink;
        private Fries _fries;
        public int Price { get; private set; } = 0;

        public Package(BigMac bigMac, Drink drink, Fries fries)
        {
            _bigMac = bigMac;
            _drink = drink;
            _fries = fries;
        }

        public void GetPackageMenu()
        {
            _bigMac.Name += " Packaged";
            _drink.Name += " Packaged";
            _fries.Name += " Packaged";
            Price += 10;
        }

        public string AddNapkins()
        {
            Price += 5;
            return "There are napkins";
        }
    }
}
