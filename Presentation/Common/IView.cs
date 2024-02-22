using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presentation.Common
{
    public interface IView
    {
        void Show();
        void Close();
    }
}
