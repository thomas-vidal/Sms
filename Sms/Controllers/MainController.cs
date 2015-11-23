using Sms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        }

        public void SaveDictionary()
        {
            Window.Dico.Save();
        }

        public void SaveAsDictionary()
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "dico files (*.dico)|*.dico";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {

                    Window.Dico.Save(stream);

                    stream.Close();
                }
            }
        }

        public void NewDico()
        {
            Window.Dico = new Dictionary();
        }

        //TODO : Open File
        public void OpenFile()
        {
            Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
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
                            XmlSerializer serializer = new XmlSerializer(typeof(Models.Item));

                            Window.Dico = (Dictionary)serializer.Deserialize(stream);
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
