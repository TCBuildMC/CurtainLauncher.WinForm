using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurtainLauncher.WinForm.Controls.Server
{
    public partial class SetupPage1 : UserControl
    {
        public SetupPage1()
        {
            InitializeComponent();
        }

        private void ChooseServerPathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.ChooseServerFolderDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.InputServerPath.Text = this.ChooseServerFolderDialog.SelectedPath;
            } else {
                MessageBox.Show("你没选择目录！", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
