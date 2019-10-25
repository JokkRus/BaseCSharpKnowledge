using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public delegate void DrawHandler(object sender, DrawEventArgs args);
    public interface IDrawable
    {
        event DrawHandler OnDraw;
        void Draw();
    }
    public class DrawEventArgs : EventArgs
    {
        public string Message { get; set; }
        public DrawEventArgs(string message)
        {
            Message = message;
        }
    }
}
