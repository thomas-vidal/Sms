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

        /* Var */
        public BindingSource dictionaryBindingSource;

        /* Ctor */
        public MainWindow()
        {
            InitializeComponent();

            dictionaryBindingSource = new BindingSource();
            DictionaryDataGridView.DataSource = dictionaryBindingSource;
        }

        /* Prop */
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

        public string UserText {
            get
            {
                return UserTextBox.Text;
            }
            set
            {
                UserTextBox.Text = value;
            }
        }

        public string TranslatedText
        {
            get
            {
                return TranslatedTextBox.Text;
            }
            set
            {
                TranslatedTextBox.Text = value;
            }
        }

        /* Event */
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

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            Controller.RefreshParse();
        }

        private void DictionaryDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Controller.RefreshParse();
        }
    }
}
