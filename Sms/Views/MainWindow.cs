using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sms.Controllers;
using Sms.Models;

namespace Sms.Views
{
    public partial class MainWindow : Form, Controllers.MainController.IWindow {

        public BindingSource dictionaryBindingSource;

        public MainWindow()
        {
            InitializeComponent();

            dictionaryBindingSource = new BindingSource();
            DictionaryDataGridView.DataSource = dictionaryBindingSource;
        }

        public MainController Controller { get; set; }

        public Dictionary<string,string> Dico
        {
            get
            {
                return null;   
            }
            set
            {
                dictionaryBindingSource.DataSource = value;
            }
        }
    }
}
