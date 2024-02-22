using MVP.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Model
{
    public class PaintService: IPaintService
    {
        public Color SetColor(PictureBox img, Point point)
        {
            float pointX = 1f*img.Image.Width / img.Width;
            float pointY = 1f*img.Image.Height / img.Height;
            return ((Bitmap)img.Image).GetPixel((int)(point.X * pointX), (int)(point.Y * pointY));

        }

    }
}
