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

        public Dictionary Dico
        {
            get
            {
                return dictionaryBindingSource.DataSource as Models.Dictionary;   
            }
            set
            {
                dictionaryBindingSource.DataSource = value;                  ;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.SaveDictionary();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.SaveAsDictionary();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.OpenFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.NewDico();
        }
    }
}
