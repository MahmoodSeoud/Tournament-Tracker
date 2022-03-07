using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Model;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.pricePercentageValue = new System.Windows.Forms.TextBox();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPrizeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeLabel.Location = new System.Drawing.Point(50, 37);
            this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(209, 50);
            this.createPrizeLabel.TabIndex = 13;
            this.createPrizeLabel.Text = "Create Prize";
            this.createPrizeLabel.Click += new System.EventHandler(this.createTournamentLabel_Click);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.placeNumberLabel.Location = new System.Drawing.Point(69, 106);
            this.placeNumberLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(183, 37);
            this.placeNumberLabel.TabIndex = 14;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.placeNameLabel.Location = new System.Drawing.Point(69, 158);
            this.placeNameLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
            this.placeNameLabel.TabIndex = 15;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.BackColor = System.Drawing.Color.Transparent;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizePercentageLabel.Location = new System.Drawing.Point(69, 323);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(212, 37);
            this.prizePercentageLabel.TabIndex = 16;
            this.prizePercentageLabel.Text = "Price Percentage";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizeAmountLabel.Location = new System.Drawing.Point(69, 210);
            this.prizeAmountLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(176, 37);
            this.prizeAmountLabel.TabIndex = 17;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.Transparent;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.orLabel.Location = new System.Drawing.Point(203, 271);
            this.orLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(78, 37);
            this.orLabel.TabIndex = 18;
            this.orLabel.Text = "- or -";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(299, 106);
            this.placeNumberValue.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(185, 35);
            this.placeNumberValue.TabIndex = 19;
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(299, 158);
            this.placeNameValue.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(185, 35);
            this.placeNameValue.TabIndex = 20;
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(299, 210);
            this.prizeAmountValue.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(185, 35);
            this.prizeAmountValue.TabIndex = 21;
            this.prizeAmountValue.Text = "0";
            this.prizeAmountValue.TextChanged += new System.EventHandler(this.prizeAmountValue_TextChanged);
            // 
            // pricePercentageValue
            // 
            this.pricePercentageValue.Location = new System.Drawing.Point(299, 323);
            this.pricePercentageValue.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.pricePercentageValue.Name = "pricePercentageValue";
            this.pricePercentageValue.Size = new System.Drawing.Size(185, 35);
            this.pricePercentageValue.TabIndex = 22;
            this.pricePercentageValue.Text = "0";
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
            this.createPrizeButton.Location = new System.Drawing.Point(175, 387);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(236, 85);
            this.createPrizeButton.TabIndex = 31;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 485);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.pricePercentageValue);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      




        #endregion

        private void createTournamentLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Label createPrizeLabel;
        private Label placeNumberLabel;
        private Label placeNameLabel;
        private Label prizePercentageLabel;
        private Label prizeAmountLabel;
        private Label orLabel;
        private TextBox placeNameValue;
        private TextBox prizeAmountValue;
        private TextBox pricePercentageValue;
        private Button createPrizeButton;
        private TextBox placeNumberValue;
    }
}