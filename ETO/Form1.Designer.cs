﻿namespace ETO
{
    partial class FormMain
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
            this.etoBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notInFamilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTouchpointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordEffortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordEffortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBackground = new System.Windows.Forms.WebBrowser();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // etoBrowser
            // 
            this.etoBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etoBrowser.Location = new System.Drawing.Point(0, 27);
            this.etoBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.etoBrowser.Name = "etoBrowser";
            this.etoBrowser.ScriptErrorsSuppressed = true;
            this.etoBrowser.Size = new System.Drawing.Size(1025, 554);
            this.etoBrowser.TabIndex = 0;
            this.etoBrowser.Url = new System.Uri("https://secure.etosoftware.com", System.UriKind.Absolute);
            this.etoBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.etoBrowser_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.participantsToolStripMenuItem,
            this.entitiesToolStripMenuItem,
            this.showBackgroundToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notInFamilesToolStripMenuItem,
            this.viewTouchpointsToolStripMenuItem,
            this.recordEffortToolStripMenuItem1});
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.participantsToolStripMenuItem.Text = "Participants";
            // 
            // notInFamilesToolStripMenuItem
            // 
            this.notInFamilesToolStripMenuItem.Name = "notInFamilesToolStripMenuItem";
            this.notInFamilesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.notInFamilesToolStripMenuItem.Text = "Not in Familes";
            this.notInFamilesToolStripMenuItem.Click += new System.EventHandler(this.notInFamilesToolStripMenuItem_Click);
            // 
            // viewTouchpointsToolStripMenuItem
            // 
            this.viewTouchpointsToolStripMenuItem.Name = "viewTouchpointsToolStripMenuItem";
            this.viewTouchpointsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewTouchpointsToolStripMenuItem.Text = "View Touchpoints";
            this.viewTouchpointsToolStripMenuItem.Click += new System.EventHandler(this.viewTouchpointsToolStripMenuItem_Click);
            // 
            // recordEffortToolStripMenuItem1
            // 
            this.recordEffortToolStripMenuItem1.Name = "recordEffortToolStripMenuItem1";
            this.recordEffortToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.recordEffortToolStripMenuItem1.Text = "Record Effort";
            this.recordEffortToolStripMenuItem1.Click += new System.EventHandler(this.recordEffortToolStripMenuItem1_Click);
            // 
            // entitiesToolStripMenuItem
            // 
            this.entitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordEffortToolStripMenuItem});
            this.entitiesToolStripMenuItem.Name = "entitiesToolStripMenuItem";
            this.entitiesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.entitiesToolStripMenuItem.Text = "Entities";
            // 
            // recordEffortToolStripMenuItem
            // 
            this.recordEffortToolStripMenuItem.Name = "recordEffortToolStripMenuItem";
            this.recordEffortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.recordEffortToolStripMenuItem.Text = "Record Effort";
            this.recordEffortToolStripMenuItem.Click += new System.EventHandler(this.recordEffortToolStripMenuItem_Click);
            // 
            // showBackgroundToolStripMenuItem
            // 
            this.showBackgroundToolStripMenuItem.Name = "showBackgroundToolStripMenuItem";
            this.showBackgroundToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.showBackgroundToolStripMenuItem.Text = "Show Background";
            this.showBackgroundToolStripMenuItem.Click += new System.EventHandler(this.showBackgroundToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(874, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // webBackground
            // 
            this.webBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webBackground.Location = new System.Drawing.Point(0, 0);
            this.webBackground.MinimumSize = new System.Drawing.Size(1, 1);
            this.webBackground.Name = "webBackground";
            this.webBackground.Size = new System.Drawing.Size(11, 10);
            this.webBackground.TabIndex = 3;
            this.webBackground.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBackground_DocumentCompleted_1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 554);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 578);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.etoBrowser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBackground);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "ETO Wrapper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser webBackground;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.WebBrowser etoBrowser;
        private System.Windows.Forms.ToolStripMenuItem showBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notInFamilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTouchpointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordEffortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordEffortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
    }
}

