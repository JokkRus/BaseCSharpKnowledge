using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;

namespace BaseCSharpKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(25, 25, DrawInConsole.DrawPoint);
            point.Draw();
            Circle circle = new Circle(new Point(30, 10, DrawInConsole.DrawPoint), 10, DrawInConsole.DrawCircle);
            circle.Draw();
            Square square = new Square(new Point(30, 10, DrawInConsole.DrawPoint), 20, DrawInConsole.DrawSquare);
            square.Draw();
        }
    }
}
