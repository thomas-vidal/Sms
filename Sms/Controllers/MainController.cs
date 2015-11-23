using Sms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            Models.Dictionary Dico { get; set; }

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
            Window.Dico = new Models.Dictionary();

            Window.Dico.Add(new Item { Term = "slt", Word = "Salut" });
            Window.Dico.Add(new Item { Term = "cv", Word = "ca va" });


            Window.Dico.Save();
        }
    }
}
