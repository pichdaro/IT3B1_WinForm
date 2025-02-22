using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3B1_WinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest testForm = new frmTest();
            testForm.MdiParent = this;
            testForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App name: IT3B1 - App\n" +
                "Version: 1.0\nDeveloper: NoBody@All\n" +
                "Company: NA", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void casecadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = MyConfig.activeUser.Username;
            if (MyConfig.activeUser.Role != UserRoles.SuperAdmin)
            {
                userManagerToolStripMenuItem.Enabled = false;
            }
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxV1 frmStu = new frmListBoxV1();
            frmStu.MdiParent = this;
            frmStu.Show();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxV2 frmStu = new frmListBoxV2();
            frmStu.MdiParent = this;
            frmStu.Show();
        }

        private void listViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListViewV1 frmStu = new frmListViewV1();
            frmStu.MdiParent = this;
            frmStu.Show();
        }

        private void listViewDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListViewV2 frmStu = new frmListViewV2();
            frmStu.MdiParent = this;
            frmStu.Show();
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.MdiParent = this;
            user.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword pwd = new frmPassword();
            pwd.ShowDialog();
        }

        private void updateAvataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvata avata = new frmAvata();
            avata.ShowDialog();
        }
    }
}
