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
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("SSN", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CaseNumber", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Participant Note", 240, HorizontalAlignment.Left);
        }

        private void webBackground_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}