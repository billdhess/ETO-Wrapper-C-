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
            listView1.Columns.Add("ID", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Age", 60, HorizontalAlignment.Left);
            var item1 = new ListViewItem(new[] { "id123", "Tom", "24" });
            var item2 = new ListViewItem(new[] { "id234", "Bill", "62"});
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
        }

        private void webBackground_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}