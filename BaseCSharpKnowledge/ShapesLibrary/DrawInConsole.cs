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
            Console.WriteLine("I'm starting draw the point..");
            Thread.Sleep(1000);
            Console.SetCursorPosition(((Point)sender).X, ((Point)sender).Y);
            Console.Write(".");
            EndDraw();
        }
        private static void EndDraw()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
