using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SquareRender : IShapeRender
    {
        public string RenderPixels()
        {
            return "Drawing Square as pixels";
        }

        public string RenderVector()
        {
            return "Drawing Square as vector";

        }
    }
}
