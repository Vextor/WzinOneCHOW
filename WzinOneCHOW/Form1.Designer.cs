namespace WzinOneCHOW
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adomToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoUploaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCONToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rCONToolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.demoUploaderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.everythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mW2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callOfDuty4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopAccessThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1194, 532);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Forum";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1180, 497);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://warzone-gaming.co.uk", System.UriKind.Absolute);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1186, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IRC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(1180, 497);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Url = new System.Uri("http://qchat.rizon.net/?&channels=%23WarZone", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webBrowser3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1186, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "WarZone OS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(3, 3);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.ScriptErrorsSuppressed = true;
            this.webBrowser3.Size = new System.Drawing.Size(1180, 497);
            this.webBrowser3.TabIndex = 0;
            this.webBrowser3.Url = new System.Uri("http://portal.warzone-gaming.co.uk", System.UriKind.Absolute);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adomToolsToolStripMenuItem,
            this.banListsToolStripMenuItem,
            this.remoteDesktopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adomToolsToolStripMenuItem
            // 
            this.adomToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demoUploaderToolStripMenuItem,
            this.rCONToolToolStripMenuItem,
            this.downloadToolsToolStripMenuItem});
            this.adomToolsToolStripMenuItem.Name = "adomToolsToolStripMenuItem";
            this.adomToolsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.adomToolsToolStripMenuItem.Text = "Admin Tools";
            this.adomToolsToolStripMenuItem.Click += new System.EventHandler(this.adomToolsToolStripMenuItem_Click);
            // 
            // demoUploaderToolStripMenuItem
            // 
            this.demoUploaderToolStripMenuItem.Name = "demoUploaderToolStripMenuItem";
            this.demoUploaderToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.demoUploaderToolStripMenuItem.Text = "Demo Uploader";
            this.demoUploaderToolStripMenuItem.Click += new System.EventHandler(this.demoUploaderToolStripMenuItem_Click);
            // 
            // rCONToolToolStripMenuItem
            // 
            this.rCONToolToolStripMenuItem.Name = "rCONToolToolStripMenuItem";
            this.rCONToolToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.rCONToolToolStripMenuItem.Text = "RCON Tool";
            this.rCONToolToolStripMenuItem.Click += new System.EventHandler(this.rCONToolToolStripMenuItem_Click);
            // 
            // downloadToolsToolStripMenuItem
            // 
            this.downloadToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rCONToolToolStripMenuItem1,
            this.demoUploaderToolStripMenuItem1,
            this.everythingToolStripMenuItem});
            this.downloadToolsToolStripMenuItem.Name = "downloadToolsToolStripMenuItem";
            this.downloadToolsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.downloadToolsToolStripMenuItem.Text = "Download Tools";
            this.downloadToolsToolStripMenuItem.Click += new System.EventHandler(this.downloadToolsToolStripMenuItem_Click);
            // 
            // rCONToolToolStripMenuItem1
            // 
            this.rCONToolToolStripMenuItem1.Name = "rCONToolToolStripMenuItem1";
            this.rCONToolToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.rCONToolToolStripMenuItem1.Text = "RCON Tool";
            this.rCONToolToolStripMenuItem1.Click += new System.EventHandler(this.rCONToolToolStripMenuItem1_Click);
            // 
            // demoUploaderToolStripMenuItem1
            // 
            this.demoUploaderToolStripMenuItem1.Name = "demoUploaderToolStripMenuItem1";
            this.demoUploaderToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.demoUploaderToolStripMenuItem1.Text = "Demo Uploader";
            this.demoUploaderToolStripMenuItem1.Click += new System.EventHandler(this.demoUploaderToolStripMenuItem1_Click);
            // 
            // everythingToolStripMenuItem
            // 
            this.everythingToolStripMenuItem.Name = "everythingToolStripMenuItem";
            this.everythingToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.everythingToolStripMenuItem.Text = "All Tools";
            this.everythingToolStripMenuItem.Click += new System.EventHandler(this.everythingToolStripMenuItem_Click);
            // 
            // banListsToolStripMenuItem
            // 
            this.banListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mW2ToolStripMenuItem,
            this.callOfDuty4ToolStripMenuItem});
            this.banListsToolStripMenuItem.Name = "banListsToolStripMenuItem";
            this.banListsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.banListsToolStripMenuItem.Text = "Ban Lists";
            // 
            // mW2ToolStripMenuItem
            // 
            this.mW2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legacyToolStripMenuItem,
            this.newToolStripMenuItem});
            this.mW2ToolStripMenuItem.Name = "mW2ToolStripMenuItem";
            this.mW2ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.mW2ToolStripMenuItem.Text = "MW2";
            // 
            // legacyToolStripMenuItem
            // 
            this.legacyToolStripMenuItem.Name = "legacyToolStripMenuItem";
            this.legacyToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.legacyToolStripMenuItem.Text = "Legacy";
            this.legacyToolStripMenuItem.Click += new System.EventHandler(this.legacyToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.newToolStripMenuItem.Text = "Modern";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // callOfDuty4ToolStripMenuItem
            // 
            this.callOfDuty4ToolStripMenuItem.Name = "callOfDuty4ToolStripMenuItem";
            this.callOfDuty4ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.callOfDuty4ToolStripMenuItem.Text = "Call of Duty 4";
            this.callOfDuty4ToolStripMenuItem.Click += new System.EventHandler(this.callOfDuty4ToolStripMenuItem_Click);
            // 
            // remoteDesktopToolStripMenuItem
            // 
            this.remoteDesktopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteDesktopApplicationToolStripMenuItem,
            this.remoteDesktopAccessThreadToolStripMenuItem});
            this.remoteDesktopToolStripMenuItem.Name = "remoteDesktopToolStripMenuItem";
            this.remoteDesktopToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.remoteDesktopToolStripMenuItem.Text = "Remote Desktop";
            // 
            // remoteDesktopApplicationToolStripMenuItem
            // 
            this.remoteDesktopApplicationToolStripMenuItem.Name = "remoteDesktopApplicationToolStripMenuItem";
            this.remoteDesktopApplicationToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.remoteDesktopApplicationToolStripMenuItem.Text = "Remote Desktop Application";
            this.remoteDesktopApplicationToolStripMenuItem.Click += new System.EventHandler(this.remoteDesktopApplicationToolStripMenuItem_Click);
            // 
            // remoteDesktopAccessThreadToolStripMenuItem
            // 
            this.remoteDesktopAccessThreadToolStripMenuItem.Name = "remoteDesktopAccessThreadToolStripMenuItem";
            this.remoteDesktopAccessThreadToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.remoteDesktopAccessThreadToolStripMenuItem.Text = "Remote Desktop Access Thread";
            this.remoteDesktopAccessThreadToolStripMenuItem.Click += new System.EventHandler(this.remoteDesktopAccessThreadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 560);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WarZone Admin Kit";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adomToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoUploaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCONToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rCONToolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem demoUploaderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem banListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mW2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callOfDuty4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopAccessThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everythingToolStripMenuItem;
    }
}

