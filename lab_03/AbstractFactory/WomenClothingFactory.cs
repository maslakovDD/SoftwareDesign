using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WomenClothingFactory : IClothingFactory
    {
        public IHat CreateHat()
        {
            return new WomenHat("Women Hat");
        }

        public IShirt CreateShirt()
        {
            return new WomenShirt("Women Shirt");
        }

        public IShoes CreateShoes()
        {
            return new WomenShoes("Women Shoes");
        }
    }
}
