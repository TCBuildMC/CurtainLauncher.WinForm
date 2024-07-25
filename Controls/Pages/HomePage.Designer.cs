namespace CurtainLauncher.WinForm.Controls.Pages
{
    partial class HomePage
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
            MainPageLabelTest = new Label();
            SuspendLayout();
            // 
            // MainPageLabelTest
            // 
            MainPageLabelTest.AutoSize = true;
            MainPageLabelTest.Location = new Point(466, 249);
            MainPageLabelTest.Name = "MainPageLabelTest";
            MainPageLabelTest.Size = new Size(207, 24);
            MainPageLabelTest.TabIndex = 0;
            MainPageLabelTest.Text = "Hello from HomePage!";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPageLabelTest);
            Name = "HomePage";
            Size = new Size(1178, 768);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainPageLabelTest;
    }
}
