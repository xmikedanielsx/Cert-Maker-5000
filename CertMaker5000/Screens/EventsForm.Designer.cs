namespace CertMaker5000.Screens
{
    partial class EventsForm
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
            EventsMainLayoutPanel = new TableLayoutPanel();
            EventsDataGrid = new DataGridView();
            SearchTextBox = new TextBox();
            EventsMainPanel = new Panel();
            DescriptionTextBox = new TextBox();
            label7 = new Label();
            ZipTextBox = new TextBox();
            label6 = new Label();
            StateTextBox = new TextBox();
            label5 = new Label();
            CityTextBox = new TextBox();
            label4 = new Label();
            Address2TextBox = new TextBox();
            label3 = new Label();
            Address1TextBox = new TextBox();
            label2 = new Label();
            TitleTextBox = new TextBox();
            label1 = new Label();
            ParticipantsList = new DataGridView();
            EventsButtonLayouPanel = new TableLayoutPanel();
            RefreshButton = new Button();
            SaveButton = new Button();
            EventsMainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EventsDataGrid).BeginInit();
            EventsMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ParticipantsList).BeginInit();
            EventsButtonLayouPanel.SuspendLayout();
            SuspendLayout();
            // 
            // EventsMainLayoutPanel
            // 
            EventsMainLayoutPanel.ColumnCount = 2;
            EventsMainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.04568F));
            EventsMainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.95432F));
            EventsMainLayoutPanel.Controls.Add(EventsDataGrid, 0, 1);
            EventsMainLayoutPanel.Controls.Add(SearchTextBox, 0, 0);
            EventsMainLayoutPanel.Controls.Add(EventsMainPanel, 1, 1);
            EventsMainLayoutPanel.Controls.Add(EventsButtonLayouPanel, 1, 0);
            EventsMainLayoutPanel.Dock = DockStyle.Fill;
            EventsMainLayoutPanel.Location = new Point(0, 0);
            EventsMainLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            EventsMainLayoutPanel.Name = "EventsMainLayoutPanel";
            EventsMainLayoutPanel.RowCount = 2;
            EventsMainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            EventsMainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            EventsMainLayoutPanel.Size = new Size(1379, 638);
            EventsMainLayoutPanel.TabIndex = 0;
            // 
            // EventsDataGrid
            // 
            EventsDataGrid.AllowUserToAddRows = false;
            EventsDataGrid.AllowUserToDeleteRows = false;
            EventsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EventsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventsDataGrid.Dock = DockStyle.Fill;
            EventsDataGrid.Location = new Point(3, 32);
            EventsDataGrid.Margin = new Padding(3, 2, 3, 2);
            EventsDataGrid.MultiSelect = false;
            EventsDataGrid.Name = "EventsDataGrid";
            EventsDataGrid.ReadOnly = true;
            EventsDataGrid.RowHeadersWidth = 51;
            EventsDataGrid.RowTemplate.Height = 29;
            EventsDataGrid.Size = new Size(380, 604);
            EventsDataGrid.TabIndex = 0;
            EventsDataGrid.SelectionChanged += EventsDataGrid_SelectionChanged;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Location = new Point(3, 7);
            SearchTextBox.Margin = new Padding(3, 7, 3, 2);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search . . .";
            SearchTextBox.Size = new Size(380, 23);
            SearchTextBox.TabIndex = 1;
            // 
            // EventsMainPanel
            // 
            EventsMainPanel.Controls.Add(DescriptionTextBox);
            EventsMainPanel.Controls.Add(label7);
            EventsMainPanel.Controls.Add(ZipTextBox);
            EventsMainPanel.Controls.Add(label6);
            EventsMainPanel.Controls.Add(StateTextBox);
            EventsMainPanel.Controls.Add(label5);
            EventsMainPanel.Controls.Add(CityTextBox);
            EventsMainPanel.Controls.Add(label4);
            EventsMainPanel.Controls.Add(Address2TextBox);
            EventsMainPanel.Controls.Add(label3);
            EventsMainPanel.Controls.Add(Address1TextBox);
            EventsMainPanel.Controls.Add(label2);
            EventsMainPanel.Controls.Add(TitleTextBox);
            EventsMainPanel.Controls.Add(label1);
            EventsMainPanel.Controls.Add(ParticipantsList);
            EventsMainPanel.Dock = DockStyle.Fill;
            EventsMainPanel.Location = new Point(389, 32);
            EventsMainPanel.Margin = new Padding(3, 2, 3, 2);
            EventsMainPanel.Name = "EventsMainPanel";
            EventsMainPanel.Size = new Size(987, 604);
            EventsMainPanel.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(15, 164);
            DescriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(963, 130);
            DescriptionTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 147);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 13;
            label7.Text = "Description";
            // 
            // ZipTextBox
            // 
            ZipTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZipTextBox.Location = new Point(833, 101);
            ZipTextBox.Margin = new Padding(3, 2, 3, 2);
            ZipTextBox.Name = "ZipTextBox";
            ZipTextBox.Size = new Size(145, 23);
            ZipTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(794, 109);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 11;
            label6.Text = "Zip";
            // 
            // StateTextBox
            // 
            StateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StateTextBox.Location = new Point(624, 101);
            StateTextBox.Margin = new Padding(3, 2, 3, 2);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(144, 23);
            StateTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(581, 103);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "State";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(88, 101);
            CityTextBox.Margin = new Padding(3, 2, 3, 2);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(444, 23);
            CityTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 103);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "City";
            // 
            // Address2TextBox
            // 
            Address2TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Address2TextBox.Location = new Point(708, 52);
            Address2TextBox.Margin = new Padding(3, 2, 3, 2);
            Address2TextBox.Name = "Address2TextBox";
            Address2TextBox.Size = new Size(271, 23);
            Address2TextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(644, 55);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Address 2";
            // 
            // Address1TextBox
            // 
            Address1TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Address1TextBox.Location = new Point(90, 52);
            Address1TextBox.Margin = new Padding(3, 2, 3, 2);
            Address1TextBox.Name = "Address1TextBox";
            Address1TextBox.Size = new Size(524, 23);
            Address1TextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Address 1";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleTextBox.Location = new Point(90, 10);
            TitleTextBox.Margin = new Padding(3, 2, 3, 2);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(889, 23);
            TitleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Event Title";
            // 
            // ParticipantsList
            // 
            ParticipantsList.AllowUserToAddRows = false;
            ParticipantsList.AllowUserToDeleteRows = false;
            ParticipantsList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ParticipantsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ParticipantsList.Location = new Point(3, 298);
            ParticipantsList.Margin = new Padding(3, 2, 3, 2);
            ParticipantsList.Name = "ParticipantsList";
            ParticipantsList.ReadOnly = true;
            ParticipantsList.RowHeadersWidth = 51;
            ParticipantsList.RowTemplate.Height = 29;
            ParticipantsList.Size = new Size(982, 303);
            ParticipantsList.TabIndex = 0;
            // 
            // EventsButtonLayouPanel
            // 
            EventsButtonLayouPanel.ColumnCount = 4;
            EventsButtonLayouPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EventsButtonLayouPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EventsButtonLayouPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 329F));
            EventsButtonLayouPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            EventsButtonLayouPanel.Controls.Add(RefreshButton, 0, 0);
            EventsButtonLayouPanel.Controls.Add(SaveButton, 3, 0);
            EventsButtonLayouPanel.Dock = DockStyle.Fill;
            EventsButtonLayouPanel.Location = new Point(389, 2);
            EventsButtonLayouPanel.Margin = new Padding(3, 2, 3, 2);
            EventsButtonLayouPanel.Name = "EventsButtonLayouPanel";
            EventsButtonLayouPanel.RowCount = 1;
            EventsButtonLayouPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            EventsButtonLayouPanel.Size = new Size(987, 26);
            EventsButtonLayouPanel.TabIndex = 3;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(3, 2);
            RefreshButton.Margin = new Padding(3, 2, 3, 2);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.RightToLeft = RightToLeft.No;
            RefreshButton.Size = new Size(82, 21);
            RefreshButton.TabIndex = 1;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.Location = new Point(902, 2);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.RightToLeft = RightToLeft.No;
            SaveButton.Size = new Size(82, 21);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 638);
            ControlBox = false;
            Controls.Add(EventsMainLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventsForm";
            Text = "Events";
            EventsMainLayoutPanel.ResumeLayout(false);
            EventsMainLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EventsDataGrid).EndInit();
            EventsMainPanel.ResumeLayout(false);
            EventsMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ParticipantsList).EndInit();
            EventsButtonLayouPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel EventsMainLayoutPanel;
        private DataGridView EventsDataGrid;
        private TextBox SearchTextBox;
        private Panel EventsMainPanel;
        private TableLayoutPanel EventsButtonLayouPanel;
        private Button RefreshButton;
        private Button SaveButton;
        private DataGridView ParticipantsList;
        private TextBox TitleTextBox;
        private Label label1;
        private TextBox ZipTextBox;
        private Label label6;
        private TextBox StateTextBox;
        private Label label5;
        private TextBox CityTextBox;
        private Label label4;
        private TextBox Address2TextBox;
        private Label label3;
        private TextBox Address1TextBox;
        private Label label2;
        private TextBox DescriptionTextBox;
        private Label label7;
    }
}