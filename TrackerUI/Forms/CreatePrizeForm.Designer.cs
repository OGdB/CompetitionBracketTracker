namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeButton = new Button();
            PlaceNumberValue = new TextBox();
            PlaceNumberLabel = new Label();
            HeaderLabel = new Label();
            PlaceNameLabel = new Label();
            PlaceNameValue = new TextBox();
            PrizeAmountLabel = new Label();
            PrizeAmountValue = new TextBox();
            OrLabel = new Label();
            PrizePercentageLabel = new Label();
            PrizePercentageValue = new TextBox();
            SuspendLayout();
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.Location = new Point(139, 348);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(178, 41);
            CreatePrizeButton.TabIndex = 4;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // PlaceNumberValue
            // 
            PlaceNumberValue.Location = new Point(229, 89);
            PlaceNumberValue.Name = "PlaceNumberValue";
            PlaceNumberValue.Size = new Size(215, 36);
            PlaceNumberValue.TabIndex = 0;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PlaceNumberLabel.Location = new Point(12, 86);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.RightToLeft = RightToLeft.No;
            PlaceNumberLabel.Size = new Size(181, 37);
            PlaceNumberLabel.TabIndex = 30;
            PlaceNumberLabel.Text = "Place Number";
            PlaceNumberLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.RoyalBlue;
            HeaderLabel.Location = new Point(12, 9);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(209, 50);
            HeaderLabel.TabIndex = 29;
            HeaderLabel.Text = "Create Prize";
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PlaceNameLabel.Location = new Point(12, 128);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.RightToLeft = RightToLeft.No;
            PlaceNameLabel.Size = new Size(156, 37);
            PlaceNameLabel.TabIndex = 30;
            PlaceNameLabel.Text = "Place Name";
            PlaceNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PlaceNameValue
            // 
            PlaceNameValue.Location = new Point(229, 128);
            PlaceNameValue.Name = "PlaceNameValue";
            PlaceNameValue.Size = new Size(215, 36);
            PlaceNameValue.TabIndex = 1;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PrizeAmountLabel.Location = new Point(12, 170);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.RightToLeft = RightToLeft.No;
            PrizeAmountLabel.Size = new Size(174, 37);
            PrizeAmountLabel.TabIndex = 30;
            PrizeAmountLabel.Text = "Prize Amount";
            PrizeAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PrizeAmountValue
            // 
            PrizeAmountValue.Location = new Point(229, 170);
            PrizeAmountValue.Name = "PrizeAmountValue";
            PrizeAmountValue.Size = new Size(215, 36);
            PrizeAmountValue.TabIndex = 2;
            PrizeAmountValue.Text = "0";
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            OrLabel.ForeColor = Color.FromArgb(51, 153, 255);
            OrLabel.Location = new Point(190, 227);
            OrLabel.Name = "OrLabel";
            OrLabel.RightToLeft = RightToLeft.No;
            OrLabel.Size = new Size(77, 37);
            OrLabel.TabIndex = 33;
            OrLabel.Text = "- or -";
            OrLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Segoe UI Semilight", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PrizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PrizePercentageLabel.Location = new Point(12, 279);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.RightToLeft = RightToLeft.No;
            PrizePercentageLabel.Size = new Size(211, 37);
            PrizePercentageLabel.TabIndex = 30;
            PrizePercentageLabel.Text = "Prize Percentage";
            PrizePercentageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PrizePercentageValue
            // 
            PrizePercentageValue.Location = new Point(229, 282);
            PrizePercentageValue.Name = "PrizePercentageValue";
            PrizePercentageValue.Size = new Size(215, 36);
            PrizePercentageValue.TabIndex = 3;
            PrizePercentageValue.Text = "0";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 416);
            Controls.Add(OrLabel);
            Controls.Add(CreatePrizeButton);
            Controls.Add(PrizePercentageValue);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PrizeAmountValue);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PlaceNameValue);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PlaceNumberValue);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreatePrizeButton;
        private TextBox PlaceNumberValue;
        private Label PlaceNumberLabel;
        private Label HeaderLabel;
        private Label PlaceNameLabel;
        private TextBox PlaceNameValue;
        private Label PrizeAmountLabel;
        private TextBox PrizeAmountValue;
        private Label OrLabel;
        private Label PrizePercentageLabel;
        private TextBox PrizePercentageValue;
    }
}