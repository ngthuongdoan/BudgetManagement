using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BudgetManagement
{
    public class WalletImage
    {
        private const int MarginWidth = 4;
        private const int MarginHeight = 4;

        public Image Picture;

        public WalletImage(Image p)
        {
            this.Picture = p;
        }
        private int Width = 4, Height = 4;
        private bool SizeCalculated = false;
        public void MeasureItem(MeasureItemEventArgs e)
        {
            // See if we've already calculated this.
            if (!SizeCalculated)
            {
                SizeCalculated = true;
            }

            e.ItemWidth = Width;
            e.ItemHeight = Height;
        }
        public void DrawItem(DrawItemEventArgs e)
        {
            // Clear the background appropriately.
            e.DrawBackground();

            // Draw the image.
            float hgt = e.Bounds.Height - 2 * MarginHeight;
            float scale = hgt / Picture.Height;
            float wid = Picture.Width * scale;
            RectangleF rect = new RectangleF(
                e.Bounds.X + MarginWidth,
                e.Bounds.Y + MarginHeight,
                wid, hgt);
            e.Graphics.InterpolationMode =
                InterpolationMode.HighQualityBilinear;
            e.Graphics.DrawImage(Picture, rect);
        }

        
    }
}