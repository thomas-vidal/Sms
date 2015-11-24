using Sms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Sms.Controllers
{
    public class MainController : Controller
    {
        /* Interface */
        public interface IWindow
        {
            MainController Controller { get; set; }

            Models.Dictionary Dico { get; set; }

            string UserText { get; set; }
            string TranslatedText { get; set; }

            void Show();
            void Hide();
        }

        /* Var */
        private IWindow window;

        private string curentPath;

        /* Ctor */
        public override void HandleNavigation(object args)
        {
            Window.Dico = new Models.Dictionary();
        }

        /* Prop */
        public IWindow Window
        {
            get { return window; }
            set
            {
                window = value;
                value.Controller = this;
            }
        }

        public string CurentPath
        {
            get
            {
                return curentPath;
            }

            set
            {
                curentPath = value;
            }
        }

        /* Parsor */
        public void RefreshParse()
        {
            Window.TranslatedText = Window.Dico.Parse(Window.UserText);
        }

        /* Manage: Dictionary */
        public void SaveDictionary()
        {
            if (CurentPath != null)
            {
                Window.Dico.Save(CurentPath);
            }
            else
            {
                SaveAsDictionary();
            }
        }

        public void SaveAsDictionary()
        {
            Window.Dico.SaveAsDictionary();
        }

        public void NewDico()
        {
            Window.Dico.Clear();
            RefreshParse();
        }

        public void OpenFile()
        {
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = @"C:\Users\Thomas vidal\Desktop\";
            openFileDialog.Filter = "dico files (*.dico)|*.dico";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            CurentPath = openFileDialog.FileName;
                            XmlSerializer serializer = new XmlSerializer(typeof(Dictionary));

                            Window.Dico = (Dictionary)serializer.Deserialize(stream);

                            RefreshParse();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
