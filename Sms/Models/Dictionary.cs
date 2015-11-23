using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sms.Models
{
    public class Dictionary
    {

        private List<Item> items;

        public Dictionary()
        {
            items = new List<Item>();
        }

        [XmlArray("Dictionary"), XmlArrayItem(typeof(Item), ElementName = "Item")]
        public List<Item> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }
    }
}
