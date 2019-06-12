namespace TournamentOrganiserUI
{
    partial class PrizeCreationForm
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNamelabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.Orlabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.placeNumberBox = new System.Windows.Forms.TextBox();
            this.placeNameBox = new System.Windows.Forms.TextBox();
            this.prizeAmountBox = new System.Windows.Forms.TextBox();
            this.prizePercentageBox = new System.Windows.Forms.TextBox();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.Coral;
            this.headingLabel.Location = new System.Drawing.Point(279, 9);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(217, 50);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Create Prize";
            this.headingLabel.Click += new System.EventHandler(this.HeadingLabel_Click);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.placeNumberLabel.ForeColor = System.Drawing.Color.Coral;
            this.placeNumberLabel.Location = new System.Drawing.Point(112, 88);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(198, 38);
            this.placeNumberLabel.TabIndex = 1;
            this.placeNumberLabel.Text = "Place Number:";
            // 
            // placeNamelabel
            // 
            this.placeNamelabel.AutoSize = true;
            this.placeNamelabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.placeNamelabel.ForeColor = System.Drawing.Color.Coral;
            this.placeNamelabel.Location = new System.Drawing.Point(112, 150);
            this.placeNamelabel.Name = "placeNamelabel";
            this.placeNamelabel.Size = new System.Drawing.Size(170, 38);
            this.placeNamelabel.TabIndex = 2;
            this.placeNamelabel.Text = "Place Name:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.amountLabel.ForeColor = System.Drawing.Color.Coral;
            this.amountLabel.Location = new System.Drawing.Point(112, 211);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(222, 38);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Prize Amount(£):";
            // 
            // Orlabel
            // 
            this.Orlabel.AutoSize = true;
            this.Orlabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.Orlabel.ForeColor = System.Drawing.Color.Coral;
            this.Orlabel.Location = new System.Drawing.Point(157, 262);
            this.Orlabel.Name = "Orlabel";
            this.Orlabel.Size = new System.Drawing.Size(93, 38);
            this.Orlabel.TabIndex = 4;
            this.Orlabel.Text = "- OR -";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.percentageLabel.ForeColor = System.Drawing.Color.Coral;
            this.percentageLabel.Location = new System.Drawing.Point(104, 312);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(230, 38);
            this.percentageLabel.TabIndex = 5;
            this.percentageLabel.Text = "Prize Percentage:";
            // 
            // placeNumberBox
            // 
            this.placeNumberBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.placeNumberBox.Location = new System.Drawing.Point(410, 88);
            this.placeNumberBox.Multiline = true;
            this.placeNumberBox.Name = "placeNumberBox";
            this.placeNumberBox.Size = new System.Drawing.Size(271, 37);
            this.placeNumberBox.TabIndex = 6;
            // 
            // placeNameBox
            // 
            this.placeNameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameBox.Location = new System.Drawing.Point(410, 151);
            this.placeNameBox.Multiline = true;
            this.placeNameBox.Name = "placeNameBox";
            this.placeNameBox.Size = new System.Drawing.Size(271, 37);
            this.placeNameBox.TabIndex = 7;
            // 
            // prizeAmountBox
            // 
            this.prizeAmountBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountBox.Location = new System.Drawing.Point(410, 212);
            this.prizeAmountBox.Multiline = true;
            this.prizeAmountBox.Name = "prizeAmountBox";
            this.prizeAmountBox.Size = new System.Drawing.Size(271, 37);
            this.prizeAmountBox.TabIndex = 8;
            this.prizeAmountBox.Text = "0";
            // 
            // prizePercentageBox
            // 
            this.prizePercentageBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageBox.Location = new System.Drawing.Point(410, 313);
            this.prizePercentageBox.Multiline = true;
            this.prizePercentageBox.Name = "prizePercentageBox";
            this.prizePercentageBox.Size = new System.Drawing.Size(271, 37);
            this.prizePercentageBox.TabIndex = 9;
            this.prizePercentageBox.Text = "0";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.Coral;
            this.createPrizeButton.Location = new System.Drawing.Point(307, 393);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(176, 48);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // PrizeCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageBox);
            this.Controls.Add(this.prizeAmountBox);
            this.Controls.Add(this.placeNameBox);
            this.Controls.Add(this.placeNumberBox);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.Orlabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.placeNamelabel);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headingLabel);
            this.Name = "PrizeCreationForm";
            this.Text = "Prize Creation";
            this.Load += new System.EventHandler(this.PrizeCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.Label placeNamelabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label Orlabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.TextBox placeNumberBox;
        private System.Windows.Forms.TextBox placeNameBox;
        private System.Windows.Forms.TextBox prizeAmountBox;
        private System.Windows.Forms.TextBox prizePercentageBox;
        private System.Windows.Forms.Button createPrizeButton;
    }
}