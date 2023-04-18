using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Shape
    {
        private IShapeRender _render;

        public Shape(IShapeRender render)
        {
            _render = render;
        }   

        public virtual string ShowPixels()
        {
            return _render.RenderPixels();
        }
        public virtual string ShowVector()
        {
            return _render.RenderVector();
        }
    }
}
