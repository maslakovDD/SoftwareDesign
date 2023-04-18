using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Circle : Shape
    {
        public Circle(IShapeRender shapeRender) : base(shapeRender)
        {

        }
    }
}
