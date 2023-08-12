namespace TrackerUI
{
    partial class CreateTournamentForm
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
            HeaderLabel = new Label();
            TournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            EntryFeeLabel = new Label();
            EntreFeeValue = new TextBox();
            SelectTeamValue = new ComboBox();
            SelectTeamLabel = new Label();
            CreateNewTeamLabel = new LinkLabel();
            AddTeamButton = new Button();
            TeamsInTournamentList = new ListBox();
            TournamentTeamsLabel = new Label();
            RemoveTeamLink = new LinkLabel();
            PrizesList = new ListBox();
            PrizesLabel = new Label();
            RemovePrizeLink = new LinkLabel();
            CreatePrizeLink = new LinkLabel();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.RoyalBlue;
            HeaderLabel.Location = new Point(32, 18);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(317, 50);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            TournamentNameValue.Location = new Point(35, 113);
            TournamentNameValue.Name = "TournamentNameValue";
            TournamentNameValue.Size = new Size(345, 36);
            TournamentNameValue.TabIndex = 9;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentNameLabel.Location = new Point(35, 73);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.RightToLeft = RightToLeft.No;
            TournamentNameLabel.Size = new Size(235, 37);
            TournamentNameLabel.TabIndex = 8;
            TournamentNameLabel.Text = "Tournament Name";
            TournamentNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            TournamentNameLabel.Click += TeamOneLabel_Click;
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EntryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            EntryFeeLabel.Location = new Point(39, 323);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.RightToLeft = RightToLeft.No;
            EntryFeeLabel.Size = new Size(126, 37);
            EntryFeeLabel.TabIndex = 8;
            EntryFeeLabel.Text = "Entry Fee";
            EntryFeeLabel.TextAlign = ContentAlignment.MiddleLeft;
            EntryFeeLabel.Click += TeamOneLabel_Click;
            // 
            // EntreFeeValue
            // 
            EntreFeeValue.Location = new Point(171, 324);
            EntreFeeValue.Name = "EntreFeeValue";
            EntreFeeValue.Size = new Size(163, 36);
            EntreFeeValue.TabIndex = 9;
            EntreFeeValue.Text = "0";
            EntreFeeValue.TextChanged += textBox1_TextChanged;
            // 
            // SelectTeamValue
            // 
            SelectTeamValue.FormattingEnabled = true;
            SelectTeamValue.Location = new Point(35, 216);
            SelectTeamValue.Name = "SelectTeamValue";
            SelectTeamValue.Size = new Size(345, 38);
            SelectTeamValue.TabIndex = 11;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            SelectTeamLabel.Location = new Point(35, 176);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.RightToLeft = RightToLeft.No;
            SelectTeamLabel.Size = new Size(155, 37);
            SelectTeamLabel.TabIndex = 10;
            SelectTeamLabel.Text = "Select Team";
            SelectTeamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CreateNewTeamLabel
            // 
            CreateNewTeamLabel.AutoSize = true;
            CreateNewTeamLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewTeamLabel.Location = new Point(199, 182);
            CreateNewTeamLabel.Name = "CreateNewTeamLabel";
            CreateNewTeamLabel.Size = new Size(181, 30);
            CreateNewTeamLabel.TabIndex = 12;
            CreateNewTeamLabel.TabStop = true;
            CreateNewTeamLabel.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            AddTeamButton.Location = new Point(35, 260);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(178, 41);
            AddTeamButton.TabIndex = 13;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // TeamsInTournamentList
            // 
            TeamsInTournamentList.BorderStyle = BorderStyle.FixedSingle;
            TeamsInTournamentList.FormattingEnabled = true;
            TeamsInTournamentList.ItemHeight = 30;
            TeamsInTournamentList.Location = new Point(400, 102);
            TeamsInTournamentList.Margin = new Padding(0);
            TeamsInTournamentList.Name = "TeamsInTournamentList";
            TeamsInTournamentList.Size = new Size(354, 152);
            TeamsInTournamentList.TabIndex = 14;
            // 
            // TournamentTeamsLabel
            // 
            TournamentTeamsLabel.AutoSize = true;
            TournamentTeamsLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentTeamsLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentTeamsLabel.Location = new Point(400, 65);
            TournamentTeamsLabel.Name = "TournamentTeamsLabel";
            TournamentTeamsLabel.RightToLeft = RightToLeft.No;
            TournamentTeamsLabel.Size = new Size(196, 37);
            TournamentTeamsLabel.TabIndex = 8;
            TournamentTeamsLabel.Text = "Teams / Players";
            TournamentTeamsLabel.TextAlign = ContentAlignment.MiddleLeft;
            TournamentTeamsLabel.Click += TeamOneLabel_Click;
            // 
            // RemoveTeamLink
            // 
            RemoveTeamLink.AutoSize = true;
            RemoveTeamLink.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveTeamLink.LinkColor = Color.Firebrick;
            RemoveTeamLink.Location = new Point(757, 113);
            RemoveTeamLink.Name = "RemoveTeamLink";
            RemoveTeamLink.Size = new Size(233, 30);
            RemoveTeamLink.TabIndex = 12;
            RemoveTeamLink.TabStop = true;
            RemoveTeamLink.Text = "Remove Selected Team";
            // 
            // PrizesList
            // 
            PrizesList.BorderStyle = BorderStyle.FixedSingle;
            PrizesList.FormattingEnabled = true;
            PrizesList.ItemHeight = 30;
            PrizesList.Location = new Point(400, 358);
            PrizesList.Margin = new Padding(0);
            PrizesList.Name = "PrizesList";
            PrizesList.Size = new Size(354, 152);
            PrizesList.TabIndex = 14;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PrizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PrizesLabel.Location = new Point(400, 321);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.RightToLeft = RightToLeft.No;
            PrizesLabel.Size = new Size(84, 37);
            PrizesLabel.TabIndex = 8;
            PrizesLabel.Text = "Prizes";
            PrizesLabel.TextAlign = ContentAlignment.MiddleLeft;
            PrizesLabel.Click += TeamOneLabel_Click;
            // 
            // RemovePrizeLink
            // 
            RemovePrizeLink.AutoSize = true;
            RemovePrizeLink.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RemovePrizeLink.LinkColor = Color.Firebrick;
            RemovePrizeLink.Location = new Point(757, 358);
            RemovePrizeLink.Name = "RemovePrizeLink";
            RemovePrizeLink.Size = new Size(228, 30);
            RemovePrizeLink.TabIndex = 12;
            RemovePrizeLink.TabStop = true;
            RemovePrizeLink.Text = "Remove Selected Prize";
            // 
            // CreatePrizeLink
            // 
            CreatePrizeLink.AutoSize = true;
            CreatePrizeLink.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeLink.Location = new Point(122, 416);
            CreatePrizeLink.Name = "CreatePrizeLink";
            CreatePrizeLink.Size = new Size(127, 30);
            CreatePrizeLink.TabIndex = 12;
            CreatePrizeLink.TabStop = true;
            CreatePrizeLink.Text = "Create Prize";
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 536);
            Controls.Add(PrizesList);
            Controls.Add(TeamsInTournamentList);
            Controls.Add(AddTeamButton);
            Controls.Add(RemovePrizeLink);
            Controls.Add(RemoveTeamLink);
            Controls.Add(CreatePrizeLink);
            Controls.Add(CreateNewTeamLabel);
            Controls.Add(SelectTeamValue);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntreFeeValue);
            Controls.Add(EntryFeeLabel);
            Controls.Add(TournamentNameValue);
            Controls.Add(PrizesLabel);
            Controls.Add(TournamentTeamsLabel);
            Controls.Add(TournamentNameLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox TournamentNameValueLabe;
        private Label TournamentNameLabel;
        private Label EntryFeeLabel;
        private TextBox EntreFeeValue;
        private ComboBox SelectTeamValue;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLabel;
        private Button AddTeamButton;
        private TextBox TournamentNameValue;
        private ListBox TeamsInTournamentList;
        private Label TournamentTeamsLabel;
        private LinkLabel RemoveTeamLink;
        private ListBox PrizesList;
        private Label PrizesLabel;
        private LinkLabel RemovePrizeLink;
        private LinkLabel CreatePrizeLink;
    }
}