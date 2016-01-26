using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETO
{
    public partial class FormWebBackground : Form
    {
        public FormWebBackground()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public FormWebBackground(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void FormWebBackground_Load(object sender, EventArgs e)
        {

        }

        private void webBackground_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}