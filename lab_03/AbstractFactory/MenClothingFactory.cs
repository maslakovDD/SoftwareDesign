using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MenClothingFactory : IClothingFactory
    {
        public IHat CreateHat()
        {
            return new MenHat("Men Hat");
        }

        public IShirt CreateShirt()
        {
            return new MenShirt("Men Shirt");
        }

        public IShoes CreateShoes()
        {
            return new MenShoes("Men Shoes");
        }
    }
}
