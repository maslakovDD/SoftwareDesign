using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Triangle :Shape
    {
        public Triangle(IShapeRender shapeRender) : base(shapeRender)
        {

        }
    }
}
