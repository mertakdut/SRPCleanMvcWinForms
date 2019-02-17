using System;
using System.Windows.Forms;

namespace SRPCleanMvcWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new XmlListerForm();
            var presenter = new ProductPresenter(form);
            Application.Run(form);
        }
    }
}
