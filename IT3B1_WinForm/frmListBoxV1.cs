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
    public partial class frmListBoxV1 : Form
    {
        public frmListBoxV1()
        {
            InitializeComponent();
        }

        private void Add()
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
            txtStudent.Clear();
            txtStudent.Focus();
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
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txtStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
                txtStudent.Text = lbStudent.SelectedItem.ToString();
                txtStudent.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void frmListBoxV1_Load(object sender, EventArgs e)
        {

        }
    }
}
