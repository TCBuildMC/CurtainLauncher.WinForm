using CurtainLauncher.WinForm.Controls.Server;
using CurtainLauncher.WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurtainLauncher.WinForm.Forms.Server
{
    public partial class ServerSetupForm : Form
    {
        public static readonly int MAX_INDEX = 2;
        private int Index;
        private readonly SetupServerInfo Info;
        private List<UserControl> Pages = new() 
        {
            new SetupPage1(),
            new SetupPage2()
        };

        public ServerSetupForm()
        {
            this.Index = 1;
            this.Info = new();
            InitializeComponent();

            this.SwitchPage(this.Pages[this.Index - 1]);
        }

        private void SwitchPage(UserControl page)
        {
            if (this.Index == 1)
            {
                PreviousStepButton.Text = "取消";
            } else
            {
                PreviousStepButton.Text = "上一步";
            }

            if (this.Index == MAX_INDEX)
            {
                NextStepButton.Text = "完成";
            } else
            {
                NextStepButton.Text = "下一步";
            }


            if (this.ContentPanel.Controls.Count > 0)
            {
                this.ContentPanel.Controls.RemoveAt(0);
            }

            page.Dock = DockStyle.Fill;
            this.ContentPanel.Controls.Add(page);
            this.ContentPanel.Tag = page;
            page.Show();
        }

        private void PreviousStepButton_Click(object sender, EventArgs e)
        {
            if (this.Index == 1)
            {
                this.Close();
                return;
            }

            this.Index--;
            this.SwitchPage(this.Pages[this.Index - 1]);
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            if (this.Index == MAX_INDEX) 
            {
                SetupPage1 page1 = (SetupPage1) this.Pages[0];
                this.Info.Name = page1.InputServerName.Text;
                this.Info.Path = page1.InputServerPath.Text;

                this.Info.Setup();
                this.Close();
                return;
            }

            this.Index++;
            this.SwitchPage(this.Pages[this.Index - 1]);
        }
    }
}
