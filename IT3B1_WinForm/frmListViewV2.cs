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
using System.Data.OleDb;

namespace IT3B1_WinForm
{
    public partial class frmListViewV2 : Form
    {
        bool UpdateMode;
        Student objStu;
        public frmListViewV2()
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

        private void FetchData()
        {
            Student.FetchData(lvStudent);
        }
        private void frmListView_Load(object sender, EventArgs e)
        {
            InitControl();
            UpdateMode = false;
            FetchData();

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
            //Creating object student to store info from controls
            Student objStu = new Student();
            objStu.SID = txtID.Text;
            objStu.SName = txtStudent.Text;
            if (rbMale.Checked)
                objStu.Gender = Sex.Male;
            else
                objStu.Gender = Sex.Female;
            
            objStu.StudyShift = (Shift)cboShift.SelectedIndex;

            if (rbPhnomPenh.Checked)
                objStu.PoB = Address.Phnom_Penh;
            else
                objStu.PoB = Address.Province;

            //Call AddStudent method to insert data to database
            if (objStu.AddStudent())
            {
                ResetControl();
                FetchData();
            }
            else
            {
                MessageBox.Show("Error adding student info", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                Student objStu;
                for(int i=0; i<lvStudent.SelectedItems.Count; i++)
                {
                    int selectedIndex = lvStudent.SelectedItems[i].Index;
                    objStu = (Student)lvStudent.Items[selectedIndex].Tag;
                    objStu.DeleteStudent();
                }
                FetchData();
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
            //Update objStudent data from controls
            objStu.SID = txtID.Text;
            objStu.SName = txtStudent.Text;

            if (rbMale.Checked)
                objStu.Gender = Sex.Male;
            else
                objStu.Gender = Sex.Female;

            objStu.StudyShift = (Shift)cboShift.SelectedIndex;

            if (rbPhnomPenh.Checked)
                objStu.PoB = Address.Phnom_Penh;
            else
                objStu.PoB = Address.Province;
            if (objStu.UpdateStudent())
            {
                ExitUpdateMode();
                FetchData();
            }
            else
            {
                MessageBox.Show("Error updating information!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
                if (Student.DeleteAll())
                {
                    lvStudent.Items.Clear();
                }
                else
                {
                    MessageBox.Show("An error has occured!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            objStu = (Student)itm.Tag;

            txtID.Text = objStu.SID;
            txtStudent.Text = objStu.SName;
            if (objStu.Gender == Sex.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cboShift.SelectedIndex = (int)objStu.StudyShift;
            if (objStu.PoB == Address.Phnom_Penh)
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
