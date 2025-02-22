using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3B1_WinForm
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            User.FetchData(lvUser);
            cboRole.Items.Add("SysAdmin");
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("User");
            cboRole.SelectedIndex = 0;
            label6.Visible = false;
            UpdateMode = false;
        }

        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtConfirmPwd.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cboRole.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username!",
                    "No username", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            
            if (txtPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("Password mismatch!",
                    "Mismatch", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (MyConfig.IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Invalid email address!",
                    "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (UpdateMode)
            {
                if (string.IsNullOrEmpty(txtPwd.Text))
                {
                    if (!User.Update(usr.ID,txtEmail.Text, 
                            cboRole.SelectedIndex))
                    {
                        MessageBox.Show("Unable to update user!",
                            "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    if (!User.Update(usr.ID, txtPwd.Text, 
                                      txtEmail.Text, cboRole.SelectedIndex))
                    {
                        MessageBox.Show("Unable to update user!",
                            "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                ExitEditMode();
            }
            else
            {
                if (string.IsNullOrEmpty(txtPwd.Text))
                {
                    MessageBox.Show("Please enter password!",
                        "No password", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                if (!User.Add(txtUsername.Text, txtPwd.Text, txtEmail.Text,
                cboRole.SelectedIndex))
                {
                    MessageBox.Show("Unable to add user!",
                        "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
            }
            ClearForm();
            User.FetchData(lvUser);
        }

        private void EnterEditMode()
        {
            txtUsername.Enabled = false;
            btnAdd.Text = "រក្សាទុក";
            btnEdit.Text = "បោះបង់";
            btnPermission.Enabled = false;
            lvUser.Enabled = false;
            UpdateMode = true;
            label6.Text = "Leave blank to keep existing password";
            label6.ForeColor = Color.Red;
            label6.Visible = true;
        }
        private void ExitEditMode()
        {
            txtUsername.Enabled = true;
            btnAdd.Text = "បញ្ចូល";
            btnEdit.Text = "កែតម្រូវ";
            btnPermission.Enabled = true;
            lvUser.Enabled = true;
            UpdateMode = false;
            label6.Visible = false;
        }
        bool UpdateMode;
        User usr;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
            {
                ExitEditMode();
                ClearForm();
                return;
            }
            EnterEditMode();
            if(lvUser.SelectedItems.Count>0)
            {
                usr = (User)lvUser.Items[lvUser.SelectedIndices[0]].Tag;
                txtUsername.Text = usr.Username;
                txtEmail.Text = usr.Email;
                cboRole.SelectedIndex = (int)usr.Role;
            }
        }
    }
}
