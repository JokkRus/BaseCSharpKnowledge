using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShapesLibrary
{
    public class Square : Shape, ICloneable, IComparable, IEnumerable
    {
        private int _size;
        public int Size => _size;
        Point[] points;

        public override event DrawHandler OnDraw;

        public Square(Point point, int size, DrawHandler drawSquare) : base(point)
        {
            _size = size;
            points = new Point[4];
            points[0] = point;
            points[1] = point + new Vector2(size*2, 0);
            points[2] = point + new Vector2(0, size);
            points[3] = point + new Vector2(size*2, size);
            OnDraw += drawSquare;
        }
        public override void Draw()
        {
            OnDraw?.Invoke(this, new DrawEventArgs($"It's square"));
            foreach(Point p in points)
            {
                p.Draw();
            }
        }

        public object Clone()
        {
            Point point = _startPoint.Clone() as Point;
            return new Square(point, this.Size, OnDraw);
        }

        public int CompareTo(object obj)
        {
            if(obj is Square square)
            {
                if (this.Size > square.Size)
                    return 1;
                else if (this.Size < square.Size)
                    return -1;
                else
                    return 0;
            }
            else
            {
                throw new Exception($"Cannot format to square.");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return points.GetEnumerator();
        }
    }
}
