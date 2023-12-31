﻿namespace TrackerUI
{
    partial class CreateTeamForm
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
            TeamsInTournamentList = new ListBox();
            RemoveMemberLink = new LinkLabel();
            TeamNameValue = new TextBox();
            TournamentTeamsLabel = new Label();
            TeamNameLabel = new Label();
            HeaderLabel = new Label();
            SelectTeamMemberValue = new ComboBox();
            SelectTeamMemberLabel = new Label();
            AddTeamButton = new Button();
            AddMemberLabel = new Label();
            FirstNameLabel = new Label();
            FirstNameValue = new TextBox();
            LastNameLabel = new Label();
            LastNameValue = new TextBox();
            EmailLabel = new Label();
            EmailValue = new TextBox();
            PhoneLabel = new Label();
            PhoneValue = new TextBox();
            CreateMemberButton = new Button();
            CreateTeamButton = new Button();
            SuspendLayout();
            // 
            // TeamsInTournamentList
            // 
            TeamsInTournamentList.BorderStyle = BorderStyle.FixedSingle;
            TeamsInTournamentList.FormattingEnabled = true;
            TeamsInTournamentList.ItemHeight = 30;
            TeamsInTournamentList.Location = new Point(419, 104);
            TeamsInTournamentList.Margin = new Padding(0);
            TeamsInTournamentList.Name = "TeamsInTournamentList";
            TeamsInTournamentList.Size = new Size(354, 392);
            TeamsInTournamentList.TabIndex = 11;
            // 
            // RemoveMemberLink
            // 
            RemoveMemberLink.AutoSize = true;
            RemoveMemberLink.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveMemberLink.LinkColor = Color.Firebrick;
            RemoveMemberLink.Location = new Point(508, 496);
            RemoveMemberLink.Name = "RemoveMemberLink";
            RemoveMemberLink.Size = new Size(176, 30);
            RemoveMemberLink.TabIndex = 12;
            RemoveMemberLink.TabStop = true;
            RemoveMemberLink.Text = "Remove Selected";
            RemoveMemberLink.LinkClicked += RemoveSelectedFromTeam_Button;
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(15, 104);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(345, 36);
            TeamNameValue.TabIndex = 0;
            // 
            // TournamentTeamsLabel
            // 
            TournamentTeamsLabel.AutoSize = true;
            TournamentTeamsLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentTeamsLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentTeamsLabel.Location = new Point(419, 64);
            TournamentTeamsLabel.Name = "TournamentTeamsLabel";
            TournamentTeamsLabel.RightToLeft = RightToLeft.No;
            TournamentTeamsLabel.Size = new Size(196, 37);
            TournamentTeamsLabel.TabIndex = 18;
            TournamentTeamsLabel.Text = "Teams / Players";
            TournamentTeamsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamNameLabel.Location = new Point(15, 64);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.RightToLeft = RightToLeft.No;
            TeamNameLabel.Size = new Size(157, 37);
            TeamNameLabel.TabIndex = 19;
            TeamNameLabel.Text = "Team Name";
            TeamNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.RoyalBlue;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(213, 50);
            HeaderLabel.TabIndex = 15;
            HeaderLabel.Text = "Create Team";
            // 
            // SelectTeamMemberValue
            // 
            SelectTeamMemberValue.FormattingEnabled = true;
            SelectTeamMemberValue.Location = new Point(15, 207);
            SelectTeamMemberValue.Name = "SelectTeamMemberValue";
            SelectTeamMemberValue.Size = new Size(345, 38);
            SelectTeamMemberValue.TabIndex = 1;
            // 
            // SelectTeamMemberLabel
            // 
            SelectTeamMemberLabel.AutoSize = true;
            SelectTeamMemberLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            SelectTeamMemberLabel.Location = new Point(15, 167);
            SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            SelectTeamMemberLabel.RightToLeft = RightToLeft.No;
            SelectTeamMemberLabel.Size = new Size(260, 37);
            SelectTeamMemberLabel.TabIndex = 22;
            SelectTeamMemberLabel.Text = "Select Team Member";
            SelectTeamMemberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddTeamButton
            // 
            AddTeamButton.Location = new Point(97, 251);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(178, 41);
            AddTeamButton.TabIndex = 2;
            AddTeamButton.Text = "Add Member";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += AddMemberToTeam_Button;
            // 
            // AddMemberLabel
            // 
            AddMemberLabel.AutoSize = true;
            AddMemberLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AddMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            AddMemberLabel.Location = new Point(15, 307);
            AddMemberLabel.Name = "AddMemberLabel";
            AddMemberLabel.RightToLeft = RightToLeft.No;
            AddMemberLabel.Size = new Size(231, 37);
            AddMemberLabel.TabIndex = 18;
            AddMemberLabel.Text = "Add New Member";
            AddMemberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            FirstNameLabel.Location = new Point(35, 346);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.RightToLeft = RightToLeft.No;
            FirstNameLabel.Size = new Size(143, 37);
            FirstNameLabel.TabIndex = 19;
            FirstNameLabel.Text = "First Name";
            FirstNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FirstNameValue
            // 
            FirstNameValue.Location = new Point(184, 347);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(215, 36);
            FirstNameValue.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            LastNameLabel.Location = new Point(35, 383);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.RightToLeft = RightToLeft.No;
            LastNameLabel.Size = new Size(142, 37);
            LastNameLabel.TabIndex = 19;
            LastNameLabel.Text = "Last Name";
            LastNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LastNameValue
            // 
            LastNameValue.Location = new Point(184, 384);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(215, 36);
            LastNameValue.TabIndex = 4;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            EmailLabel.Location = new Point(36, 420);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.RightToLeft = RightToLeft.No;
            EmailLabel.Size = new Size(80, 37);
            EmailLabel.TabIndex = 19;
            EmailLabel.Text = "Email";
            EmailLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmailValue
            // 
            EmailValue.Location = new Point(185, 421);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(215, 36);
            EmailValue.TabIndex = 5;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PhoneLabel.Location = new Point(36, 457);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.RightToLeft = RightToLeft.No;
            PhoneLabel.Size = new Size(91, 37);
            PhoneLabel.TabIndex = 19;
            PhoneLabel.Text = "Phone";
            PhoneLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PhoneValue
            // 
            PhoneValue.Location = new Point(185, 458);
            PhoneValue.Name = "PhoneValue";
            PhoneValue.Size = new Size(215, 36);
            PhoneValue.TabIndex = 6;
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.Location = new Point(97, 503);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(178, 41);
            CreateMemberButton.TabIndex = 7;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            CreateMemberButton.Click += CreateMemberButton_Click;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.Location = new Point(317, 556);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(178, 41);
            CreateTeamButton.TabIndex = 7;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            CreateTeamButton.Click += CreateTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(798, 618);
            Controls.Add(TeamsInTournamentList);
            Controls.Add(CreateTeamButton);
            Controls.Add(CreateMemberButton);
            Controls.Add(AddTeamButton);
            Controls.Add(RemoveMemberLink);
            Controls.Add(SelectTeamMemberValue);
            Controls.Add(SelectTeamMemberLabel);
            Controls.Add(PhoneValue);
            Controls.Add(EmailValue);
            Controls.Add(LastNameValue);
            Controls.Add(FirstNameValue);
            Controls.Add(TeamNameValue);
            Controls.Add(AddMemberLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(EmailLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(TournamentTeamsLabel);
            Controls.Add(TeamNameLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PrizesList;
        private ListBox TeamsInTournamentList;
        private LinkLabel RemovePrizeLink;
        private LinkLabel RemoveMemberLink;
        private LinkLabel CreatePrizeLink;
        private LinkLabel CreateNewTeamLabel;
        private Label SelectTeamLabel;
        private TextBox EntreFeeValue;
        private Label EntryFeeLabel;
        private TextBox TeamNameValue;
        private Label PrizesLabel;
        private Label TournamentTeamsLabel;
        private Label TeamNameLabel;
        private Label HeaderLabel;
        private ComboBox SelectTeamMemberValue;
        private Label SelectTeamMemberLabel;
        private Button AddTeamButton;
        private Label AddMemberLabel;
        private Label FirstNameLabel;
        private TextBox FirstNameValue;
        private Label LastNameLabel;
        private TextBox LastNameValue;
        private Label EmailLabel;
        private TextBox EmailValue;
        private Label PhoneLabel;
        private TextBox PhoneValue;
        private Button CreateMemberButton;
        private Button CreateTeamButton;
    }
}