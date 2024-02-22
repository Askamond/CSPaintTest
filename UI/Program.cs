using System;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using MVP.Model; 
using MVP.Presentation.Common;
using MVP.Presentation.Presenters;
using MVP.Presentation.Views;
using MVP.UI;


namespace MVP.UI
{
    public class Program
    {

        public static readonly ApplicationContext Context = new ApplicationContext();


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new PaintPresenter(new PaintForm(Context), new PaintService());
            presenter.Run();
        }
    }
}
