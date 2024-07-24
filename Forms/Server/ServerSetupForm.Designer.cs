namespace CurtainLauncher.WinForm.Forms.Server
{
    partial class ServerSetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSetupForm));
            TestLabel1 = new Label();
            SuspendLayout();
            // 
            // TestLabel1
            // 
            TestLabel1.AutoSize = true;
            TestLabel1.Location = new Point(317, 250);
            TestLabel1.Name = "TestLabel1";
            TestLabel1.Size = new Size(119, 24);
            TestLabel1.TabIndex = 0;
            TestLabel1.Text = "Hello World!";
            // 
            // ServerSetupForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(TestLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServerSetupForm";
            Text = "CurtainLauncher | Setup Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TestLabel1;
    }
}