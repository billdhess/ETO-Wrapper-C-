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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.labelVersion.Text = String.Format("My Application Version {0}", version);
        }

        private void FormAbout_KeyUp(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void FormAbout_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
