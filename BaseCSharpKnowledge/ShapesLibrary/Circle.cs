using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public class Circle : Shape, ICloneable, IComparable
    {
        private int _radius;

        public override event DrawHandler OnDraw;

        public int Radius => _radius;
        public Circle(Point point, int radius, DrawHandler drawCircle) : base(point)
        {
            _radius = radius;
            OnDraw += drawCircle;
        }
        public object Clone()
        {
            return new Circle(_startPoint, this._radius, OnDraw);
        }

        public int CompareTo(object obj)
        {
            if (obj is Circle circle)
            {
                if (this._radius > circle.Radius)
                    return 1;
                else if (this._radius < circle.Radius)
                    return -1;
                else
                    return 0;
            }
            else
                throw new Exception($"Cannot format to circle.");
        }

        public override void Draw()
        {
            OnDraw?.Invoke(this, new DrawEventArgs($"It's Circle"));
        }
    }
}
