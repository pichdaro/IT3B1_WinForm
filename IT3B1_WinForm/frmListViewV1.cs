using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3B1_WinForm
{
    public partial class frmListViewV1 : Form
    {
        bool UpdateMode;
        public frmListViewV1()
        {
            InitializeComponent();
        }

        private void InitControl()
        {
            rbMale.Checked = true;
            rbPhnomPenh.Checked = true;
            cboShift.Items.Add("ព្រឹក");
            cboShift.Items.Add("ថ្ងៃ");
            cboShift.Items.Add("យប់");
            cboShift.SelectedIndex = 0;
            cboShift.DropDownStyle = ComboBoxStyle.DropDownList;

            lvStudent.Columns.Add("អត្តលេខ", 200);
            lvStudent.Columns.Add("ឈ្មោះ", 300);
            lvStudent.Columns.Add("ភេទ", 150);
            lvStudent.Columns.Add("វេនសិក្សា", 200);
            lvStudent.Columns.Add("ទីកន្លែងកំណើត", 250);
            lvStudent.View = View.Details;
            lvStudent.FullRowSelect = true;
            lvStudent.MultiSelect = true;
        }

        private void ResetControl()
        {
            rbMale.Checked = true;
            rbPhnomPenh.Checked = true;
            txtID.Clear();
            txtStudent.Clear();
            cboShift.SelectedIndex = 0;
            lvStudent.SelectedItems.Clear();
            txtID.Focus();
        }
        private void frmListView_Load(object sender, EventArgs e)
        {
            InitControl();
            UpdateMode = false;
        }
        private void AddData()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter student ID.",
                    "No ID", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student name.",
                    "No Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            //Create string array to store student info
            string[] studData = new string[5];
            studData[0] = txtID.Text;
            studData[1] = txtStudent.Text;
            if (rbMale.Checked)
                studData[2] = rbMale.Text;
            else
                studData[2] = rbFemale.Text;
            studData[3] = cboShift.SelectedItem.ToString();
            if (rbPhnomPenh.Checked)
                studData[4] = rbPhnomPenh.Text;
            else
                studData[4] = rbProvince.Text;

            //Create ListViewItem from array
            ListViewItem stuItem = new ListViewItem(studData);
            lvStudent.Items.Add(stuItem);
            ResetControl();
        }
        private void DeleteData()
        {
            //Check if there is a selection in listview
            if (lvStudent.SelectedItems.Count == 0)
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
                while (lvStudent.SelectedItems.Count > 0)
                {
                    lvStudent.Items.RemoveAt(lvStudent.SelectedIndices[0]);
                }
            }
        }
        private void SaveData()
        {
            //Validate data in textboxes
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter student ID.",
                    "No ID", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student name.",
                    "No Name", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            //Create string array to store student info
            string[] studData = new string[5];
            studData[0] = txtID.Text;
            studData[1] = txtStudent.Text;
            if (rbMale.Checked)
                studData[2] = rbMale.Text;
            else
                studData[2] = rbFemale.Text;
            studData[3] = cboShift.SelectedItem.ToString();
            if (rbPhnomPenh.Checked)
                studData[4] = rbPhnomPenh.Text;
            else
                studData[4] = rbProvince.Text;

            //Create ListViewItem from array
            ListViewItem stuItem = new ListViewItem(studData);
            lvStudent.Items[lvStudent.SelectedIndices[0]] = stuItem;
            ExitUpdateMode();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
                SaveData();
            else
                AddData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
                ExitUpdateMode();
            else
                DeleteData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lvStudent.Items.Count == 0)
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
                lvStudent.Items.Clear();
            }
        }
        private void EnterUpdateMode()
        {
            //Set update status to variable and controls
            UpdateMode = true;
            btnAdd.Text = "រក្សារទុក";
            btnDelete.Text = "បោះបង់";
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
            lvStudent.Enabled = false;
            //Get selected item
            ListViewItem itm = lvStudent.SelectedItems[0];
            txtID.Text = itm.SubItems[0].Text;
            txtStudent.Text = itm.SubItems[1].Text;
            if (itm.SubItems[2].Text == rbMale.Text)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
            cboShift.SelectedItem = itm.SubItems[3].Text;
            if (itm.SubItems[4].Text == rbPhnomPenh.Text)
                rbPhnomPenh.Checked = true;
            else
                rbProvince.Checked = true;
            txtID.Focus();
        }
        private void ExitUpdateMode()
        {
            //Set update status to variable and controls
            UpdateMode = false;
            btnAdd.Text = "បញ្ចូល";
            btnDelete.Text = "លុប";
            btnClear.Enabled = true;
            btnEdit.Enabled = true;
            lvStudent.Enabled = true;
            ResetControl();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
                EnterUpdateMode();
            else
                MessageBox.Show("Please select an item to edit.",
                    "No selected item", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
        }

        private void rbPhnomPenh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddData();
            }
        }

        private void rbProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddData();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtStudent.Focus();
            }
        }
    }
}
