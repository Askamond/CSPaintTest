using System;
using MVP.Presentation.Common;
using MVP.Presentation.Views;
using MVP.Model;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Presentation.Presenters
{
    public class PaintPresenter: IPresenter
    {
        private readonly IPaintView _view;
        private readonly IPaintService _service;

        public PaintPresenter(IPaintView view, IPaintService service)
        {
            _view = view;
            _service = service;

           _view.FetchColor += () => ColorDecypher(_view.GetPaletImage(), _view.LastClick);
        }

        public void Run()
        {
            _view.Show();
        }

        private void ColorDecypher(PictureBox img, Point point)
        {
            Color clr = _service.SetColor(img, point);
            _view.SetPenColor(clr);
        }
    }
}
