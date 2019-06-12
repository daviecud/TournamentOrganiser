namespace TournamentOrganiserUI
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.dropdownLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.createtournBUtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(479, 59);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(435, 50);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Tournament Dashboard";
            // 
            // dropdownLabel
            // 
            this.dropdownLabel.AutoSize = true;
            this.dropdownLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.dropdownLabel.Location = new System.Drawing.Point(523, 163);
            this.dropdownLabel.Name = "dropdownLabel";
            this.dropdownLabel.Size = new System.Drawing.Size(337, 38);
            this.dropdownLabel.TabIndex = 1;
            this.dropdownLabel.Text = "Load Existing Tournament";
            this.dropdownLabel.Click += new System.EventHandler(this.dropdownLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(426, 58);
            this.comboBox1.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.Coral;
            this.loadButton.Location = new System.Drawing.Point(503, 336);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(384, 49);
            this.loadButton.TabIndex = 18;
            this.loadButton.Text = "Load Tournament";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // createtournBUtton
            // 
            this.createtournBUtton.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.createtournBUtton.ForeColor = System.Drawing.Color.Coral;
            this.createtournBUtton.Location = new System.Drawing.Point(503, 441);
            this.createtournBUtton.Name = "createtournBUtton";
            this.createtournBUtton.Size = new System.Drawing.Size(384, 120);
            this.createtournBUtton.TabIndex = 19;
            this.createtournBUtton.Text = "Create Tournament";
            this.createtournBUtton.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 810);
            this.Controls.Add(this.createtournBUtton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dropdownLabel);
            this.Controls.Add(this.headingLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "DashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label dropdownLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button createtournBUtton;
    }
}