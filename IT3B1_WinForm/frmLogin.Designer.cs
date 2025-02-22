namespace IT3B1_WinForm
{
    partial class frmLogin
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
            btnLogin = new Button();
            txtUsername = new TextBox();
            btnExit = new Button();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(243, 114);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(136, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ចូលប្រើប្រាស់";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(243, 22);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(311, 40);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(385, 114);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "ចាកចេញ";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 68);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(311, 40);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_icon_3060;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._11185794_user_person_profile_avatar_people_icon;
            pictureBox2.Location = new Point(193, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9025656_password_icon;
            pictureBox3.Location = new Point(193, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 182);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(btnExit);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Authentication";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUsername;
        private Button btnExit;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}