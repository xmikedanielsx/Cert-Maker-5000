using System.Windows.Controls;

namespace CertMaker5000.Screens
{
    partial class MainForm
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
            MainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            eventsToolStripMenuItem = new ToolStripMenuItem();
            participantsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ThemeCombo = new ToolStripComboBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            mailSettingsToolStripMenuItem = new ToolStripMenuItem();
            folderSettingsToolStripMenuItem = new ToolStripMenuItem();
            MainTabControl = new System.Windows.Forms.TabControl();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ThemeCombo, toolStripMenuItem1, settingsToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Padding = new Padding(5, 2, 0, 2);
            MainMenuStrip.Size = new Size(1444, 27);
            MainMenuStrip.TabIndex = 22;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventsToolStripMenuItem, participantsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(136, 22);
            eventsToolStripMenuItem.Text = "Events";
            eventsToolStripMenuItem.Click += eventsToolStripMenuItem_Click;
            // 
            // participantsToolStripMenuItem
            // 
            participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            participantsToolStripMenuItem.Size = new Size(136, 22);
            participantsToolStripMenuItem.Text = "Participants";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(136, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // ThemeCombo
            // 
            ThemeCombo.Alignment = ToolStripItemAlignment.Right;
            ThemeCombo.Name = "ThemeCombo";
            ThemeCombo.Size = new Size(106, 23);
            ThemeCombo.SelectedIndexChanged += ThemeCombo_SelectedIndexChanged;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(34, 23);
            toolStripMenuItem1.Text = "  |  ";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mailSettingsToolStripMenuItem, folderSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 23);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // mailSettingsToolStripMenuItem
            // 
            mailSettingsToolStripMenuItem.Name = "mailSettingsToolStripMenuItem";
            mailSettingsToolStripMenuItem.Size = new Size(180, 22);
            mailSettingsToolStripMenuItem.Text = "Mail Settings";
            mailSettingsToolStripMenuItem.Click += mailSettingsToolStripMenuItem_Click_1;
            // 
            // folderSettingsToolStripMenuItem
            // 
            folderSettingsToolStripMenuItem.Name = "folderSettingsToolStripMenuItem";
            folderSettingsToolStripMenuItem.Size = new Size(180, 22);
            folderSettingsToolStripMenuItem.Text = "Folder Settings";
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Location = new Point(10, 26);
            MainTabControl.Margin = new Padding(3, 2, 3, 2);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1423, 614);
            MainTabControl.TabIndex = 23;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 650);
            Controls.Add(MainTabControl);
            Controls.Add(MainMenuStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripComboBox ThemeCombo;
        private ToolStripMenuItem eventsToolStripMenuItem;
        private ToolStripMenuItem participantsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem mailSettingsToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl MainTabControl;
        private ToolStripMenuItem folderSettingsToolStripMenuItem;
    }
}