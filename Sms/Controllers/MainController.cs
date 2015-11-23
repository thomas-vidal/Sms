using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sms.Controllers
{
    public class MainController : Controller
    {
        public interface IWindow
        {
            MainController Controller { get; set; }

            Dictionary<string, string> Dico { get; set; }

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

        public override void HandleNavigation(object args)
        {
            Window.Dico = new Dictionary<string, string>
            {
                {"slt", "salut"},
                {"cv", "ca va"}
            };
        }
    }
}
