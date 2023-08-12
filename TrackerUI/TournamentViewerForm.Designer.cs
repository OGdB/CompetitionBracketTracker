namespace TrackerUI
{
    partial class TournamentViewerForm
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
            HeaderLabel = new Label();
            TournamentName = new Label();
            RoundLabel = new Label();
            RoundDropdown = new ComboBox();
            OnlyShowPlayed = new CheckBox();
            MatchupListbox = new ListBox();
            TeamOneLabel = new Label();
            TeamTwoLabel = new Label();
            TeamOneScore = new Label();
            TeamTwoScore = new Label();
            TeamOneScoreValue = new TextBox();
            TeamTwoScoreValue = new TextBox();
            SubmitScoreButton = new Button();
            VersusLabel = new Label();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.RoyalBlue;
            HeaderLabel.Location = new Point(32, 18);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(224, 50);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament: ";
            HeaderLabel.Click += label1_Click;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentName.ForeColor = SystemColors.InfoText;
            TournamentName.Location = new Point(262, 18);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(357, 50);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<Tournament Name>";
            TournamentName.Click += label2_Click;
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            RoundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            RoundLabel.Location = new Point(32, 97);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.RightToLeft = RightToLeft.No;
            RoundLabel.Size = new Size(93, 37);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            RoundLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoundDropdown
            // 
            RoundDropdown.FormattingEnabled = true;
            RoundDropdown.Location = new Point(142, 96);
            RoundDropdown.Name = "RoundDropdown";
            RoundDropdown.Size = new Size(183, 38);
            RoundDropdown.TabIndex = 3;
            // 
            // OnlyShowPlayed
            // 
            OnlyShowPlayed.AutoSize = true;
            OnlyShowPlayed.FlatStyle = FlatStyle.Flat;
            OnlyShowPlayed.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            OnlyShowPlayed.ForeColor = Color.FromArgb(51, 153, 255);
            OnlyShowPlayed.Location = new Point(351, 93);
            OnlyShowPlayed.Name = "OnlyShowPlayed";
            OnlyShowPlayed.Size = new Size(235, 41);
            OnlyShowPlayed.TabIndex = 4;
            OnlyShowPlayed.Text = "Only Show Played";
            OnlyShowPlayed.TextAlign = ContentAlignment.TopCenter;
            OnlyShowPlayed.UseVisualStyleBackColor = true;
            OnlyShowPlayed.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MatchupListbox
            // 
            MatchupListbox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListbox.FormattingEnabled = true;
            MatchupListbox.ItemHeight = 30;
            MatchupListbox.Location = new Point(32, 164);
            MatchupListbox.Margin = new Padding(0);
            MatchupListbox.Name = "MatchupListbox";
            MatchupListbox.Size = new Size(554, 362);
            MatchupListbox.TabIndex = 5;
            // 
            // TeamOneLabel
            // 
            TeamOneLabel.AutoSize = true;
            TeamOneLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TeamOneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamOneLabel.Location = new Point(612, 164);
            TeamOneLabel.Name = "TeamOneLabel";
            TeamOneLabel.RightToLeft = RightToLeft.No;
            TeamOneLabel.Size = new Size(171, 37);
            TeamOneLabel.TabIndex = 2;
            TeamOneLabel.Text = "<Team One>";
            TeamOneLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeamTwoLabel
            // 
            TeamTwoLabel.AutoSize = true;
            TeamTwoLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TeamTwoLabel.Location = new Point(613, 336);
            TeamTwoLabel.Name = "TeamTwoLabel";
            TeamTwoLabel.RightToLeft = RightToLeft.No;
            TeamTwoLabel.Size = new Size(169, 37);
            TeamTwoLabel.TabIndex = 2;
            TeamTwoLabel.Text = "<Team Two>";
            TeamTwoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeamOneScore
            // 
            TeamOneScore.AutoSize = true;
            TeamOneScore.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TeamOneScore.ForeColor = Color.FromArgb(51, 153, 255);
            TeamOneScore.Location = new Point(606, 201);
            TeamOneScore.Name = "TeamOneScore";
            TeamOneScore.RightToLeft = RightToLeft.No;
            TeamOneScore.Size = new Size(81, 37);
            TeamOneScore.TabIndex = 2;
            TeamOneScore.Text = "Score";
            TeamOneScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeamTwoScore
            // 
            TeamTwoScore.AutoSize = true;
            TeamTwoScore.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoScore.ForeColor = Color.FromArgb(51, 153, 255);
            TeamTwoScore.Location = new Point(606, 373);
            TeamTwoScore.Name = "TeamTwoScore";
            TeamTwoScore.RightToLeft = RightToLeft.No;
            TeamTwoScore.Size = new Size(81, 37);
            TeamTwoScore.TabIndex = 2;
            TeamTwoScore.Text = "Score";
            TeamTwoScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeamOneScoreValue
            // 
            TeamOneScoreValue.Location = new Point(693, 202);
            TeamOneScoreValue.Name = "TeamOneScoreValue";
            TeamOneScoreValue.Size = new Size(96, 36);
            TeamOneScoreValue.TabIndex = 6;
            // 
            // TeamTwoScoreValue
            // 
            TeamTwoScoreValue.Location = new Point(693, 374);
            TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            TeamTwoScoreValue.Size = new Size(96, 36);
            TeamTwoScoreValue.TabIndex = 6;
            // 
            // SubmitScoreButton
            // 
            SubmitScoreButton.Location = new Point(608, 447);
            SubmitScoreButton.Name = "SubmitScoreButton";
            SubmitScoreButton.Size = new Size(178, 41);
            SubmitScoreButton.TabIndex = 7;
            SubmitScoreButton.Text = "Submit Scores";
            SubmitScoreButton.UseVisualStyleBackColor = true;
            // 
            // VersusLabel
            // 
            VersusLabel.AutoSize = true;
            VersusLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            VersusLabel.ForeColor = Color.FromArgb(51, 153, 255);
            VersusLabel.Location = new Point(655, 272);
            VersusLabel.Name = "VersusLabel";
            VersusLabel.RightToLeft = RightToLeft.No;
            VersusLabel.Size = new Size(84, 37);
            VersusLabel.TabIndex = 2;
            VersusLabel.Text = "- VS -";
            VersusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 556);
            Controls.Add(SubmitScoreButton);
            Controls.Add(TeamTwoScoreValue);
            Controls.Add(TeamOneScoreValue);
            Controls.Add(MatchupListbox);
            Controls.Add(OnlyShowPlayed);
            Controls.Add(RoundDropdown);
            Controls.Add(TeamTwoLabel);
            Controls.Add(TeamTwoScore);
            Controls.Add(TeamOneScore);
            Controls.Add(VersusLabel);
            Controls.Add(TeamOneLabel);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentName);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label TournamentName;
        private Label RoundLabel;
        private ComboBox RoundDropdown;
        private CheckBox OnlyShowPlayed;
        private ListBox MatchupListbox;
        private Label TeamOneLabel;
        private Label TeamTwoLabel;
        private Label TeamOneScore;
        private Label TeamTwoScore;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Button SubmitScoreButton;
        private Label VersusLabel;
    }
}