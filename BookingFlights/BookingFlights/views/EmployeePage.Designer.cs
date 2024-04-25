using System.ComponentModel;

namespace Flights
{
    partial class EmployeePage
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
            allTicketsTabel = new DataGridView();
            requestsTabel = new DataGridView();
            signOutLabel = new Label();
            deleteButton = new Button();
            modifyButton = new Button();
            ((ISupportInitialize)allTicketsTabel).BeginInit();
            ((ISupportInitialize)requestsTabel).BeginInit();
            SuspendLayout();
            // 
            // allTicketsTabel
            // 
            allTicketsTabel.BackgroundColor = SystemColors.GradientInactiveCaption;
            allTicketsTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allTicketsTabel.Location = new Point(31, 78);
            allTicketsTabel.Margin = new Padding(3, 4, 3, 4);
            allTicketsTabel.Name = "allTicketsTabel";
            allTicketsTabel.RowHeadersWidth = 51;
            allTicketsTabel.RowTemplate.Height = 24;
            allTicketsTabel.Size = new Size(495, 416);
            allTicketsTabel.TabIndex = 0;
            allTicketsTabel.CellContentClick += allTicketsTabel_CellContentClick;
            // 
            // requestsTabel
            // 
            requestsTabel.BackgroundColor = SystemColors.GradientInactiveCaption;
            requestsTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsTabel.Location = new Point(549, 78);
            requestsTabel.Margin = new Padding(3, 4, 3, 4);
            requestsTabel.Name = "requestsTabel";
            requestsTabel.RowHeadersWidth = 51;
            requestsTabel.RowTemplate.Height = 24;
            requestsTabel.Size = new Size(227, 282);
            requestsTabel.TabIndex = 1;
            requestsTabel.CellContentClick += requestsTabel_CellContentClick;
            // 
            // signOutLabel
            // 
            signOutLabel.Location = new Point(702, 30);
            signOutLabel.Name = "signOutLabel";
            signOutLabel.Size = new Size(100, 29);
            signOutLabel.TabIndex = 2;
            signOutLabel.Text = "Sign Out";
            signOutLabel.Click += signOutLabel_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(600, 452);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(134, 42);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "DELETE TICKET";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(600, 383);
            modifyButton.Margin = new Padding(3, 4, 3, 4);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(134, 42);
            modifyButton.TabIndex = 4;
            modifyButton.Text = "MODIFY TICKET";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(802, 572);
            Controls.Add(modifyButton);
            Controls.Add(deleteButton);
            Controls.Add(signOutLabel);
            Controls.Add(requestsTabel);
            Controls.Add(allTicketsTabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeePage";
            Text = "EmployeePage";
            ((ISupportInitialize)allTicketsTabel).EndInit();
            ((ISupportInitialize)requestsTabel).EndInit();
            ResumeLayout(false);
        }

        private Button deleteButton;
        private Button modifyButton;

        private Label signOutLabel;

        private DataGridView requestsTabel;

        private DataGridView allTicketsTabel;

        #endregion
    }
}