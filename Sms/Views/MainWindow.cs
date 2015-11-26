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
    public partial class MainWindow : Form, MainController.IWindow {

        /* Var */
        public BindingSource dictionaryBindingSource;

        public event EventHandler userTextChanged;
        public event EventHandler dictionaryChanged;
        public event EventHandler newDictionary;
        public event EventHandler openDictionary;
        public event EventHandler saveDictionary;
        public event EventHandler saveAsDictionary;
        public event EventHandler exitApplication;

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
            OnExitApplication(EventArgs.Empty);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSaveDictionary(EventArgs.Empty);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSaveAsDictionary(EventArgs.Empty);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnOpenDictionary(EventArgs.Empty);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNewDictionary(EventArgs.Empty);
        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            OnUserTextChanged(EventArgs.Empty);
        }

        private void DictionaryDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            OnDictionaryChanged(EventArgs.Empty);
        }

        /* Event handler */

        protected virtual void OnUserTextChanged(EventArgs e)
        {
            EventHandler handler = userTextChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnDictionaryChanged(EventArgs e)
        {
            EventHandler handler = dictionaryChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnNewDictionary(EventArgs e)
        {
            EventHandler handler = newDictionary;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnOpenDictionary(EventArgs e)
        {
            EventHandler handler = openDictionary;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnSaveDictionary(EventArgs e)
        {
            EventHandler handler = saveDictionary;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnSaveAsDictionary(EventArgs e)
        {
            EventHandler handler = saveAsDictionary;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnExitApplication(EventArgs e)
        {
            EventHandler handler = exitApplication;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
