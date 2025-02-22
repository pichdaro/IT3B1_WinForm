namespace IT3B1_WinForm
{
    partial class frmUser
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
            label6 = new Label();
            btnPermission = new Button();
            txtConfirmPwd = new TextBox();
            label5 = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            cboRole = new ComboBox();
            txtEmail = new TextBox();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvUser = new ListView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            lvSuspended = new ListView();
            lvDeleted = new ListView();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnPermission);
            groupBox1.Controls.Add(txtConfirmPwd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cboRole);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPwd);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "គ្រប់គ្រងអ្នកប្រើប្រាស់";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 140);
            label6.Name = "label6";
            label6.Size = new Size(63, 33);
            label6.TabIndex = 11;
            label6.Text = "label6";
            // 
            // btnPermission
            // 
            btnPermission.Location = new Point(440, 183);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(211, 48);
            btnPermission.TabIndex = 10;
            btnPermission.Text = "កំណត់សិទ្ធិអ្នកប្រើប្រាស់";
            btnPermission.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Location = new Point(201, 137);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(259, 40);
            txtConfirmPwd.TabIndex = 2;
            txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 137);
            label5.Name = "label5";
            label5.Size = new Size(157, 33);
            label5.TabIndex = 9;
            label5.Text = "បញ្ជាក់ពាក្យសម្ងាត់៖";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(319, 183);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 48);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "កែតម្រូវ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(201, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 48);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(555, 90);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(259, 41);
            cboRole.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(555, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 40);
            txtEmail.TabIndex = 3;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(201, 91);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(259, 40);
            txtPwd.TabIndex = 1;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(201, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 40);
            txtUsername.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 33);
            label4.TabIndex = 3;
            label4.Text = "តួនាទី៖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 48);
            label3.Name = "label3";
            label3.Size = new Size(73, 33);
            label3.TabIndex = 2;
            label3.Text = "អ៊ីម៉ែល៖";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(109, 33);
            label2.TabIndex = 1;
            label2.Text = "ពាក្យសម្ងាត់៖";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(158, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះអ្នកប្រើប្រាស់៖";
            // 
            // lvUser
            // 
            lvUser.Dock = DockStyle.Fill;
            lvUser.Location = new Point(3, 3);
            lvUser.Name = "lvUser";
            lvUser.Size = new Size(825, 291);
            lvUser.TabIndex = 0;
            lvUser.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 251);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(839, 343);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lvUser);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(831, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "អ្នកប្រើប្រាស់កំពុងដំណើរ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lvDeleted);
            tabPage2.Controls.Add(lvSuspended);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(831, 297);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "អ្នកប្រើប្រាស់​បានផ្អាកដំណើរការ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(831, 297);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "អ្នកប្រើប្រាស់​បានលុប";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvSuspended
            // 
            lvSuspended.Dock = DockStyle.Fill;
            lvSuspended.Location = new Point(3, 3);
            lvSuspended.Name = "lvSuspended";
            lvSuspended.Size = new Size(825, 291);
            lvSuspended.TabIndex = 0;
            lvSuspended.UseCompatibleStateImageBehavior = false;
            // 
            // lvDeleted
            // 
            lvDeleted.Dock = DockStyle.Fill;
            lvDeleted.Location = new Point(3, 3);
            lvDeleted.Name = "lvDeleted";
            lvDeleted.Size = new Size(825, 291);
            lvDeleted.TabIndex = 1;
            lvDeleted.UseCompatibleStateImageBehavior = false;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 594);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUser";
            Text = "User Manager";
            Load += frmUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboRole;
        private TextBox txtEmail;
        private TextBox txtPwd;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEdit;
        private Button btnAdd;
        private ListView lvUser;
        private TextBox txtConfirmPwd;
        private Label label5;
        private Button btnPermission;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView lvDeleted;
        private ListView lvSuspended;
    }
}