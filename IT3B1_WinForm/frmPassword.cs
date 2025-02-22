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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            //Check current password
            string userPwdHash =
                BCrypt.Net.BCrypt.HashPassword(txtOldPwd.Text,
                        MyConfig.activeUser.Password_Salt);
            if (userPwdHash != MyConfig.activeUser.Password_Hash)
            {
                MessageBox.Show("Current password is invalid!",
                    "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtNewPwd.Text))
            {
                MessageBox.Show("Please enter new password!",
                    "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNewPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("New password mismatch!",
                    "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            //Generate new password hash
            string pwdSalt = BCrypt.Net.BCrypt.GenerateSalt();
            string pwdHash = BCrypt.Net.BCrypt.HashPassword(txtNewPwd.Text,
                                    pwdSalt);

            //Update Salt and Hash to activeUser object
            MyConfig.activeUser.Password_Salt = pwdSalt;
            MyConfig.activeUser.Password_Hash = pwdHash;

            //Call update password method in class User

            if (MyConfig.activeUser.UpdatePwd())
            {
                MessageBox.Show("Password is updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Unable to update password!", "Fail",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
