
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Model
{
    public interface IPaintService
    {
        Color SetColor(PictureBox img, Point point);

    }
}
