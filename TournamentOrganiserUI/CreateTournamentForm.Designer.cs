namespace TournamentOrganiserUI
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.tournamentNameBox = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.entryFeeBox = new System.Windows.Forms.TextBox();
            this.teamSelectLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.LinkLabel();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.prizeButton = new System.Windows.Forms.Button();
            this.teamListLabel = new System.Windows.Forms.Label();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.prizeslabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
            this.createTourneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.BackColor = System.Drawing.Color.Transparent;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 28.25F);
            this.headingLabel.ForeColor = System.Drawing.Color.Coral;
            this.headingLabel.Location = new System.Drawing.Point(13, 13);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(343, 51);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Create Tournament";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.namelabel.ForeColor = System.Drawing.Color.Coral;
            this.namelabel.Location = new System.Drawing.Point(15, 77);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(227, 35);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Tournament Name:";
            // 
            // tournamentNameBox
            // 
            this.tournamentNameBox.Location = new System.Drawing.Point(26, 121);
            this.tournamentNameBox.Name = "tournamentNameBox";
            this.tournamentNameBox.Size = new System.Drawing.Size(399, 33);
            this.tournamentNameBox.TabIndex = 2;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feeLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.feeLabel.ForeColor = System.Drawing.Color.Coral;
            this.feeLabel.Location = new System.Drawing.Point(20, 181);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(121, 35);
            this.feeLabel.TabIndex = 3;
            this.feeLabel.Text = "Entry Fee:";
            // 
            // entryFeeBox
            // 
            this.entryFeeBox.Location = new System.Drawing.Point(161, 184);
            this.entryFeeBox.Name = "entryFeeBox";
            this.entryFeeBox.Size = new System.Drawing.Size(264, 33);
            this.entryFeeBox.TabIndex = 4;
            this.entryFeeBox.Text = "0";
            // 
            // teamSelectLabel
            // 
            this.teamSelectLabel.AutoSize = true;
            this.teamSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamSelectLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.teamSelectLabel.ForeColor = System.Drawing.Color.Coral;
            this.teamSelectLabel.Location = new System.Drawing.Point(20, 264);
            this.teamSelectLabel.Name = "teamSelectLabel";
            this.teamSelectLabel.Size = new System.Drawing.Size(146, 35);
            this.teamSelectLabel.TabIndex = 5;
            this.teamSelectLabel.Text = "Select Team";
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Location = new System.Drawing.Point(274, 270);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(151, 25);
            this.createTeamLabel.TabIndex = 6;
            this.createTeamLabel.TabStop = true;
            this.createTeamLabel.Text = "create new team";
            this.createTeamLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTeamLabel_LinkClicked);
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(28, 315);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(396, 33);
            this.selectTeamDropDown.TabIndex = 7;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.addTeamButton.Location = new System.Drawing.Point(161, 384);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(99, 32);
            this.addTeamButton.TabIndex = 8;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // prizeButton
            // 
            this.prizeButton.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.prizeButton.Location = new System.Drawing.Point(161, 490);
            this.prizeButton.Name = "prizeButton";
            this.prizeButton.Size = new System.Drawing.Size(99, 32);
            this.prizeButton.TabIndex = 9;
            this.prizeButton.Text = "Create Prize";
            this.prizeButton.UseVisualStyleBackColor = true;
            this.prizeButton.Click += new System.EventHandler(this.PrizeButton_Click);
            // 
            // teamListLabel
            // 
            this.teamListLabel.AutoSize = true;
            this.teamListLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamListLabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.teamListLabel.ForeColor = System.Drawing.Color.Coral;
            this.teamListLabel.Location = new System.Drawing.Point(519, 77);
            this.teamListLabel.Name = "teamListLabel";
            this.teamListLabel.Size = new System.Drawing.Size(178, 35);
            this.teamListLabel.TabIndex = 10;
            this.teamListLabel.Text = "Teams/Players:";
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.ItemHeight = 25;
            this.teamListBox.Location = new System.Drawing.Point(525, 121);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(355, 179);
            this.teamListBox.TabIndex = 11;
            // 
            // prizeslabel
            // 
            this.prizeslabel.AutoSize = true;
            this.prizeslabel.BackColor = System.Drawing.Color.Transparent;
            this.prizeslabel.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.prizeslabel.ForeColor = System.Drawing.Color.Coral;
            this.prizeslabel.Location = new System.Drawing.Point(519, 315);
            this.prizeslabel.Name = "prizeslabel";
            this.prizeslabel.Size = new System.Drawing.Size(84, 35);
            this.prizeslabel.TabIndex = 12;
            this.prizeslabel.Text = "Prizes:";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 25;
            this.prizesListBox.Location = new System.Drawing.Point(525, 363);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(355, 179);
            this.prizesListBox.TabIndex = 13;
            // 
            // deleteSelectedTeamButton
            // 
            this.deleteSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.deleteSelectedTeamButton.Location = new System.Drawing.Point(915, 258);
            this.deleteSelectedTeamButton.Name = "deleteSelectedTeamButton";
            this.deleteSelectedTeamButton.Size = new System.Drawing.Size(99, 42);
            this.deleteSelectedTeamButton.TabIndex = 14;
            this.deleteSelectedTeamButton.Text = "Delete Selected";
            this.deleteSelectedTeamButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTeamButton.Click += new System.EventHandler(this.DeleteSelectedTeamButton_Click);
            // 
            // deleteSelectedPrizesButton
            // 
            this.deleteSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(915, 500);
            this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
            this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(99, 42);
            this.deleteSelectedPrizesButton.TabIndex = 15;
            this.deleteSelectedPrizesButton.Text = "Delete Selected";
            this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPrizesButton.Click += new System.EventHandler(this.DeleteSelectedPrizesButton_Click);
            // 
            // createTourneButton
            // 
            this.createTourneButton.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.createTourneButton.Location = new System.Drawing.Point(379, 583);
            this.createTourneButton.Name = "createTourneButton";
            this.createTourneButton.Size = new System.Drawing.Size(329, 54);
            this.createTourneButton.TabIndex = 16;
            this.createTourneButton.Text = "Create Tournament";
            this.createTourneButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 656);
            this.Controls.Add(this.createTourneButton);
            this.Controls.Add(this.deleteSelectedPrizesButton);
            this.Controls.Add(this.deleteSelectedTeamButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.prizeslabel);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.teamListLabel);
            this.Controls.Add(this.prizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.createTeamLabel);
            this.Controls.Add(this.teamSelectLabel);
            this.Controls.Add(this.entryFeeBox);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.tournamentNameBox);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Tournament Creator";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox tournamentNameBox;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.TextBox entryFeeBox;
        private System.Windows.Forms.Label teamSelectLabel;
        private System.Windows.Forms.LinkLabel createTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button prizeButton;
        private System.Windows.Forms.Label teamListLabel;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Label prizeslabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button deleteSelectedTeamButton;
        private System.Windows.Forms.Button deleteSelectedPrizesButton;
        private System.Windows.Forms.Button createTourneButton;
    }
}