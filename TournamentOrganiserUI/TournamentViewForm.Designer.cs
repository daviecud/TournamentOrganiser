namespace TournamentOrganiserUI
{
    partial class TournamentViewForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Label();
            this.team2heading = new System.Windows.Forms.Label();
            this.tournamentname = new System.Windows.Forms.Label();
            this.roundlabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedcheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.team1score = new System.Windows.Forms.Label();
            this.team1ScoreEntry = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.versuslabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(14, 30);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(220, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // team1
            // 
            this.team1.AutoSize = true;
            this.team1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.team1.Location = new System.Drawing.Point(719, 307);
            this.team1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(127, 50);
            this.team1.TabIndex = 1;
            this.team1.Text = "Team1";
            // 
            // team2heading
            // 
            this.team2heading.AutoSize = true;
            this.team2heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.team2heading.Location = new System.Drawing.Point(719, 469);
            this.team2heading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.team2heading.Name = "team2heading";
            this.team2heading.Size = new System.Drawing.Size(127, 50);
            this.team2heading.TabIndex = 2;
            this.team2heading.Text = "Team2";
            // 
            // tournamentname
            // 
            this.tournamentname.AutoSize = true;
            this.tournamentname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentname.Location = new System.Drawing.Point(235, 30);
            this.tournamentname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tournamentname.Name = "tournamentname";
            this.tournamentname.Size = new System.Drawing.Size(150, 50);
            this.tournamentname.TabIndex = 3;
            this.tournamentname.Text = "<none>";
            // 
            // roundlabel
            // 
            this.roundlabel.AutoSize = true;
            this.roundlabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundlabel.Location = new System.Drawing.Point(23, 111);
            this.roundlabel.Name = "roundlabel";
            this.roundlabel.Size = new System.Drawing.Size(113, 45);
            this.roundlabel.TabIndex = 4;
            this.roundlabel.Text = "Round";
            this.roundlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(154, 104);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(277, 58);
            this.roundDropDown.TabIndex = 5;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // unplayedcheckbox
            // 
            this.unplayedcheckbox.AutoSize = true;
            this.unplayedcheckbox.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedcheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedcheckbox.Location = new System.Drawing.Point(154, 191);
            this.unplayedcheckbox.Name = "unplayedcheckbox";
            this.unplayedcheckbox.Size = new System.Drawing.Size(163, 34);
            this.unplayedcheckbox.TabIndex = 6;
            this.unplayedcheckbox.Text = "Unplayed Only";
            this.unplayedcheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 50;
            this.matchupListBox.Location = new System.Drawing.Point(31, 253);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(400, 302);
            this.matchupListBox.TabIndex = 7;
            // 
            // team1score
            // 
            this.team1score.AutoSize = true;
            this.team1score.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.team1score.Location = new System.Drawing.Point(723, 357);
            this.team1score.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.team1score.Name = "team1score";
            this.team1score.Size = new System.Drawing.Size(62, 30);
            this.team1score.TabIndex = 8;
            this.team1score.Text = "Score";
            // 
            // team1ScoreEntry
            // 
            this.team1ScoreEntry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.team1ScoreEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team1ScoreEntry.Location = new System.Drawing.Point(797, 363);
            this.team1ScoreEntry.Multiline = true;
            this.team1ScoreEntry.Name = "team1ScoreEntry";
            this.team1ScoreEntry.Size = new System.Drawing.Size(100, 24);
            this.team1ScoreEntry.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(797, 525);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(723, 519);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Score";
            // 
            // versuslabel
            // 
            this.versuslabel.AutoSize = true;
            this.versuslabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versuslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.versuslabel.Location = new System.Drawing.Point(777, 426);
            this.versuslabel.Name = "versuslabel";
            this.versuslabel.Size = new System.Drawing.Size(72, 37);
            this.versuslabel.TabIndex = 12;
            this.versuslabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreButton.Location = new System.Drawing.Point(997, 426);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(161, 55);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versuslabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.team1ScoreEntry);
            this.Controls.Add(this.team1score);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedcheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundlabel);
            this.Controls.Add(this.tournamentname);
            this.Controls.Add(this.team2heading);
            this.Controls.Add(this.team1);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "TournamentViewForm";
            this.Text = "Tournament:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label team1;
        private System.Windows.Forms.Label team2heading;
        private System.Windows.Forms.Label tournamentname;
        private System.Windows.Forms.Label roundlabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedcheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label team1score;
        private System.Windows.Forms.TextBox team1ScoreEntry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versuslabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

