namespace ETO
{
    partial class FormWebBackground
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBackground = new System.Windows.Forms.WebBrowser();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // webBackground
            // 
            this.webBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBackground.Location = new System.Drawing.Point(114, 1);
            this.webBackground.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBackground.Name = "webBackground";
            this.webBackground.Size = new System.Drawing.Size(49, 44);
            this.webBackground.TabIndex = 0;
            this.webBackground.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBackground_DocumentCompleted);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(27, 168);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 151);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // FormWebBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.webBackground);
            this.Name = "FormWebBackground";
            this.Text = "ETO Background Processor";
            this.Load += new System.EventHandler(this.FormWebBackground_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBackground;
        private System.Windows.Forms.ListView listView1;
    }
}