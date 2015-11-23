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

namespace Sms.Views
{
    public partial class MainWindow : Form, Controllers.MainController.IWindow    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainController Controller { get; set; }

    }
}
