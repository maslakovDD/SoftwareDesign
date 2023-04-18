using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class BigMacMenu
    {
        private BigMac _bigMac;
        private Drink _drink;
        private Fries _fries;
        private Package _package;
        public int Price { get; set; }

        public BigMacMenu(string drinkName, string friesSize)
        {
            _bigMac = new BigMac();
            _drink = new Drink(drinkName);
            _fries = new Fries(friesSize);
            _package = new Package(_bigMac, _drink, _fries);
        }

        public string GetBigMacMenu(bool addNapkins)
        {
            StringBuilder str = new();
            _package.GetPackageMenu();
            if (addNapkins)
                str.AppendLine(_package.AddNapkins());
            str.AppendLine(_bigMac.Cook());
            str.AppendLine(_fries.Cook());
            str.AppendLine(_drink.GetDrink());
            Price = _bigMac.Price + _drink.Price + _fries.Price + _package.Price;
            str.AppendLine($"Summary price: {Price}");
            return str.ToString();
        }
    }
}
