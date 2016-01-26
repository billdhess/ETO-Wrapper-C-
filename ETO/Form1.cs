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
    public partial class Form1 : Form
    {
        private bool result;
        private string sCLID;
        private FormWebBackground frmWebBackground = null;
        public Form1()
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument myDoc;
            string sUrl = e.Url.ToString();
            //Debug.Print("Browser" + sUrl);
            //
            if (sUrl.StartsWith("https://secure.etosoftware.com/Modules/Dashboard/Personal.aspx"))
            {
                frmWebBackground = new FormWebBackground(this);
                frmWebBackground.webBackground.Navigate("https://secure.etosoftware.com/SearchForClientResultExpanded.asp?fromNav=yes&SearchResult=Enter%20Search%20Term%28s%29");

            }
            if (sUrl.StartsWith("https://secure.etosoftware.com/Modules/Dashboard/Participant.aspx?ActorID=C"))
            {
                myDoc = webBrowser1.Document.Window.Frames["Body"].Document;
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
            //Debug.Print("Background="+sUrl);
        }

        private void showBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmWebBackground != null)
            {
                try
                {
                    frmWebBackground.Show();
                }
                catch 
                {
                    // Don't do anything.  Object has been closed
                }
                
            }
        }
    }
}
