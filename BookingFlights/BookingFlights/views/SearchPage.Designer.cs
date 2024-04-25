using System.ComponentModel;

namespace Flights
{
    partial class SearchPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.passangerField = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flightsTable = new System.Windows.Forms.DataGridView();
            this.showTicketsButton = new System.Windows.Forms.Button();
            this.fromText = new System.Windows.Forms.Label();
            this.toText = new System.Windows.Forms.Label();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.reserveButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.signOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // passangerField
            // 
            this.passangerField.Location = new System.Drawing.Point(479, 82);
            this.passangerField.Name = "passangerField";
            this.passangerField.Size = new System.Drawing.Size(100, 22);
            this.passangerField.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(436, 43);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(228, 22);
            this.datePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(386, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passangers:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(386, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date:";
            // 
            // flightsTable
            // 
            this.flightsTable.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flightsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsTable.Location = new System.Drawing.Point(91, 160);
            this.flightsTable.Name = "flightsTable";
            this.flightsTable.RowTemplate.Height = 24;
            this.flightsTable.Size = new System.Drawing.Size(627, 188);
            this.flightsTable.TabIndex = 10;
            this.flightsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightsTable_CellContentClick);
            // 
            // showTicketsButton
            // 
            this.showTicketsButton.Location = new System.Drawing.Point(597, 371);
            this.showTicketsButton.Name = "showTicketsButton";
            this.showTicketsButton.Size = new System.Drawing.Size(121, 29);
            this.showTicketsButton.TabIndex = 12;
            this.showTicketsButton.Text = "SHOW TICKETS";
            this.showTicketsButton.UseVisualStyleBackColor = true;
            this.showTicketsButton.Click += new System.EventHandler(this.showTicketsButton_Click);
            // 
            // fromText
            // 
            this.fromText.Location = new System.Drawing.Point(79, 50);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(46, 23);
            this.fromText.TabIndex = 13;
            this.fromText.Text = "From:";
            // 
            // toText
            // 
            this.toText.Location = new System.Drawing.Point(91, 90);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(34, 23);
            this.toText.TabIndex = 14;
            this.toText.Text = "To:";
            // 
            // fromComboBox
            // 
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Location = new System.Drawing.Point(121, 45);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(204, 24);
            this.fromComboBox.TabIndex = 15;
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(121, 85);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(204, 24);
            this.toComboBox.TabIndex = 16;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(91, 371);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(84, 29);
            this.reserveButton.TabIndex = 17;
            this.reserveButton.Text = "RESERVE";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(643, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 26);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // signOutLabel
            // 
            this.signOutLabel.Location = new System.Drawing.Point(692, 18);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(100, 23);
            this.signOutLabel.TabIndex = 19;
            this.signOutLabel.Text = "Sign Out";
            this.signOutLabel.Click += new System.EventHandler(this.signOutLabel_Click);
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 466);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.showTicketsButton);
            this.Controls.Add(this.flightsTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.passangerField);
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            ((System.ComponentModel.ISupportInitialize)(this.flightsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label signOutLabel;

        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Button reserveButton;

        private System.Windows.Forms.Label fromText;

        private System.Windows.Forms.Button showTicketsButton;

        private System.Windows.Forms.DataGridView flightsTable;

        private System.Windows.Forms.TextBox passangerField;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label toText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}