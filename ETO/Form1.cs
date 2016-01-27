using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETO
{
    public partial class FormMain : Form
    {
        private string sCLID;
        private FormWebBackground frmWebBackground = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var appName = Process.GetCurrentProcess().ProcessName + ".exe";
            SetIE8KeyforWebBrowserControl(appName);
        }
        private void SetIE8KeyforWebBrowserControl(string appName)
        {
            RegistryKey Regkey = null;
            try
            {

                //For 64 bit Machine 
                if (Environment.Is64BitOperatingSystem)
                    Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                else  //For 32 bit Machine 
                    Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);

                //If the path is not correct or 
                //If user't have priviledges to access registry 
                if (Regkey == null)
                {
                    //MessageBox.Show("Application Settings Failed - Address Not found");
                    return;
                }

                string FindAppkey = Convert.ToString(Regkey.GetValue(appName));

                if (string.IsNullOrEmpty(FindAppkey))
                    Regkey.SetValue(appName, unchecked(8000), RegistryValueKind.DWord);

                Regkey.SetValue(appName, unchecked(8000), RegistryValueKind.DWord);


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Application Settings Failed");
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the Registry 
                if (Regkey != null)
                    Regkey.Close();
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void etoBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument myDoc;
            string sUrl = e.Url.ToString();
            //
            if (sUrl.StartsWith("https://secure.etosoftware.com/Modules/Dashboard/Personal.aspx"))
            {

                if ((frmWebBackground == null))
                {
                    frmWebBackground = new FormWebBackground(this);
                }
                else
                {
                    if (frmWebBackground.IsDisposed)
                    {
                        frmWebBackground = new FormWebBackground(this);
                    }
                }
                //frmWebBackground.webBackground.Navigate("https://secure.etosoftware.com/SearchForClientResultExpanded.asp?fromNav=yes&SearchResult=Enter%20Search%20Term%28s%29");
            }
            if (sUrl.StartsWith("https://secure.etosoftware.com/Modules/Dashboard/Participant.aspx?ActorID=C"))
            {
                myDoc = etoBrowser.Document.Window.Frames["Body"].Document;
                string sForm = myDoc.GetElementById("form1").OuterHtml.ToString();
                int sc = sForm.IndexOf("ActorID=C", StringComparison.OrdinalIgnoreCase) + 9;
                int ec = sForm.IndexOf(" Method=Post", StringComparison.OrdinalIgnoreCase);
                int nc = ec - sc;
                sCLID = sForm.Substring(sc, nc);
                comboBox1.Items.Add(sCLID);
                comboBox1.Visible = true;
            }
        }

     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBackground_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string sUrl = e.Url.ToString();
        }
        private void notInFamilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etoBrowser.Navigate("https://Secure.etosoftware.com/Modules/Household/NonFamilyMembers.aspx", "Body");
        }

    private void showBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((frmWebBackground == null))
            {
                frmWebBackground = new FormWebBackground(this);
            }
        else
            {
                if (frmWebBackground.IsDisposed)
                {
                    frmWebBackground = new FormWebBackground(this);
                }
            }
            frmWebBackground.webBackground.Navigate("https://secure.etosoftware.com/SearchForClientResultExpanded.asp?fromNav=yes&SearchResult=Enter%20Search%20Term%28s%29");
            try
                {
                    frmWebBackground.Show();
                }
            catch 
                {
                    // Don't do anything.  Object has been closed
                }                
        }

        private void viewTouchpointsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            etoBrowser.Navigate("https://secure.etosoftware.com/Modules/Participants/ViewEditParticipant.aspx?SearchType=Form&pn=View Participant TouchPoints", "Body");
        }

        private void recordEffortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etoBrowser.Navigate("https://secure.etosoftware.com/RecordOutcomeHx.asp?selType=E", "Body",null, "Referer: https://secure.etosoftware.com/addnew.asp");
        }

        private void recordEffortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            etoBrowser.Navigate("https://secure.etosoftware.com/RecordOutcomeHx.asp?selType=C", "Body", null, "Referer: https://secure.etosoftware.com/addnew.asp");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbout = new FormAbout();
            frmAbout.ShowDialog(this);
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmConfig = new FormConfig();
            frmConfig.ShowDialog(this);
        }
    }
}
