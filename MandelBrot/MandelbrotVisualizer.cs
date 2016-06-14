using System;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mandelbrot
{
    public partial class MandelbrotVisualizer : Form
    {
        MandelbrotSet mandelbrotSet;
        Stack<Window> fractalWindows = new Stack<Window>();

        public MandelbrotVisualizer()
        {
            InitializeComponent();
            mandelbrotSet = new MandelbrotSet(512, 512);
            mandelbrotSet.DrawStrategy = DrawStrategy.Sequential;
            mandelbrotSet.OnDrawFinished += (sender, args) =>
            {
                lblTime.Text = $"Took {args.Elapsed.Milliseconds / 1000.0} s";
                lblStrategy.Text = $"Strategy: {args.StrategyUsed}";
                mandelPictureBox.Image = args.Result;
                txtHeight.Text = mandelbrotSet.Height.ToString();
                txtWidth.Text = mandelbrotSet.Width.ToString();
                txtMinReal.Text = mandelbrotSet.Window.MinReal.ToString();
                txtMaxReal.Text = mandelbrotSet.Window.MaxReal.ToString();
                txtMinImaginary.Text = mandelbrotSet.Window.MinImaginary.ToString();
                txtMaxImaginary.Text = mandelbrotSet.Window.MaxImaginary.ToString();
                txtReal.Text = mandelbrotSet.StartValue.Real.ToString();
                txtImaginary.Text = mandelbrotSet.StartValue.Imaginary.ToString();
                withParameter.Checked = mandelbrotSet.WithStartingValue;
            };


            btnDraw.Click += (sender, obj) => Redraw();
            btnSave.Click += (sender, obj) =>
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "Bitmap Files (*.png)|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                    mandelPictureBox.Image.Save(sfd.FileName);
            };

            btnReset.Click += (sender, obj) =>
            {
                // reset to default values
                mandelbrotSet.Height = 512;
                mandelbrotSet.Width = 512;
                mandelbrotSet.Window.MinImaginary = -1.5;
                mandelbrotSet.Window.MaxImaginary = 1.5;
                mandelbrotSet.Window.MinReal = -2.0;
                mandelbrotSet.Window.MaxReal = 1.0;
                mandelbrotSet.WithStartingValue = false;
                mandelbrotSet.Draw();
            };

            btnBack.Click += (sender, obj) =>
            {
                if (fractalWindows.Count > 0)
                {
                    mandelbrotSet.Window = fractalWindows.Pop();
                    mandelbrotSet.Draw();
                }

            };

            mandelPictureBox.MouseClick += (sender, e) =>
            {
                fractalWindows.Push(mandelbrotSet.Window);
                var zoomBoxSize = 50;

                var p = ScaleToBitmap(e.Location);
                var c1 = mandelbrotSet.ScaleFromBitmapToComplexPlane(p.X - zoomBoxSize, p.Y - zoomBoxSize);
                var c2 = mandelbrotSet.ScaleFromBitmapToComplexPlane(p.X + zoomBoxSize, p.Y + zoomBoxSize);

                mandelbrotSet.Window.MinReal = c1.Real;
                mandelbrotSet.Window.MaxReal = c2.Real;

                mandelbrotSet.Window.MinImaginary = c1.Imaginary;
                mandelbrotSet.Window.MaxImaginary = c2.Imaginary;

                Redraw();
            };

            // maps: z^7 - z
            // z*z-z
            mandelbrotSet.ComplexMap = z => z * z;
            mandelbrotSet.WithStartingValue = false;
            mandelbrotSet.StartValue = new Complex(-0.735, 0.175);
            mandelbrotSet.Draw();
        }

        Point ScaleToBitmap(Point input)
        {
            var x = mandelbrotSet.Width * ((double)input.X / mandelPictureBox.Width);
            var y = mandelbrotSet.Height * ((double)input.Y / mandelPictureBox.Height); ;
            return new Point((int)x,(int)y);
        }

        void Redraw()
        {
            try
            {
                mandelbrotSet.Height = int.Parse(txtHeight.Text);
                mandelbrotSet.Width = int.Parse(txtWidth.Text);
                mandelbrotSet.WithStartingValue = withParameter.Checked;
                mandelbrotSet.StartValue = new Complex(double.Parse(txtReal.Text), double.Parse(txtImaginary.Text));
                mandelbrotSet.Draw();
            }
            catch
            {
                MessageBox.Show("Invalid parameter input", "Input error");
            }
        }

        private void realSlider_MouseUp(object sender, EventArgs e)
        {
            txtReal.Text = ((double)realSlider.Value / 1000).ToString();
            Redraw();
        }

        private void imSlider_MouseUp(object sender, EventArgs e)
        {
            txtImaginary.Text = ((double)imSlider.Value / 1000).ToString();
            Redraw();
        }

        private void chboxSequential_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxSequential.Checked)
                mandelbrotSet.DrawStrategy = DrawStrategy.Sequential;
            else
                mandelbrotSet.DrawStrategy = DrawStrategy.Parallel;
        }
    }
}
