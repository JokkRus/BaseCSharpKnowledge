using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public struct Vector2 : IPoint
    {
        private int _x;
        private int _y;
        public int X => _x;

        public int Y => _y;
        public Vector2(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
