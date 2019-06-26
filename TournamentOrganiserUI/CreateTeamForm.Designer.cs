namespace TournamentOrganiserUI
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
            this.headinglabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.selectMemberLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.memberDropDown = new System.Windows.Forms.ComboBox();
            this.addmemberLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.telNumberBox = new System.Windows.Forms.TextBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headinglabel
            // 
            this.headinglabel.AutoSize = true;
            this.headinglabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglabel.ForeColor = System.Drawing.Color.Coral;
            this.headinglabel.Location = new System.Drawing.Point(13, 27);
            this.headinglabel.Name = "headinglabel";
            this.headinglabel.Size = new System.Drawing.Size(237, 50);
            this.headinglabel.TabIndex = 0;
            this.headinglabel.Text = "Create Team";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.teamLabel.ForeColor = System.Drawing.Color.Coral;
            this.teamLabel.Location = new System.Drawing.Point(45, 95);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(170, 38);
            this.teamLabel.TabIndex = 1;
            this.teamLabel.Text = "Team Name:";
            // 
            // teamNameText
            // 
            this.teamNameText.Location = new System.Drawing.Point(52, 152);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(509, 20);
            this.teamNameText.TabIndex = 2;
            // 
            // selectMemberLabel
            // 
            this.selectMemberLabel.AutoSize = true;
            this.selectMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.selectMemberLabel.ForeColor = System.Drawing.Color.Coral;
            this.selectMemberLabel.Location = new System.Drawing.Point(45, 197);
            this.selectMemberLabel.Name = "selectMemberLabel";
            this.selectMemberLabel.Size = new System.Drawing.Size(283, 38);
            this.selectMemberLabel.TabIndex = 3;
            this.selectMemberLabel.Text = "Select Team Member:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(213, 462);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(349, 20);
            this.firstNameBox.TabIndex = 4;
            // 
            // memberDropDown
            // 
            this.memberDropDown.FormattingEnabled = true;
            this.memberDropDown.Location = new System.Drawing.Point(52, 250);
            this.memberDropDown.Name = "memberDropDown";
            this.memberDropDown.Size = new System.Drawing.Size(508, 21);
            this.memberDropDown.TabIndex = 5;
            // 
            // addmemberLabel
            // 
            this.addmemberLabel.AutoSize = true;
            this.addmemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.addmemberLabel.ForeColor = System.Drawing.Color.Coral;
            this.addmemberLabel.Location = new System.Drawing.Point(45, 391);
            this.addmemberLabel.Name = "addmemberLabel";
            this.addmemberLabel.Size = new System.Drawing.Size(250, 38);
            this.addmemberLabel.TabIndex = 6;
            this.addmemberLabel.Text = "Add New Member:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI", 16.75F);
            this.firstnameLabel.ForeColor = System.Drawing.Color.Coral;
            this.firstnameLabel.Location = new System.Drawing.Point(46, 452);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(119, 31);
            this.firstnameLabel.TabIndex = 7;
            this.firstnameLabel.Text = "Firstname:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI", 16.75F);
            this.lastnameLabel.ForeColor = System.Drawing.Color.Coral;
            this.lastnameLabel.Location = new System.Drawing.Point(47, 497);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(117, 31);
            this.lastnameLabel.TabIndex = 8;
            this.lastnameLabel.Text = "Lastname:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 16.75F);
            this.emailLabel.ForeColor = System.Drawing.Color.Coral;
            this.emailLabel.Location = new System.Drawing.Point(47, 543);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(75, 31);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email:";
            // 
            // telNumberLabel
            // 
            this.telNumberLabel.AutoSize = true;
            this.telNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16.75F);
            this.telNumberLabel.ForeColor = System.Drawing.Color.Coral;
            this.telNumberLabel.Location = new System.Drawing.Point(47, 590);
            this.telNumberLabel.Name = "telNumberLabel";
            this.telNumberLabel.Size = new System.Drawing.Size(91, 31);
            this.telNumberLabel.TabIndex = 10;
            this.telNumberLabel.Text = "Mobile:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.75F);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(15, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 11;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(213, 508);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(349, 20);
            this.lastNameBox.TabIndex = 12;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(213, 553);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(349, 20);
            this.emailBox.TabIndex = 13;
            // 
            // telNumberBox
            // 
            this.telNumberBox.Location = new System.Drawing.Point(212, 600);
            this.telNumberBox.Name = "telNumberBox";
            this.telNumberBox.Size = new System.Drawing.Size(349, 20);
            this.telNumberBox.TabIndex = 14;
            // 
            // createMemberButton
            // 
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemberButton.ForeColor = System.Drawing.Color.Coral;
            this.createMemberButton.Location = new System.Drawing.Point(231, 651);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(154, 49);
            this.createMemberButton.TabIndex = 15;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 21;
            this.playersListBox.Location = new System.Drawing.Point(623, 152);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(487, 466);
            this.playersListBox.TabIndex = 16;
            // 
            // createTeamButton
            // 
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.Coral;
            this.createTeamButton.Location = new System.Drawing.Point(679, 651);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(384, 49);
            this.createTeamButton.TabIndex = 17;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.Coral;
            this.addMemberButton.Location = new System.Drawing.Point(231, 298);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(154, 49);
            this.addMemberButton.TabIndex = 18;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlayerButton.ForeColor = System.Drawing.Color.Coral;
            this.deletePlayerButton.Location = new System.Drawing.Point(1146, 298);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(154, 49);
            this.deletePlayerButton.TabIndex = 19;
            this.deletePlayerButton.Text = "Delete Player";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            this.deletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 749);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.createMemberButton);
            this.Controls.Add(this.telNumberBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.addmemberLabel);
            this.Controls.Add(this.memberDropDown);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.selectMemberLabel);
            this.Controls.Add(this.teamNameText);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.headinglabel);
            this.Name = "CreateTeamForm";
            this.Text = "Team Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.Label selectMemberLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.ComboBox memberDropDown;
        private System.Windows.Forms.Label addmemberLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox telNumberBox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button deletePlayerButton;
    }
}