using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ShapesLibrary
{
    public class Point : IPoint, IDrawable, ICloneable, IComparable
    {
        private int _x;
        private int _y;
        public int X => _x;
        public int Y => _y;
        public event DrawHandler OnDraw;

        public Point(int x, int y, DrawHandler drawPoint)
        {
            _x = x;
            _y = y;
            OnDraw += drawPoint;
        }
        public override string ToString()
        {
            return $"Point exists in next coordinates ({_x},{_y})";
        }
        public override bool Equals(object obj)
        {
            Point point = obj as Point;
            if (point != null && this._x == point.X && this._y == point.Y)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public void Draw()
        {
            if (_x >= 0 && _y >= 0)
                OnDraw?.Invoke(this, new DrawEventArgs($"({_x},{_y})"));
            else
                throw new PointException("I can't draw in negative...");    
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (obj is Point another)
            {
                if (this.X + this.Y > another.X + another.Y)
                    return 1;
                else if (this.X + this.Y < another.X + another.Y)
                    return -1;
                else
                    return 0;
            }
            else
                throw new Exception($"Cannot format to point");
        }

        public static Point operator + (Point p1, Vector2 vector)
        {
            return new Point(p1.X + vector.X, p1.Y + vector.Y, p1.OnDraw);
        }

        private class PointException : Exception
        {
            public PointException(string message) : base(message)
            {

            }
        }
    }
    
}
