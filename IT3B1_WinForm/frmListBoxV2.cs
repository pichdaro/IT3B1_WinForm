using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3B1_WinForm
{
    public partial class frmListBoxV2 : Form
    {
        public frmListBoxV2()
        {
            InitializeComponent();
        }

        bool UpdateMode;

        private void EnterUpdateMode()
        {
            UpdateMode = true;
            btnAdd.Text = "រក្សាទុក";
            btnDelete.Text = "បោះបង់";
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
            lbStudent.Enabled = false;
            txtStudent.Text = lbStudent.SelectedItem.ToString();
        }

        private void LeaveUpdateMode()
        {
            UpdateMode = false;
            btnAdd.Text = "បញ្ចូល";
            btnDelete.Text = "លុប";
            btnClear.Enabled = true;
            btnEdit.Enabled = true;
            lbStudent.Enabled = true;
            txtStudent.Clear();
            txtStudent.Focus();
        }

        private void AddData()
        {
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student name!",
                    "No data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            lbStudent.Items.Add(txtStudent.Text);
            txtStudent.Clear();
            txtStudent.Focus();
            if (lbStudent.Items.Count > 0)
                btnClear.Enabled = true;
            else
                btnClear.Enabled = false;
        }

        private void DeleteData()
        {
            //Check if there is a selection in listbox
            if (lbStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student's name to " +
                    "delete!", "No name selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Display a confirmation message before deleting
            DialogResult confirm = MessageBox.Show("Are you sure you" +
                " want to delete selected name?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            //check confirm and delete
            if (confirm == DialogResult.Yes)
            {
                //lbStudent.Items.Remove(lbStudent.SelectedItem);
                //lbStudent.Items.RemoveAt(lbStudent.SelectedIndex);
                while (lbStudent.SelectedItems.Count > 0)
                {
                    lbStudent.Items.RemoveAt(lbStudent.SelectedIndex);
                }
                if (lbStudent.Items.Count > 0)
                    btnClear.Enabled = true;
                else
                    btnClear.Enabled = false;
            }

        }

        private void UpdateData()
        {
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student name!",
                    "No data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            lbStudent.Items[lbStudent.SelectedIndex] = txtStudent.Text;
            LeaveUpdateMode();
        }

        private void ClearData()
        {
            if (lbStudent.Items.Count == 0)
            {
                MessageBox.Show("Nothing to clear!", "Empty List",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Display a confirmation message before deleting
            DialogResult confirm = MessageBox.Show("Are you sure you" +
                " want to clear all data?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                lbStudent.Items.Clear();
                btnClear.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
                UpdateData();
            else
                AddData();
        }

        private void txtStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UpdateMode)
                    UpdateData();
                else
                    AddData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
                LeaveUpdateMode();
            else
                DeleteData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudent.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
            }
            if (lbStudent.Items.Count > 0)
                btnClear.Enabled = true;
            else
                btnClear.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnterUpdateMode();
        }

        private void frmListBox_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
        }
    }
}
