using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private FormMain mainForm = null;
        public FormWebBackground(Form callingForm)
        {
            mainForm = callingForm as FormMain;
            InitializeComponent();
        }

        private void FormWebBackground_Load(object sender, EventArgs e)
        {
            
        }

        private void webBackground_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string sURL = e.Url.ToString();
            if (sURL.StartsWith("https://secure.etosoftware.com/SearchForClientResultExpanded.asp"))
            {
                listView1.View = View.Details;

                listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
                listView1.Columns.Add("SSN", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("CLID", 80, HorizontalAlignment.Left);
                listView1.Columns.Add("CaseNumber", 100, HorizontalAlignment.Left);
                listView1.Columns.Add("Participant Note", 240, HorizontalAlignment.Left);
                string sCLID = "";
                string sName = "";
                string sSSN = "";
                string sCaseNumber = "";
                string sParticipantNote = "";
                string sBody = webBackground.Document.Body.InnerHtml;
                sBody = sBody.Substring(sBody.IndexOf("firstResult"));
                sBody = sBody.Substring(sBody.IndexOf("'False','arrow','") + 17);
                while (sBody != "")
                    {
                        sCLID = sBody.Substring(0, sBody.IndexOf("'"));
                        sBody = sBody.Substring(sBody.IndexOf("','") + 3);
                        sName = sBody.Substring(0, sBody.IndexOf("'"));
                    //td3
                    int iIndex =  sBody.IndexOf("td3");
                    sBody = sBody.Substring(sBody.IndexOf("td3") + 4);
                    sSSN = sBody.Substring(0, sBody.IndexOf("<"));
                    //td3
                    iIndex = sBody.IndexOf("td3\">");
                    sBody = sBody.Substring(sBody.IndexOf("td3") + 4);
                    sCaseNumber = sBody.Substring(0, sBody.IndexOf("<"));
                    //td4
                    iIndex = sBody.IndexOf("td3\">");
                    sBody = sBody.Substring(sBody.IndexOf("td4") + 4);
                    sParticipantNote = sBody.Substring(0, sBody.IndexOf("<"));
                    var listViewItem = new ListViewItem(new[] {  sName,sSSN, sCLID, sCaseNumber, sParticipantNote});
                    listView1.Items.Add(listViewItem);
                    if (sBody.IndexOf("'False','arrow','")==-1)
                    {
                        sBody = "";
                    }
                    sBody = sBody.Substring(sBody.IndexOf("'False','arrow','") + 17);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.Items[0].Selected)
                {
                    
                }
                else
                {
                    string chosen = listView1.SelectedItems[0].Text;
                    {

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}