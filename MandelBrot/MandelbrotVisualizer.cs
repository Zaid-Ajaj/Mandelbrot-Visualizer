using System;
using System.Windows.Forms;
using System.Numerics;
using System.Drawing;

namespace MandelBrot
{
    public partial class MandelbrotVisualizer : Form
    {
        MandelbrotSet mandelbrotSet;

        public MandelbrotVisualizer()
        {
            InitializeComponent();
            mandelbrotSet = new MandelbrotSet(512, 512);
            mandelbrotSet.OnDraw += (sender, args) =>
            {
                mandelPictureBox.Image = mandelbrotSet.Image;
                txtHeight.Text = mandelbrotSet.Height.ToString();
                txtWidth.Text = mandelbrotSet.Width.ToString();
                txtMinReal.Text = mandelbrotSet.MinReal.ToString();
                txtMaxReal.Text = mandelbrotSet.MaxReal.ToString();
                txtMinImaginary.Text = mandelbrotSet.MinImaginary.ToString();
                txtMaxImaginary.Text = mandelbrotSet.MaxImaginary.ToString();
                txtReal.Text = mandelbrotSet.StartValue.Real.ToString();
                txtImaginary.Text = mandelbrotSet.StartValue.Imaginary.ToString();
                withParameter.Checked = mandelbrotSet.WithStartingValue;
            };
            mandelbrotSet.ComplexMap = z => z * z;
            mandelbrotSet.WithStartingValue = false;
            mandelbrotSet.StartValue = new Complex(-0.735, 0.175);
            mandelbrotSet.Draw();
        }

        void Redraw()
        {
            try
            {
                mandelbrotSet.Height = int.Parse(txtHeight.Text);
                mandelbrotSet.Width = int.Parse(txtWidth.Text);
                mandelbrotSet.MinReal = double.Parse(txtMinReal.Text);
                mandelbrotSet.MaxReal = double.Parse(txtMaxReal.Text);
                mandelbrotSet.MinImaginary = double.Parse(txtMinImaginary.Text);
                mandelbrotSet.MaxImaginary = double.Parse(txtMaxImaginary.Text);
                mandelbrotSet.WithStartingValue = withParameter.Checked;
                mandelbrotSet.StartValue = new Complex(double.Parse(txtReal.Text), double.Parse(txtImaginary.Text));
                mandelbrotSet.Draw();
            }
            catch { MessageBox.Show("Invalid parameter input", "Input error"); }
        }
        

        private void btnRedraw_Click (object sender, EventArgs e) => Redraw();

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap Files (*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
                mandelPictureBox.Image.Save(sfd.FileName);
        }

        Point ScaleToBitmap(Point input)
        {
            var x = mandelbrotSet.Width * ((double)input.X / mandelPictureBox.Width);
            var y = mandelbrotSet.Height * ((double)input.Y / mandelPictureBox.Height); ;
            return new Point((int)x,(int)y);
        }
        private void mandelPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int zoomBoxSize;
            try
            {
                zoomBoxSize = int.Parse(txtZoomBoxSize.Text);
            }
            catch
            {
                zoomBoxSize = 50;
            }
            
            var p = ScaleToBitmap(e.Location);
            var c1 = mandelbrotSet.ScaleFromBitmapToComplexPlane(p.X - zoomBoxSize, p.Y - zoomBoxSize);
            var c2 = mandelbrotSet.ScaleFromBitmapToComplexPlane(p.X + zoomBoxSize, p.Y + zoomBoxSize);

            mandelbrotSet.MinReal = c1.Real;
            mandelbrotSet.MaxReal = c2.Real;

            mandelbrotSet.MinImaginary = c1.Imaginary;
            mandelbrotSet.MaxImaginary = c2.Imaginary;

            mandelbrotSet.Draw();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mandelbrotSet.Height = 512;
            mandelbrotSet.Width = 512;
            mandelbrotSet.MinImaginary = -1.5;
            mandelbrotSet.MaxImaginary = 1.5;
            mandelbrotSet.MinReal = -2.0;
            mandelbrotSet.MaxReal = 1.0;
            mandelbrotSet.WithStartingValue = false;
            mandelbrotSet.Draw();
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
    }
}
