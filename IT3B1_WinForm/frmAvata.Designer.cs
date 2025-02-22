namespace IT3B1_WinForm
{
    partial class frmAvata
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 296);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 365);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "កំណត់រូបថតអ្នកប្រើប្រាស់";
            // 
            // button1
            // 
            button1.Location = new Point(349, 99);
            button1.Name = "button1";
            button1.Size = new Size(112, 44);
            button1.TabIndex = 2;
            button1.Text = "រក្សាទុក";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(349, 49);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 44);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "រករូបភាព";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAvata
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 365);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAvata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Avata";
            Load += frmAvata_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
    }
}