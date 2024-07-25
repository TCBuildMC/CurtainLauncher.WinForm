namespace CurtainLauncher.WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PagesStrip = new MenuStrip();
            HomePageItem = new ToolStripMenuItem();
            ServersPageItem = new ToolStripMenuItem();
            SettingsPageItem = new ToolStripMenuItem();
            AboutPageItem = new ToolStripMenuItem();
            PagesStrip.SuspendLayout();
            SuspendLayout();
            // 
            // PagesStrip
            // 
            PagesStrip.ImageScalingSize = new Size(24, 24);
            PagesStrip.Items.AddRange(new ToolStripItem[] { HomePageItem, ServersPageItem, SettingsPageItem, AboutPageItem });
            PagesStrip.Location = new Point(0, 0);
            PagesStrip.Name = "PagesStrip";
            PagesStrip.Size = new Size(1178, 32);
            PagesStrip.TabIndex = 0;
            PagesStrip.Text = "menuStrip1";
            // 
            // HomePageItem
            // 
            HomePageItem.Image = Properties.Resources.Home_32px;
            HomePageItem.Name = "HomePageItem";
            HomePageItem.Size = new Size(86, 28);
            HomePageItem.Text = "主页";
            HomePageItem.Click += HomePageItem_Click;
            // 
            // ServersPageItem
            // 
            ServersPageItem.Image = Properties.Resources.Server_32px;
            ServersPageItem.Name = "ServersPageItem";
            ServersPageItem.Size = new Size(104, 28);
            ServersPageItem.Text = "服务器";
            ServersPageItem.Click += ServersPageItem_Click;
            // 
            // SettingsPageItem
            // 
            SettingsPageItem.Image = Properties.Resources.Settings_32px;
            SettingsPageItem.Name = "SettingsPageItem";
            SettingsPageItem.Size = new Size(86, 28);
            SettingsPageItem.Text = "设置";
            SettingsPageItem.Click += SettingsPageItem_Click;
            // 
            // AboutPageItem
            // 
            AboutPageItem.Image = Properties.Resources.About_32px;
            AboutPageItem.Name = "AboutPageItem";
            AboutPageItem.Size = new Size(86, 28);
            AboutPageItem.Text = "关于";
            AboutPageItem.Click += AboutPageItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1178, 744);
            Controls.Add(PagesStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = PagesStrip;
            Name = "MainForm";
            Text = "CurtainLauncher";
            PagesStrip.ResumeLayout(false);
            PagesStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip PagesStrip;
        private ToolStripMenuItem HomePageItem;
        private ToolStripMenuItem ServersPageItem;
        private ToolStripMenuItem SettingsPageItem;
        private ToolStripMenuItem AboutPageItem;
    }
}
