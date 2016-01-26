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
            this.SuspendLayout();
            // 
            // webBackground
            // 
            this.webBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBackground.Location = new System.Drawing.Point(0, 0);
            this.webBackground.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBackground.Name = "webBackground";
            this.webBackground.Size = new System.Drawing.Size(581, 493);
            this.webBackground.TabIndex = 0;
            this.webBackground.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBackground_DocumentCompleted);
            // 
            // FormWebBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 493);
            this.Controls.Add(this.webBackground);
            this.Name = "FormWebBackground";
            this.Text = "ETO Background Processor";
            this.Load += new System.EventHandler(this.FormWebBackground_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBackground;
    }
}