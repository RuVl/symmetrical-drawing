using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Numerics;

namespace SymmetricalDrawing
{
    internal static class Extensions
    {
        public static Complex ToComplex(this Point point)
        {
            return new Complex(point.X, point.Y);
        }

        public static Point ToPoint(this Complex complex)
        {
            return new Point((int)complex.Real, (int)complex.Imaginary);
        }

        /// <summary>
        /// Warning! Clear all bitmap with color
        /// </summary>
        /// <param name="bitmap"></param>
        /// <param name="color"></param>
        public static void Clear(this Bitmap bitmap, Color color)
        {
            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                    bitmap.SetPixel(x, y, color);
        }

        public static Bitmap Resize(this Bitmap bitmap, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var tempBitmap = new Bitmap(width, height);

            tempBitmap.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);

            // Magic part of code
            using (var graphics = Graphics.FromImage(tempBitmap))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(bitmap, destRect, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return tempBitmap;
        }
    }
}