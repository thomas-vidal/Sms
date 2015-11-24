using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Sms.Models
{

    [XmlRoot("Dictionary")]
    public class Dictionary : BindingList<Item>
    { 

        public string Parse(string text)
        {
            string result = text;

            foreach (Item item in this)
            {
                if (item.Word != null && item.Term != null)
                {
                    if (result.Contains(item.Term))
                    {
                        result = result.Replace(item.Term, item.Word);
                    }
                }
            }
            return result;
        }

        public void Save(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            using (StreamWriter streamWriter = System.IO.File.CreateText(path))
            {
                xmlSerializer.Serialize(streamWriter, this);
            }
        }

        public void Save(Stream stream)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            xmlSerializer.Serialize(stream, this);
        }

        public void SaveAsDictionary()
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = @"C:\Users\Thomas vidal\Desktop\";
            saveFileDialog.Filter = "dico files (*.dico)|*.dico";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {

                    this.Save(stream);

                    stream.Close();
                }
            }
        }

    }
}
