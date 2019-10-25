﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public class Point : IPoint, IDrawable
    {
        private int _x;
        private int _y;
        public int X => _x;
        public int Y => _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
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
            throw new NotImplementedException();
        }
    }
}