namespace CertMaker5000
{
    partial class MainStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStartForm));
            label1 = new Label();
            label2 = new Label();
            DatabaseTypeCombo = new ComboBox();
            label3 = new Label();
            DatabaseTypeDisplayPanel = new Panel();
            OpenDatabaseButton = new Button();
            CancelButton = new Button();
            CreateDatabaseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(189, 35);
            label1.TabIndex = 0;
            label1.Text = "Database Setup";
            // 
            // label2
            // 
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(887, 65);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // DatabaseTypeCombo
            // 
            DatabaseTypeCombo.FormattingEnabled = true;
            DatabaseTypeCombo.Location = new Point(158, 161);
            DatabaseTypeCombo.Margin = new Padding(3, 4, 3, 4);
            DatabaseTypeCombo.Name = "DatabaseTypeCombo";
            DatabaseTypeCombo.Size = new Size(742, 28);
            DatabaseTypeCombo.TabIndex = 2;
            DatabaseTypeCombo.SelectedIndexChanged += DatabaseTypeCombo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 165);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 3;
            label3.Text = "Database Type";
            // 
            // DatabaseTypeDisplayPanel
            // 
            DatabaseTypeDisplayPanel.Location = new Point(14, 216);
            DatabaseTypeDisplayPanel.Margin = new Padding(3, 4, 3, 4);
            DatabaseTypeDisplayPanel.Name = "DatabaseTypeDisplayPanel";
            DatabaseTypeDisplayPanel.Size = new Size(887, 404);
            DatabaseTypeDisplayPanel.TabIndex = 4;
            // 
            // OpenDatabaseButton
            // 
            OpenDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenDatabaseButton.BackColor = SystemColors.Control;
            OpenDatabaseButton.ForeColor = SystemColors.ControlText;
            OpenDatabaseButton.Location = new Point(413, 640);
            OpenDatabaseButton.Margin = new Padding(3, 4, 3, 4);
            OpenDatabaseButton.Name = "OpenDatabaseButton";
            OpenDatabaseButton.Size = new Size(114, 43);
            OpenDatabaseButton.TabIndex = 11;
            OpenDatabaseButton.Text = "Open DB";
            OpenDatabaseButton.UseVisualStyleBackColor = false;
            OpenDatabaseButton.Visible = false;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelButton.BackColor = Color.RosyBrown;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = SystemColors.ControlText;
            CancelButton.Location = new Point(14, 640);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(115, 43);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Visible = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateDatabaseButton
            // 
            CreateDatabaseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateDatabaseButton.BackColor = SystemColors.Control;
            CreateDatabaseButton.ForeColor = SystemColors.ControlText;
            CreateDatabaseButton.Location = new Point(786, 640);
            CreateDatabaseButton.Margin = new Padding(3, 4, 3, 4);
            CreateDatabaseButton.Name = "CreateDatabaseButton";
            CreateDatabaseButton.Size = new Size(114, 43);
            CreateDatabaseButton.TabIndex = 14;
            CreateDatabaseButton.Text = "Create DB";
            CreateDatabaseButton.UseVisualStyleBackColor = false;
            CreateDatabaseButton.Visible = false;
            // 
            // MainStartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 723);
            ControlBox = false;
            Controls.Add(CreateDatabaseButton);
            Controls.Add(CancelButton);
            Controls.Add(OpenDatabaseButton);
            Controls.Add(DatabaseTypeDisplayPanel);
            Controls.Add(label3);
            Controls.Add(DatabaseTypeCombo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainStartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainStartForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox DatabaseTypeCombo;
        private Label label3;
        private Panel DatabaseTypeDisplayPanel;
        private Button OpenDatabaseButton;
        private Button CancelButton;
        private Button CreateDatabaseButton;
    }
}