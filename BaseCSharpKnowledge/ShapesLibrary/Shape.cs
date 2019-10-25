using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public abstract class Shape : IDrawable
    {
        public abstract event DrawHandler OnDraw;
        protected Point _startPoint;
        public Point StartPoint => _startPoint;
        public Shape() { }
        public Shape(Point point)
        {
            _startPoint = point;
        }
        public abstract void Draw();
    }
}
