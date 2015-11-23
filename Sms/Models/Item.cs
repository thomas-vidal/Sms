using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sms.Models
{
    [Serializable]
    public class Item
    {
        private string term;
        private string word;

        [XmlAttribute()]
        public string Term
        {
            get
            {
                return term;
            }

            set
            {
                term = value;
            }
        }

        [XmlAttribute()]
        public string Word
        {
            get
            {
                return word;
            }

            set
            {
                word = value;
            }
        }
    }
}
