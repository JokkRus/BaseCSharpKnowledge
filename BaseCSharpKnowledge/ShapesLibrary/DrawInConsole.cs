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
            if (sender is Point point)
            {
                Console.SetCursorPosition(((Point)sender).X, ((Point)sender).Y);
                Console.Write(".");
                EndDraw();
            }
            else
            {
                throw new Exception("It's not for a point.");
            }
        }
        public static void DrawSquare(object sender, DrawEventArgs args)
        {
            if (sender is Square square)
            {
                Console.WriteLine(args.Message);
                EndDraw();
            }
            else
            {
                throw new Exception("It's not for a square.");
            }
        }
        public static void DrawCircle(object sender, DrawEventArgs args)
        {
            Console.WriteLine(args.Message);
            EndDraw();
            if(sender is Circle circle)
            {
                DrawPoint(circle.StartPoint, args);
                DrawPoint(circle.StartPoint + new Vector2(0, -circle.Radius), args);
                DrawPoint(circle.StartPoint + new Vector2(circle.Radius*2, 0), args);
                DrawPoint(circle.StartPoint + new Vector2(0, circle.Radius), args);
                DrawPoint(circle.StartPoint + new Vector2(-circle.Radius*2, 0), args);
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
