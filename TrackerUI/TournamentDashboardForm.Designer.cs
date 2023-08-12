namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            LoadExistingLabel = new Label();
            LoadExistingValue = new TextBox();
            CreateNewButton = new Button();
            LoadButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.Top;
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.RoyalBlue;
            HeaderLabel.Location = new Point(39, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(317, 50);
            HeaderLabel.TabIndex = 29;
            HeaderLabel.Text = "Create Tournament";
            HeaderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoadExistingLabel
            // 
            LoadExistingLabel.Anchor = AnchorStyles.Top;
            LoadExistingLabel.AutoSize = true;
            LoadExistingLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LoadExistingLabel.ForeColor = Color.FromArgb(51, 153, 255);
            LoadExistingLabel.Location = new Point(38, 87);
            LoadExistingLabel.Name = "LoadExistingLabel";
            LoadExistingLabel.RightToLeft = RightToLeft.No;
            LoadExistingLabel.Size = new Size(318, 37);
            LoadExistingLabel.TabIndex = 30;
            LoadExistingLabel.Text = "Load Existing Tournament";
            LoadExistingLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoadExistingValue
            // 
            LoadExistingValue.Anchor = AnchorStyles.Top;
            LoadExistingValue.Location = new Point(90, 127);
            LoadExistingValue.Name = "LoadExistingValue";
            LoadExistingValue.Size = new Size(215, 36);
            LoadExistingValue.TabIndex = 31;
            // 
            // CreateNewButton
            // 
            CreateNewButton.Anchor = AnchorStyles.Top;
            CreateNewButton.Location = new Point(58, 243);
            CreateNewButton.Name = "CreateNewButton";
            CreateNewButton.Size = new Size(279, 41);
            CreateNewButton.TabIndex = 32;
            CreateNewButton.Text = "Create New Tournament";
            CreateNewButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            LoadButton.Anchor = AnchorStyles.Top;
            LoadButton.Location = new Point(108, 169);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(178, 41);
            LoadButton.TabIndex = 32;
            LoadButton.Text = "Load Tournament";
            LoadButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(395, 318);
            Controls.Add(LoadButton);
            Controls.Add(CreateNewButton);
            Controls.Add(LoadExistingValue);
            Controls.Add(LoadExistingLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label LoadExistingLabel;
        private TextBox LoadExistingValue;
        private Button CreateNewButton;
        private Button LoadButton;
    }
}