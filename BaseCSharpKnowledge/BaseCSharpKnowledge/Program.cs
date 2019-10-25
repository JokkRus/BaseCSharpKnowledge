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
            Point point = new Point(100, 100, DrawInConsole.DrawPoint);
            point.Draw();
            Circle circle = new Circle(new Point(10, 10, DrawInConsole.DrawPoint), 2, DrawInConsole.DrawCircle);
            circle.Draw();
            Square square = new Square(new Point(20, 20, DrawInConsole.DrawPoint), 50, DrawInConsole.DrawSquare);
            square.Draw();
        }
    }
}
