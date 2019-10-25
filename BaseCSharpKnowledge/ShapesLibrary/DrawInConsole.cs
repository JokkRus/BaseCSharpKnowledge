using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ShapesLibrary
{
    public static class DrawInConsole
    {
        public static void DrawPoint(object sender, DrawEventArgs args)
        {
            Console.SetCursorPosition(((Point)sender).X, ((Point)sender).Y);
            Console.Write(".");
            EndDraw();
        }
        public static void DrawSquare(object sender, DrawEventArgs args)
        {
            Console.WriteLine(args.Message);
            EndDraw();
        }
        public static void DrawCircle(object sender, DrawEventArgs args)
        {
            if(sender is Circle circle)
            {
                DrawPoint(circle.StartPoint + new Point(circle.Radius, 0), new DrawEventArgs($"Point of circle"));
                DrawPoint(circle.StartPoint + new Point(0, circle.Radius), new DrawEventArgs($"Point of circle"));
                DrawPoint(circle.StartPoint + new Point(-circle.Radius, 0), new DrawEventArgs($"Point of circle"));
                DrawPoint(circle.StartPoint + new Point(0, -circle.Radius), new DrawEventArgs($"Point of circle"));
            }
            else
            {
                throw new Exception("It's not for a circle.");
            }
        }
        private static void EndDraw()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
