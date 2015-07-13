using System;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;

namespace MandelBrot
{
    public class MandelbrotSet
    {
        public int MaxIteration { get; set; } = 255;
        public int Height { get; set; } = 512;
        public int Width { get; set; } = 512;

        public double MinReal { get; set; } = -2.0;
        public double MaxReal { get; set; } = 1.0;
        public double MinImaginary { get; set; } = -1.5;
        public double MaxImaginary { get; set; } = 1.5;

        public bool WithStartingValue { get; set; } = false;


        public Func<int, int> Red { get; set; } = n => n;
        public Func<int, int> Green { get; set; } = n => n;
        public Func<int, int> Blue { get; set; } = n => n;

        public Complex StartValue { get; set; } = new Complex(-0.745, 0.2);
        public Func<Complex, Complex> ComplexMap { get; set; } = z => z * z;

        public Bitmap Image { get; set; }


        public event EventHandler OnDraw;
        

        public MandelbrotSet(int width, int height)
        {
            Width = width;
            Height = height;
            Image = new Bitmap(Width, Height);
        }

        public MandelbrotSet()
        {
            Image = new Bitmap(Width, Height);
        }

        public Complex ScaleFromBitmapToComplexPlane(int x, int y)
        {
            var realRange = MaxReal - MinReal;
            var imageinaryRange = MaxImaginary - MinImaginary;
            var re = x * (realRange / Width) + MinReal;
            var im = y * (imageinaryRange / Height) + MinImaginary;
            return new Complex(re, im);
        }

        int IterationsToInfinity(Complex c)
        {
            // Testing whether iteration of Z = Z*Z + C for some complex number Z and fixed complex number C 
            // diverges or it stays bound for n iterations < MaxIteration
            var z = c;
            var count = 0;
            while(z.Magnitude <= 2.0 && count < MaxIteration)
            {
                if (WithStartingValue)
                    z = ComplexMap(z) + StartValue; // c is a different starting value -> creates julia sets
                else
                    z = ComplexMap(z) + c; // c is standard -> creates the usual mandelbrot set!
                count++;
            }
            // return how many iterates
            return count;
        }

        public void Draw()
        {
            Image = new Bitmap(Width, Height);
            // fast bitmap manipulation
            var bmp = new LockBitmap(Image);
            bmp.LockBits();
            Parallel.For(0, Height, y =>
              {
                  Parallel.For(0, Width, x => 
                  {
                      // scale from bitmap box to the complex plane 
                      var z = ScaleFromBitmapToComplexPlane(x, y);
                      // find how many iterations n 
                      int n = IterationsToInfinity(z);

                      // transform n to get different coloring
                      var red = Red(n);
                      var green = Green(n);
                      var blue = Blue(n);

                      // normalize the red, green and blue values to be in [0,255]
                      if (red > 255) red = 255;
                      else if (red < 0) red = 0;

                      if (green > 255) green = 255;
                      else if (green < 0) green = 0;
                
                      if (blue > 255) blue = 255;
                      else if (blue < 0) blue = 0;

                      // draw point
                      bmp.SetPixel(x,y, Color.FromArgb(red, green, blue));
                  });
              });
            bmp.UnlockBits();
            // if not null (i.e. subscribers exist) -> invoke
            OnDraw?.Invoke(this, new EventArgs());
        }


    }
}
