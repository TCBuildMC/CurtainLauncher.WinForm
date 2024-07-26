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
            if (this.Controls.Contains(page))
            {
                return;
            }

            if (this.Controls.Count > 1)
            {
                this.Controls.RemoveAt(1);
            }

            page.Dock = DockStyle.Fill;
            this.Controls.Add(page);
            this.Tag = page;
            page.Show();
        }

        private void HomePageItem_Click(object sender, EventArgs e)
        {
            this.SwitchPage(new HomePage());
        }

        private void DownloadPageItem_Click(object sender, EventArgs e)
        {
            this.SwitchPage(new DownloadPage());
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
