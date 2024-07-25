namespace CurtainLauncher.WinForm.Controls.Pages
{
    partial class AboutPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            CurtainLauncherIconBox = new PictureBox();
            CurtainLauncherNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CurtainLauncherIconBox).BeginInit();
            SuspendLayout();
            // 
            // CurtainLauncherIconBox
            // 
            CurtainLauncherIconBox.Image = Properties.Resources.CurtainLauncher_64px;
            CurtainLauncherIconBox.Location = new Point(112, 39);
            CurtainLauncherIconBox.Name = "CurtainLauncherIconBox";
            CurtainLauncherIconBox.Size = new Size(64, 64);
            CurtainLauncherIconBox.TabIndex = 0;
            CurtainLauncherIconBox.TabStop = false;
            // 
            // CurtainLauncherNameLabel
            // 
            CurtainLauncherNameLabel.AutoSize = true;
            CurtainLauncherNameLabel.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            CurtainLauncherNameLabel.Location = new Point(182, 52);
            CurtainLauncherNameLabel.Name = "CurtainLauncherNameLabel";
            CurtainLauncherNameLabel.Size = new Size(270, 41);
            CurtainLauncherNameLabel.TabIndex = 1;
            CurtainLauncherNameLabel.Text = "CurtainLauncher";
            // 
            // AboutPage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CurtainLauncherNameLabel);
            Controls.Add(CurtainLauncherIconBox);
            Name = "AboutPage";
            Size = new Size(1178, 768);
            ((System.ComponentModel.ISupportInitialize)CurtainLauncherIconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CurtainLauncherIconBox;
        private Label CurtainLauncherNameLabel;
    }
}
