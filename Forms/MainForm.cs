using CurtainLauncher.WinForm.Controls.Pages;

namespace CurtainLauncher.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.SwitchPage(new HomePage());
        }

        private void SwitchPage(UserControl page)
        {
            if (this.MainPanel.Controls.Contains(page))
            {
                return;
            }

            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            page.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(page);
            this.MainPanel.Tag = page;
            page.Show();
        }

        private void HomePageItem_Click(object sender, EventArgs e)
        {
            this.SwitchPage(new HomePage());
        }

        private void ServersPageItem_Click(object sender, EventArgs e)
        {
            this.SwitchPage(new ServersPage());
        }

        private void SettingsPageItem_Click(object sender, EventArgs e)
        {
            this.SwitchPage(new SettingsPage());
        }

        private void AboutPageItem_Click(object sender, EventArgs e)
        {
            this.SwitchPage(new AboutPage());
        }
    }
}
