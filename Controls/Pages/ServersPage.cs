using CurtainLauncher.WinForm.Forms.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurtainLauncher.WinForm.Controls.Pages
{
    public partial class ServersPage : UserControl
    {
        public ServersPage()
        {
            InitializeComponent();
        }

        private void SetupNewServerButton_Click(object sender, EventArgs e)
        {
            Form form = new ServerSetupForm();
            form.ShowDialog();
        }
    }
}
