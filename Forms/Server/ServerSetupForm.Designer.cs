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
            PreviousStepButton = new Button();
            NextStepButton = new Button();
            ContentPanel = new Panel();
            ButtonPanel = new Panel();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PreviousStepButton
            // 
            PreviousStepButton.Location = new Point(536, 3);
            PreviousStepButton.Name = "PreviousStepButton";
            PreviousStepButton.Size = new Size(112, 34);
            PreviousStepButton.TabIndex = 1;
            PreviousStepButton.Text = "上一步";
            PreviousStepButton.UseVisualStyleBackColor = true;
            PreviousStepButton.Click += PreviousStepButton_Click;
            // 
            // NextStepButton
            // 
            NextStepButton.Location = new Point(654, 4);
            NextStepButton.Name = "NextStepButton";
            NextStepButton.Size = new Size(112, 34);
            NextStepButton.TabIndex = 0;
            NextStepButton.Text = "下一步";
            NextStepButton.UseVisualStyleBackColor = true;
            NextStepButton.Click += NextStepButton_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(778, 544);
            ContentPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(PreviousStepButton);
            ButtonPanel.Controls.Add(NextStepButton);
            ButtonPanel.Dock = DockStyle.Bottom;
            ButtonPanel.Location = new Point(0, 494);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(778, 50);
            ButtonPanel.TabIndex = 1;
            // 
            // ServerSetupForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(ButtonPanel);
            Controls.Add(ContentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServerSetupForm";
            Text = "CurtainLauncher | Setup Server";
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button PreviousStepButton;
        private Button NextStepButton;
        private Panel ContentPanel;
        private Panel ButtonPanel;
    }
}