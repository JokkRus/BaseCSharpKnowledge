using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public class Square : Shape
    {
        private int _size;
        public int Size => _size;
        Point[] points;
        public Square(Point point, int size) : base(point)
        {
            points = new Point[4];
            points[0] = point;
            points[1] = new Point(point.X + size, point.Y);
            points[2] = new Point(point.X, point.Y + size);
            points[3] = new Point(point.X + size, point.Y + size);
        }
        public override void Draw()
        {
            foreach(Point p in points)
            {
                p.Draw();
            }
        }
    }
}
