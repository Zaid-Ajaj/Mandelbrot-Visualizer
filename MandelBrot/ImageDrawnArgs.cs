using System;
using System.Drawing;

namespace Mandelbrot
{
    public class ImageDrawnArgs : EventArgs
    {
        public TimeSpan Elapsed { get; set; }
        public Bitmap Result { get; set; }
        public DrawStrategy StrategyUsed { get; set; }
    }
}
