using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sms.Controllers
{
    public class MainController
    {

        public interface IWindow
        {
            MainController Controller { get; set; }

            void Show();
            void Hide();
        }

        private IWindow window;

        public IWindow Window
        {
            get { return window; }
            set
            {
                window = value;
                value.Controller = this;
            }
        }

    }
}
