namespace IT3B1_WinForm
{
    partial class frmListBoxV1
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
            btnEdit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtStudent = new TextBox();
            label1 = new Label();
            lbStudent = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtStudent);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ព័ត៌មាននិស្សិត";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(521, 90);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 44);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "កែតម្រូវ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(386, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 44);
            btnClear.TabIndex = 4;
            btnClear.Text = "លុបទាំងអស់";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(268, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(150, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(150, 33);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(483, 40);
            txtStudent.TabIndex = 1;
            txtStudent.KeyPress += txtStudent_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះនិស្សិត៖";
            // 
            // lbStudent
            // 
            lbStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbStudent.FormattingEnabled = true;
            lbStudent.ItemHeight = 33;
            lbStudent.Location = new Point(12, 178);
            lbStudent.Name = "lbStudent";
            lbStudent.SelectionMode = SelectionMode.MultiExtended;
            lbStudent.Size = new Size(651, 400);
            lbStudent.TabIndex = 1;
            lbStudent.SelectedIndexChanged += lbStudent_SelectedIndexChanged;
            // 
            // frmListBoxV1
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 594);
            Controls.Add(lbStudent);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListBoxV1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            Load += frmListBoxV1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtStudent;
        private Label label1;
        private Button btnEdit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private ListBox lbStudent;
    }
}