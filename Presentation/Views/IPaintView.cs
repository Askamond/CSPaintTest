using MVP.Presentation.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Presentation.Views
{
    public interface IPaintView : IView
    {
        event Action FetchColor;

        Point LastClick { get; }

        PictureBox GetPaletImage();

        void SetPenColor(Color color);
    }
}
