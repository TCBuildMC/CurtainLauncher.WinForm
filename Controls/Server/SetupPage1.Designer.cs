namespace CurtainLauncher.WinForm.Controls.Server
{
    partial class SetupPage1
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
            ChooseServerFolderDialog = new FolderBrowserDialog();
            ServerInfoTitleLabel = new Label();
            ServerNameLabel = new Label();
            InputServerName = new TextBox();
            ServerPathLabel = new Label();
            InputServerPath = new TextBox();
            ChooseServerPathButton = new Button();
            SuspendLayout();
            // 
            // ServerInfoTitleLabel
            // 
            ServerInfoTitleLabel.AutoSize = true;
            ServerInfoTitleLabel.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 134);
            ServerInfoTitleLabel.Location = new Point(48, 39);
            ServerInfoTitleLabel.Name = "ServerInfoTitleLabel";
            ServerInfoTitleLabel.Size = new Size(242, 42);
            ServerInfoTitleLabel.TabIndex = 0;
            ServerInfoTitleLabel.Text = "服务器基本信息";
            // 
            // ServerNameLabel
            // 
            ServerNameLabel.AutoSize = true;
            ServerNameLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ServerNameLabel.Location = new Point(113, 148);
            ServerNameLabel.Name = "ServerNameLabel";
            ServerNameLabel.Size = new Size(158, 31);
            ServerNameLabel.TabIndex = 1;
            ServerNameLabel.Text = "服务器名称：";
            // 
            // InputServerName
            // 
            InputServerName.Location = new Point(265, 151);
            InputServerName.Name = "InputServerName";
            InputServerName.Size = new Size(219, 30);
            InputServerName.TabIndex = 2;
            // 
            // ServerPathLabel
            // 
            ServerPathLabel.AutoSize = true;
            ServerPathLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ServerPathLabel.Location = new Point(113, 357);
            ServerPathLabel.Name = "ServerPathLabel";
            ServerPathLabel.Size = new Size(158, 31);
            ServerPathLabel.TabIndex = 3;
            ServerPathLabel.Text = "服务器目录：";
            // 
            // InputServerPath
            // 
            InputServerPath.Location = new Point(265, 357);
            InputServerPath.Name = "InputServerPath";
            InputServerPath.Size = new Size(219, 30);
            InputServerPath.TabIndex = 4;
            // 
            // ChooseServerPathButton
            // 
            ChooseServerPathButton.Location = new Point(490, 360);
            ChooseServerPathButton.Name = "ChooseServerPathButton";
            ChooseServerPathButton.Size = new Size(74, 30);
            ChooseServerPathButton.TabIndex = 5;
            ChooseServerPathButton.Text = "选择...";
            ChooseServerPathButton.UseVisualStyleBackColor = true;
            ChooseServerPathButton.Click += ChooseServerPathButton_Click;
            // 
            // SetupPage1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChooseServerPathButton);
            Controls.Add(InputServerPath);
            Controls.Add(ServerPathLabel);
            Controls.Add(InputServerName);
            Controls.Add(ServerNameLabel);
            Controls.Add(ServerInfoTitleLabel);
            Name = "SetupPage1";
            Size = new Size(778, 544);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog ChooseServerFolderDialog;
        private Label ServerInfoTitleLabel;
        private Label ServerNameLabel;
        private Label ServerPathLabel;
        private Button ChooseServerPathButton;
        public TextBox InputServerName;
        public TextBox InputServerPath;
    }
}
