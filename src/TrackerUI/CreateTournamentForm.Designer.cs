namespace TrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.teamPlayerLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.removePrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(62, 89);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 2;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.ItemHeight = 30;
            this.selectTeamDropdown.Location = new System.Drawing.Point(65, 314);
            this.selectTeamDropdown.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(296, 38);
            this.selectTeamDropdown.TabIndex = 5;
            this.selectTeamDropdown.SelectedIndexChanged += new System.EventHandler(this.selectTeamDropdown_SelectedIndexChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(65, 201);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 6;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.loadExistingTournamentLabel_Click);
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.BackColor = System.Drawing.Color.Transparent;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTournamentLabel.Location = new System.Drawing.Point(31, 29);
            this.createTournamentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(317, 50);
            this.createTournamentLabel.TabIndex = 12;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(65, 132);
            this.tournamentNameValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(296, 35);
            this.tournamentNameValue.TabIndex = 14;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(200, 201);
            this.entryFeeValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(98, 35);
            this.entryFeeValue.TabIndex = 15;
            this.entryFeeValue.Text = "0";
            // 
            // teamPlayerLabel
            // 
            this.teamPlayerLabel.AutoSize = true;
            this.teamPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamPlayerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamPlayerLabel.Location = new System.Drawing.Point(472, 68);
            this.teamPlayerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teamPlayerLabel.Name = "teamPlayerLabel";
            this.teamPlayerLabel.Size = new System.Drawing.Size(187, 37);
            this.teamPlayerLabel.TabIndex = 16;
            this.teamPlayerLabel.Text = "Team / Players";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizesLabel.Location = new System.Drawing.Point(472, 325);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(85, 37);
            this.prizesLabel.TabIndex = 17;
            this.prizesLabel.Text = "Prizes";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(65, 275);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 18;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 30;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(472, 108);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(381, 182);
            this.tournamentTeamsListBox.TabIndex = 23;
            this.tournamentTeamsListBox.SelectedIndexChanged += new System.EventHandler(this.tournamentTeamsListBox_SelectedIndexChanged);
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(472, 365);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(381, 182);
            this.prizesListBox.TabIndex = 24;
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.Transparent;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.addTeamButton.Location = new System.Drawing.Point(105, 376);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(193, 50);
            this.addTeamButton.TabIndex = 25;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.Transparent;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(105, 449);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(193, 50);
            this.createPrizeButton.TabIndex = 26;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(247, 282);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLink.TabIndex = 27;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackColor = System.Drawing.Color.Transparent;
            this.removeSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.removeSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.removeSelectedButton.Location = new System.Drawing.Point(884, 163);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(140, 75);
            this.removeSelectedButton.TabIndex = 28;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = false;
            this.removeSelectedButton.Click += new System.EventHandler(this.deletedSelectedButton_Click);
            // 
            // removePrizeButton
            // 
            this.removePrizeButton.BackColor = System.Drawing.Color.Transparent;
            this.removePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.removePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removePrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.removePrizeButton.Location = new System.Drawing.Point(884, 420);
            this.removePrizeButton.Name = "removePrizeButton";
            this.removePrizeButton.Size = new System.Drawing.Size(140, 75);
            this.removePrizeButton.TabIndex = 29;
            this.removePrizeButton.Text = "Deleted Selected";
            this.removePrizeButton.UseVisualStyleBackColor = false;
            this.removePrizeButton.Click += new System.EventHandler(this.removePrizeButton_click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.Transparent;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTournamentButton.Location = new System.Drawing.Point(417, 578);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(236, 85);
            this.createTournamentButton.TabIndex = 30;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 685);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removePrizeButton);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamPlayerLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.createTournamentLabel);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.tournamentNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void loadExistingTournamentLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

 
       internal class createTournamentForm
        {
        }
    

    #endregion

    private Label tournamentNameLabel;
        private ComboBox selectTeamDropdown;
        private Label entryFeeLabel;
        private Label createTournamentLabel;
        private TextBox tournamentNameValue;
        private TextBox entryFeeValue;
        private Label teamPlayerLabel;
        private Label prizesLabel;
        private Label selectTeamLabel;
        private ListBox tournamentTeamsListBox;
        private ListBox prizesListBox;
        private Button addTeamButton;
        private Button createPrizeButton;
        private LinkLabel createNewTeamLink;
        private Button removeSelectedButton;
        private Button removePrizeButton;
        private Button createTournamentButton;
    }
}