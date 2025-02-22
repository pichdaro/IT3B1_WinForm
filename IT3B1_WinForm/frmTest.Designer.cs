namespace IT3B1_WinForm
{
    partial class frmTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHello = new Button();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txtUser = new TextBox();
            richTextBox1 = new RichTextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.Location = new Point(274, 151);
            btnHello.Margin = new Padding(3, 4, 3, 4);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(104, 42);
            btnHello.TabIndex = 0;
            btnHello.Text = "Say Hi";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(60, 91);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 37);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(57, 168);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 40);
            dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 33);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(207, 50);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(311, 40);
            txtUser.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(183, 247);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(406, 222);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(401, 151);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 42);
            btnClose.TabIndex = 6;
            btnClose.Text = "ចាកចេញ";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 521);
            Controls.Add(btnClose);
            Controls.Add(richTextBox1);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox1);
            Controls.Add(btnHello);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txtUser;
        private RichTextBox richTextBox1;
        private Button btnClose;
    }
}
