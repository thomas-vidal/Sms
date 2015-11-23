using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sms.Models
{
    public class Dictionary : BindingList<Item>
    { 

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());

            using (StreamWriter streamWriter = System.IO.File.CreateText(@"C:\Users\Thomas vidal\Desktop\test\french.dico"))
            {
                xmlSerializer.Serialize(streamWriter, this);
            }
        }
    }
}
