namespace IT3B1_WinForm
{
    partial class frmPassword
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
            label1 = new Label();
            txtOldPwd = new TextBox();
            txtNewPwd = new TextBox();
            label2 = new Label();
            txtConfirmPwd = new TextBox();
            label3 = new Label();
            btnUpdatePwd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 0;
            label1.Text = "ពាក្យសម្ងាត់ចាស់៖";
            // 
            // txtOldPwd
            // 
            txtOldPwd.Location = new Point(187, 21);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(291, 40);
            txtOldPwd.TabIndex = 0;
            txtOldPwd.UseSystemPasswordChar = true;
            // 
            // txtNewPwd
            // 
            txtNewPwd.Location = new Point(187, 67);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(291, 40);
            txtNewPwd.TabIndex = 1;
            txtNewPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(121, 33);
            label2.TabIndex = 2;
            label2.Text = "ពាក្យសម្ងាត់ថ្មី៖";
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Location = new Point(187, 113);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(291, 40);
            txtConfirmPwd.TabIndex = 2;
            txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(169, 33);
            label3.TabIndex = 4;
            label3.Text = "បញ្ជាក់ពាក្យសម្ងាត់ថ្មី៖";
            // 
            // btnUpdatePwd
            // 
            btnUpdatePwd.Location = new Point(187, 172);
            btnUpdatePwd.Name = "btnUpdatePwd";
            btnUpdatePwd.Size = new Size(147, 42);
            btnUpdatePwd.TabIndex = 3;
            btnUpdatePwd.Text = "ប្ដូរពាក្យសម្ងាត់";
            btnUpdatePwd.UseVisualStyleBackColor = true;
            btnUpdatePwd.Click += btnUpdatePwd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(340, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 42);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "បោះបង់";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 230);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdatePwd);
            Controls.Add(txtConfirmPwd);
            Controls.Add(label3);
            Controls.Add(txtNewPwd);
            Controls.Add(label2);
            Controls.Add(txtOldPwd);
            Controls.Add(label1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPassword";
            Text = "Update Password";
            Load += frmPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOldPwd;
        private TextBox txtNewPwd;
        private Label label2;
        private TextBox txtConfirmPwd;
        private Label label3;
        private Button btnUpdatePwd;
        private Button btnCancel;
    }
}