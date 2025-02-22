namespace IT3B1_WinForm
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            usersPreferencesToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            changeEmailToolStripMenuItem = new ToolStripMenuItem();
            updateAvataToolStripMenuItem = new ToolStripMenuItem();
            showFormToolStripMenuItem = new ToolStripMenuItem();
            frmTestToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            listViewToolStripMenuItem = new ToolStripMenuItem();
            listViewToolStripMenuItem1 = new ToolStripMenuItem();
            listViewDBToolStripMenuItem = new ToolStripMenuItem();
            userManagerToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            casecadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            userManualToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, showFormToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usersPreferencesToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // usersPreferencesToolStripMenuItem
            // 
            usersPreferencesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem, changeEmailToolStripMenuItem, updateAvataToolStripMenuItem });
            usersPreferencesToolStripMenuItem.Name = "usersPreferencesToolStripMenuItem";
            usersPreferencesToolStripMenuItem.Size = new Size(270, 34);
            usersPreferencesToolStripMenuItem.Text = "User's Preferences";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(270, 34);
            cToolStripMenuItem.Text = "Change Password";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // changeEmailToolStripMenuItem
            // 
            changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
            changeEmailToolStripMenuItem.Size = new Size(270, 34);
            changeEmailToolStripMenuItem.Text = "Change Email";
            // 
            // updateAvataToolStripMenuItem
            // 
            updateAvataToolStripMenuItem.Name = "updateAvataToolStripMenuItem";
            updateAvataToolStripMenuItem.Size = new Size(270, 34);
            updateAvataToolStripMenuItem.Text = "Update Avata";
            updateAvataToolStripMenuItem.Click += updateAvataToolStripMenuItem_Click;
            // 
            // showFormToolStripMenuItem
            // 
            showFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmTestToolStripMenuItem, listBoxToolStripMenuItem, listViewToolStripMenuItem, listViewToolStripMenuItem1, listViewDBToolStripMenuItem, userManagerToolStripMenuItem });
            showFormToolStripMenuItem.Name = "showFormToolStripMenuItem";
            showFormToolStripMenuItem.Size = new Size(119, 29);
            showFormToolStripMenuItem.Text = "Show Form";
            // 
            // frmTestToolStripMenuItem
            // 
            frmTestToolStripMenuItem.Name = "frmTestToolStripMenuItem";
            frmTestToolStripMenuItem.Size = new Size(224, 34);
            frmTestToolStripMenuItem.Text = "frmTest";
            frmTestToolStripMenuItem.Click += frmTestToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(224, 34);
            listBoxToolStripMenuItem.Text = "ListBox";
            listBoxToolStripMenuItem.Click += listBoxToolStripMenuItem_Click;
            // 
            // listViewToolStripMenuItem
            // 
            listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            listViewToolStripMenuItem.Size = new Size(224, 34);
            listViewToolStripMenuItem.Text = "ListBox-V2";
            listViewToolStripMenuItem.Click += listViewToolStripMenuItem_Click;
            // 
            // listViewToolStripMenuItem1
            // 
            listViewToolStripMenuItem1.Name = "listViewToolStripMenuItem1";
            listViewToolStripMenuItem1.Size = new Size(224, 34);
            listViewToolStripMenuItem1.Text = "ListView";
            listViewToolStripMenuItem1.Click += listViewToolStripMenuItem1_Click;
            // 
            // listViewDBToolStripMenuItem
            // 
            listViewDBToolStripMenuItem.Name = "listViewDBToolStripMenuItem";
            listViewDBToolStripMenuItem.Size = new Size(224, 34);
            listViewDBToolStripMenuItem.Text = "ListView - DB";
            listViewDBToolStripMenuItem.Click += listViewDBToolStripMenuItem_Click;
            // 
            // userManagerToolStripMenuItem
            // 
            userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            userManagerToolStripMenuItem.Size = new Size(224, 34);
            userManagerToolStripMenuItem.Text = "User Manager";
            userManagerToolStripMenuItem.Click += userManagerToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { casecadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(102, 29);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // casecadeToolStripMenuItem
            // 
            casecadeToolStripMenuItem.Name = "casecadeToolStripMenuItem";
            casecadeToolStripMenuItem.Size = new Size(227, 34);
            casecadeToolStripMenuItem.Text = "Casecade";
            casecadeToolStripMenuItem.Click += casecadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(227, 34);
            tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(227, 34);
            tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, userManualToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(212, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // userManualToolStripMenuItem
            // 
            userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            userManualToolStripMenuItem.Size = new Size(212, 34);
            userManualToolStripMenuItem.Text = "User Manual";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 435);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(874, 32);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(74, 25);
            toolStripStatusLabel1.Text = "Howdy!";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(179, 25);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 467);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IT3B1 - App";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem usersPreferencesToolStripMenuItem;
        private ToolStripMenuItem showFormToolStripMenuItem;
        private ToolStripMenuItem frmTestToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem casecadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem userManualToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem listViewToolStripMenuItem1;
        private ToolStripMenuItem listViewDBToolStripMenuItem;
        private ToolStripMenuItem userManagerToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem changeEmailToolStripMenuItem;
        private ToolStripMenuItem updateAvataToolStripMenuItem;
    }
}