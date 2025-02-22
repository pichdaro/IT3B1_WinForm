namespace IT3B1_WinForm
{
    partial class frmListViewV1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            panel1 = new Panel();
            rbPhnomPenh = new RadioButton();
            rbProvince = new RadioButton();
            label5 = new Label();
            cboShift = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnEdit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtStudent = new TextBox();
            label1 = new Label();
            gbStudentList = new GroupBox();
            lvStudent = new ListView();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            gbStudentList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboShift);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtStudent);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(768, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "បញ្ចូល ឬកែតម្រូវព័ត៌មាននិស្សិត";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbMale);
            panel2.Controls.Add(rbFemale);
            panel2.Location = new Point(174, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 49);
            panel2.TabIndex = 2;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(76, 37);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "ប្រុស";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(106, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(64, 37);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "ស្រី";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbPhnomPenh);
            panel1.Controls.Add(rbProvince);
            panel1.Location = new Point(171, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 50);
            panel1.TabIndex = 4;
            // 
            // rbPhnomPenh
            // 
            rbPhnomPenh.AutoSize = true;
            rbPhnomPenh.Location = new Point(3, 6);
            rbPhnomPenh.Name = "rbPhnomPenh";
            rbPhnomPenh.Size = new Size(141, 37);
            rbPhnomPenh.TabIndex = 0;
            rbPhnomPenh.TabStop = true;
            rbPhnomPenh.Text = "រាជធានីភ្នំពេញ";
            rbPhnomPenh.UseVisualStyleBackColor = true;
            rbPhnomPenh.KeyPress += rbPhnomPenh_KeyPress;
            // 
            // rbProvince
            // 
            rbProvince.AutoSize = true;
            rbProvince.Location = new Point(160, 6);
            rbProvince.Name = "rbProvince";
            rbProvince.Size = new Size(70, 37);
            rbProvince.TabIndex = 1;
            rbProvince.TabStop = true;
            rbProvince.Text = "ខេត្ត";
            rbProvince.UseVisualStyleBackColor = true;
            rbProvince.KeyPress += rbProvince_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 239);
            label5.Name = "label5";
            label5.Size = new Size(133, 33);
            label5.TabIndex = 16;
            label5.Text = "ទីកន្លែងកំណើត៖";
            // 
            // cboShift
            // 
            cboShift.FormattingEnabled = true;
            cboShift.Location = new Point(171, 179);
            cboShift.Name = "cboShift";
            cboShift.Size = new Size(182, 41);
            cboShift.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 182);
            label4.Name = "label4";
            label4.Size = new Size(90, 33);
            label4.TabIndex = 14;
            label4.Text = "វេនសិក្សា៖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 33);
            label3.TabIndex = 8;
            label3.Text = "ភេទ៖";
            // 
            // txtID
            // 
            txtID.Location = new Point(171, 34);
            txtID.Name = "txtID";
            txtID.Size = new Size(354, 40);
            txtID.TabIndex = 0;
            txtID.TextChanged += txtID_TextChanged;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 36);
            label2.Name = "label2";
            label2.Size = new Size(85, 33);
            label2.TabIndex = 6;
            label2.Text = "អត្តលេខ៖";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(542, 291);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 44);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "កែតម្រូវ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(407, 291);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 44);
            btnClear.TabIndex = 7;
            btnClear.Text = "លុបទាំងអស់";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(289, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(171, 291);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(171, 80);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(354, 40);
            txtStudent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 82);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះនិស្សិត៖";
            // 
            // gbStudentList
            // 
            gbStudentList.Controls.Add(lvStudent);
            gbStudentList.Dock = DockStyle.Fill;
            gbStudentList.Location = new Point(0, 349);
            gbStudentList.Name = "gbStudentList";
            gbStudentList.Size = new Size(768, 257);
            gbStudentList.TabIndex = 1;
            gbStudentList.TabStop = false;
            gbStudentList.Text = "បញ្ជីឈ្មោះនិស្សិត";
            // 
            // lvStudent
            // 
            lvStudent.Dock = DockStyle.Fill;
            lvStudent.Location = new Point(3, 36);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new Size(762, 218);
            lvStudent.TabIndex = 0;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
            // 
            // frmListView
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 606);
            Controls.Add(gbStudentList);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListView";
            Text = "Student Information";
            WindowState = FormWindowState.Maximized;
            Load += frmListView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbStudentList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboShift;
        private Label label4;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private Button btnEdit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtStudent;
        private Label label1;
        private RadioButton rbProvince;
        private RadioButton rbPhnomPenh;
        private Label label5;
        private GroupBox gbStudentList;
        private ListView lvStudent;
        private Panel panel1;
        private Panel panel2;
    }
}