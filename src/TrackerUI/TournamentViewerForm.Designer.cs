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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.unplayedOnlyLabel = new System.Windows.Forms.CheckBox();
            this.matchUpListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValueLabel = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValueLabel = new System.Windows.Forms.TextBox();
            this.scoreTeamTwo = new System.Windows.Forms.Label();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.scoreButtonLabel = new System.Windows.Forms.Button();
            this.roundDropDownLabel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.headerLabel.Location = new System.Drawing.Point(58, 37);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.BackColor = System.Drawing.Color.Transparent;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentName.Location = new System.Drawing.Point(262, 37);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(156, 50);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<None>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundLabel.Location = new System.Drawing.Point(58, 126);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // unplayedOnlyLabel
            // 
            this.unplayedOnlyLabel.AutoSize = true;
            this.unplayedOnlyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.unplayedOnlyLabel.Location = new System.Drawing.Point(158, 169);
            this.unplayedOnlyLabel.Name = "unplayedOnlyLabel";
            this.unplayedOnlyLabel.Size = new System.Drawing.Size(209, 41);
            this.unplayedOnlyLabel.TabIndex = 4;
            this.unplayedOnlyLabel.Text = "Unplayed Only";
            this.unplayedOnlyLabel.UseVisualStyleBackColor = true;
            this.unplayedOnlyLabel.CheckedChanged += new System.EventHandler(this.unplayedOnlyLabel_CheckedChanged);
            // 
            // matchUpListBox
            // 
            this.matchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchUpListBox.FormattingEnabled = true;
            this.matchUpListBox.ItemHeight = 30;
            this.matchUpListBox.Location = new System.Drawing.Point(58, 216);
            this.matchUpListBox.Name = "matchUpListBox";
            this.matchUpListBox.Size = new System.Drawing.Size(320, 272);
            this.matchUpListBox.TabIndex = 5;
            this.matchUpListBox.SelectedIndexChanged += new System.EventHandler(this.matchUpListBox_SelectedIndexChanged_1);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamOneName.Location = new System.Drawing.Point(493, 126);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(164, 37);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<TeamOne>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(484, 180);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValueLabel
            // 
            this.teamOneScoreValueLabel.Location = new System.Drawing.Point(608, 182);
            this.teamOneScoreValueLabel.Name = "teamOneScoreValueLabel";
            this.teamOneScoreValueLabel.Size = new System.Drawing.Size(100, 35);
            this.teamOneScoreValueLabel.TabIndex = 8;
            // 
            // teamTwoScoreValueLabel
            // 
            this.teamTwoScoreValueLabel.Location = new System.Drawing.Point(608, 367);
            this.teamTwoScoreValueLabel.Name = "teamTwoScoreValueLabel";
            this.teamTwoScoreValueLabel.Size = new System.Drawing.Size(100, 35);
            this.teamTwoScoreValueLabel.TabIndex = 11;
            // 
            // scoreTeamTwo
            // 
            this.scoreTeamTwo.AutoSize = true;
            this.scoreTeamTwo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTeamTwo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.scoreTeamTwo.Location = new System.Drawing.Point(484, 365);
            this.scoreTeamTwo.Name = "scoreTeamTwo";
            this.scoreTeamTwo.Size = new System.Drawing.Size(82, 37);
            this.scoreTeamTwo.TabIndex = 10;
            this.scoreTeamTwo.Text = "Score";
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamTwoLabel.Location = new System.Drawing.Point(493, 311);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(164, 37);
            this.teamTwoLabel.TabIndex = 9;
            this.teamTwoLabel.Text = "<TeamTwo>";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vsLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.vsLabel.Location = new System.Drawing.Point(587, 256);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(70, 37);
            this.vsLabel.TabIndex = 12;
            this.vsLabel.Text = "-VS-";
            // 
            // scoreButtonLabel
            // 
            this.scoreButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreButtonLabel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scoreButtonLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButtonLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.scoreButtonLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButtonLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButtonLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.scoreButtonLabel.Location = new System.Drawing.Point(738, 256);
            this.scoreButtonLabel.Name = "scoreButtonLabel";
            this.scoreButtonLabel.Size = new System.Drawing.Size(143, 70);
            this.scoreButtonLabel.TabIndex = 13;
            this.scoreButtonLabel.Text = "Score";
            this.scoreButtonLabel.UseVisualStyleBackColor = false;
            this.scoreButtonLabel.Click += new System.EventHandler(this.scoreButtonLabel_Click);
            // 
            // roundDropDownLabel
            // 
            this.roundDropDownLabel.FormattingEnabled = true;
            this.roundDropDownLabel.Location = new System.Drawing.Point(158, 125);
            this.roundDropDownLabel.Name = "roundDropDownLabel";
            this.roundDropDownLabel.Size = new System.Drawing.Size(209, 38);
            this.roundDropDownLabel.TabIndex = 3;
            this.roundDropDownLabel.SelectedIndexChanged += new System.EventHandler(this.roundDropDownLabel_SelectedIndexChanged);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 559);
            this.Controls.Add(this.scoreButtonLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.teamTwoScoreValueLabel);
            this.Controls.Add(this.scoreTeamTwo);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.teamOneScoreValueLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchUpListBox);
            this.Controls.Add(this.unplayedOnlyLabel);
            this.Controls.Add(this.roundDropDownLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private CheckBox unplayedOnlyLabel;
        private ListBox matchUpListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValueLabel;
        private TextBox teamTwoScoreValueLabel;
        private Label scoreTeamTwo;
        private Label teamTwoLabel;
        private Label vsLabel;
        private Button scoreButtonLabel;
        private ComboBox roundDropDownLabel;
    }

}