using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class TriangleRender : IShapeRender
    {
        public string RenderPixels()
        {
            return "Drawing Triangle as pixels";
        }

        public string RenderVector()
        {
            return "Drawing Triangle as vector";
        }
    }
}
