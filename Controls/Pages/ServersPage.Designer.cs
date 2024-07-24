namespace CurtainLauncher.WinForm.Controls.Pages
{
    partial class ServersPage
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
            SetupNewServerButton = new Button();
            SuspendLayout();
            // 
            // SetupNewServerButton
            // 
            SetupNewServerButton.Location = new Point(88, 70);
            SetupNewServerButton.Name = "SetupNewServerButton";
            SetupNewServerButton.Size = new Size(321, 138);
            SetupNewServerButton.TabIndex = 0;
            SetupNewServerButton.Tag = "";
            SetupNewServerButton.Text = "创建新的服务器实例";
            SetupNewServerButton.UseVisualStyleBackColor = true;
            SetupNewServerButton.Click += SetupNewServerButton_Click;
            // 
            // ServersPage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SetupNewServerButton);
            Name = "ServersPage";
            Size = new Size(1200, 800);
            ResumeLayout(false);
        }

        #endregion

        private Button SetupNewServerButton;
    }
}
