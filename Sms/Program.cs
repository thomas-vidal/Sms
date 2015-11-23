using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sms
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
            Application.Run(Setup());
        }

        private static Form Setup()
        {
            Views.MainWindow mainWindow = new Views.MainWindow();
            Controllers.MainController mainController = new Controllers.MainController { Window = mainWindow };
            mainController.HandleNavigation(null);

            return mainWindow;
        }
    }
}
