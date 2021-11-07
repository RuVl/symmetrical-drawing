using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;

namespace SymmetricalDrawing
{
    internal class Logic
    {
    #region MainFields

        private PictureBox _pictureBox;
        private Bitmap _bitmap;
        private Point _centerOfBitmap;
        private int _axes; // count of axes
        private Complex _rotationConstant; // To rotate by using complex numbers cos(a) + i * sin(a) (a = 2pi/n)

    #endregion
        
        private bool _isMouseDown;
        private Complex _previousMousePosition;

    #region Properties

        public PictureBox PictureBox
        {
            get => _pictureBox;
            private set
            {
                _pictureBox = value;
                Bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
                
                // Add events
                _pictureBox.MouseDown += PictureBoxOnMouseDown;
                _pictureBox.MouseMove += PictureBoxOnMouseMove;
                _pictureBox.MouseUp += PictureBoxOnMouseUp;
                
                _pictureBox.SizeChanged += PictureBoxOnSizeChanged;
            }
        }
        public Bitmap Bitmap
        {
            get => _bitmap;
            set
            {
                _bitmap = value;
                // _bitmap.Clear(BackgroundColor);
                _pictureBox.Image = _bitmap;
                _centerOfBitmap = new Point(_bitmap.Width/2, _bitmap.Height/2);
            }
        }
        public int Axes
        {
            get => _axes;
            set
            {
                _axes = value;
                
                // Update rotation constant
                double a = Math.PI * 2 / Axes;
                _rotationConstant = new Complex(Math.Cos(a), Math.Sin(a));
            }
        }
        public Pen Pen { get; set; }
        public Color BackgroundColor { get; set; }

    #endregion
        
        public Logic(PictureBox pictureBox, int axes, Pen pen, Color backgroundColor)
        {
            PictureBox = pictureBox;
            Axes = axes;
            Pen = pen;
            BackgroundColor = backgroundColor;
            
            Clear();
        }

        public Logic(PictureBox pictureBox, int axes) : this(pictureBox, axes, Pens.Black, Color.White) {}

        private void PictureBoxOnMouseDown(object sender, MouseEventArgs e)
        {
            _isMouseDown = true;
            _previousMousePosition = Subtract(e.Location, _centerOfBitmap).ToComplex();
        }

        private void PictureBoxOnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown) return;

            var currentComplex = Subtract(e.Location, _centerOfBitmap).ToComplex();
            
            using(Graphics graphics = Graphics.FromImage(_bitmap))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                // point * rotationConstant^i
                for (int i = 0; i < _axes; i++)
                {
                    Point currentPosition = Sum(_centerOfBitmap, (currentComplex * Complex.Pow(_rotationConstant, i)).ToPoint());
                    Point lastPosition = Sum(_centerOfBitmap, (_previousMousePosition * Complex.Pow(_rotationConstant, i)).ToPoint());
                    
                    graphics.DrawLine(Pen, lastPosition, currentPosition);
                }
            }

            _previousMousePosition = currentComplex;
            _pictureBox.Image = _bitmap;
        }

        private void PictureBoxOnMouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
            _previousMousePosition = Complex.Zero;
        }

        /// <summary>
        /// Вычесть из p1 соотвествующие координаты p2
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        private Point Subtract(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

        /// <summary>
        /// Сложить соответствующие координаты p1 и p2
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        private Point Sum(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);

        private void PictureBoxOnSizeChanged(object sender, EventArgs e)
        {
            if (_pictureBox.Width == 0 || _pictureBox.Height == 0) return;
            
            Bitmap = _bitmap.Resize(_pictureBox.Width, _pictureBox.Height);
        }

        public void Clear()
        {
            _bitmap.Clear(BackgroundColor);
            _pictureBox.Image = _bitmap;
        }
    }
}