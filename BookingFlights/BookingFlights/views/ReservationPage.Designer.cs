using System.ComponentModel;

namespace Flights
{
    partial class ReservationPage
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
            lastNameText = new TextBox();
            firstNameText = new TextBox();
            cnpText = new TextBox();
            label1 = new Label();
            bithDatePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            reserveButton = new Button();
            SuspendLayout();
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(199, 171);
            lastNameText.Margin = new Padding(3, 4, 3, 4);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(226, 27);
            lastNameText.TabIndex = 0;
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(199, 235);
            firstNameText.Margin = new Padding(3, 4, 3, 4);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(226, 27);
            firstNameText.TabIndex = 1;
            // 
            // cnpText
            // 
            cnpText.Location = new Point(199, 294);
            cnpText.Margin = new Padding(3, 4, 3, 4);
            cnpText.Name = "cnpText";
            cnpText.Size = new Size(226, 27);
            cnpText.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(103, 68);
            label1.Name = "label1";
            label1.Size = new Size(353, 40);
            label1.TabIndex = 3;
            label1.Text = "MAKE YOUR RESERVATION NOW";
            // 
            // bithDatePicker
            // 
            bithDatePicker.Location = new Point(199, 361);
            bithDatePicker.Margin = new Padding(3, 4, 3, 4);
            bithDatePicker.Name = "bithDatePicker";
            bithDatePicker.Size = new Size(226, 27);
            bithDatePicker.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(113, 175);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 5;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.Location = new Point(113, 235);
            label3.Name = "label3";
            label3.Size = new Size(87, 29);
            label3.TabIndex = 6;
            label3.Text = "First name:";
            // 
            // label4
            // 
            label4.Location = new Point(150, 292);
            label4.Name = "label4";
            label4.Size = new Size(43, 29);
            label4.TabIndex = 7;
            label4.Text = "CNP:";
            // 
            // label5
            // 
            label5.Location = new Point(119, 360);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 8;
            label5.Text = "Birth date:";
            // 
            // reserveButton
            // 
            reserveButton.Location = new Point(184, 450);
            reserveButton.Margin = new Padding(3, 4, 3, 4);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(172, 41);
            reserveButton.TabIndex = 9;
            reserveButton.Text = "RESERVE ONE TICKET";
            reserveButton.UseVisualStyleBackColor = true;
            reserveButton.Click += reserveButton_Click_1;
            // 
            // ReservationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(537, 591);
            Controls.Add(reserveButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bithDatePicker);
            Controls.Add(label1);
            Controls.Add(cnpText);
            Controls.Add(firstNameText);
            Controls.Add(lastNameText);
            Location = new Point(15, 15);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationPage";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label5;
        private Button reserveButton;

        private Label label2;
        private Label label3;
        private Label label4;

        private DateTimePicker bithDatePicker;

        private TextBox lastNameText;
        private TextBox firstNameText;
        private TextBox cnpText;
        private Label label1;

        #endregion
    }
}