using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class CircleRender : IShapeRender
    {
        public string RenderPixels()
        {
            return "Drawing Circle as pixels";
        }

        public string RenderVector()
        {
            return "Drawing Circle as vector";

        }
    }
}
