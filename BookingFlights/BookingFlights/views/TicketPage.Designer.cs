using System.ComponentModel;

namespace Flights
{
    partial class TicketPage
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
            dataGridView1 = new DataGridView();
            lnameText = new TextBox();
            fnameText = new TextBox();
            cnpText = new TextBox();
            birthDatePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            modifyButton = new Button();
            cancelButton = new Button();
            label6 = new Label();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 86);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(301, 375);
            dataGridView1.TabIndex = 0;
            // 
            // lnameText
            // 
            lnameText.Location = new Point(496, 158);
            lnameText.Margin = new Padding(3, 4, 3, 4);
            lnameText.Name = "lnameText";
            lnameText.Size = new Size(221, 27);
            lnameText.TabIndex = 1;
            // 
            // fnameText
            // 
            fnameText.Location = new Point(496, 220);
            fnameText.Margin = new Padding(3, 4, 3, 4);
            fnameText.Name = "fnameText";
            fnameText.Size = new Size(221, 27);
            fnameText.TabIndex = 2;
            // 
            // cnpText
            // 
            cnpText.Location = new Point(496, 280);
            cnpText.Margin = new Padding(3, 4, 3, 4);
            cnpText.Name = "cnpText";
            cnpText.Size = new Size(221, 27);
            cnpText.TabIndex = 3;
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(496, 336);
            birthDatePicker.Margin = new Padding(3, 4, 3, 4);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(221, 27);
            birthDatePicker.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(411, 156);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 5;
            label1.Text = "Last name:";
            // 
            // label2
            // 
            label2.Location = new Point(409, 219);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 6;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.Location = new Point(443, 279);
            label3.Name = "label3";
            label3.Size = new Size(47, 29);
            label3.TabIndex = 7;
            label3.Text = "CNP:";
            // 
            // label4
            // 
            label4.Location = new Point(411, 336);
            label4.Name = "label4";
            label4.Size = new Size(79, 29);
            label4.TabIndex = 8;
            label4.Text = "Birth date:";
            // 
            // label5
            // 
            label5.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(62, 36);
            label5.Name = "label5";
            label5.Size = new Size(153, 29);
            label5.TabIndex = 9;
            label5.Text = "YOUR TICKETS";
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(496, 429);
            modifyButton.Margin = new Padding(3, 4, 3, 4);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(156, 58);
            modifyButton.TabIndex = 10;
            modifyButton.Text = "REQUEST TO MODIFY TICKETS";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(122, 496);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(181, 52);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "REQUEST TO CANCEL RESERVATION";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click_1;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(472, 59);
            label6.Name = "label6";
            label6.Size = new Size(203, 60);
            label6.TabIndex = 12;
            label6.Text = "Fill with the informations you want to modify";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // TicketPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(754, 632);
            Controls.Add(label6);
            Controls.Add(cancelButton);
            Controls.Add(modifyButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(birthDatePicker);
            Controls.Add(cnpText);
            Controls.Add(fnameText);
            Controls.Add(lnameText);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicketPage";
            Text = "TicketPage";
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button modifyButton;
        private Button cancelButton;
        private Label label6;

        private TextBox lnameText;
        private TextBox fnameText;
        private TextBox cnpText;
        private DateTimePicker birthDatePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        private DataGridView dataGridView1;

        #endregion
    }
}