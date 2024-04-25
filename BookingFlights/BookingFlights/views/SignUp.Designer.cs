using System.ComponentModel;

namespace Flights
{
    partial class SignUp
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
            label1 = new Label();
            type = new ComboBox();
            nameField = new TextBox();
            usernameField = new TextBox();
            passwordField = new TextBox();
            registerButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            adminPassword = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(188, 49);
            label1.Name = "label1";
            label1.Size = new Size(164, 54);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // type
            // 
            type.AllowDrop = true;
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Client", "Employee" });
            type.Location = new Point(174, 144);
            type.Margin = new Padding(3, 4, 3, 4);
            type.Name = "type";
            type.Size = new Size(222, 28);
            type.TabIndex = 1;
            // 
            // nameField
            // 
            nameField.Location = new Point(174, 194);
            nameField.Margin = new Padding(3, 4, 3, 4);
            nameField.Name = "nameField";
            nameField.Size = new Size(222, 27);
            nameField.TabIndex = 2;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(174, 246);
            usernameField.Margin = new Padding(3, 4, 3, 4);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(222, 27);
            usernameField.TabIndex = 3;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(174, 300);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(222, 27);
            passwordField.TabIndex = 4;
            passwordField.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(211, 418);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 38);
            registerButton.TabIndex = 5;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label2
            // 
            label2.Location = new Point(94, 148);
            label2.Name = "label2";
            label2.Size = new Size(82, 29);
            label2.TabIndex = 6;
            label2.Text = "Sign in as:";
            // 
            // label3
            // 
            label3.Location = new Point(118, 194);
            label3.Name = "label3";
            label3.Size = new Size(50, 29);
            label3.TabIndex = 7;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.Location = new Point(90, 246);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 8;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.Location = new Point(94, 299);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 9;
            label5.Text = "Password:";
            // 
            // adminPassword
            // 
            adminPassword.Location = new Point(174, 356);
            adminPassword.Margin = new Padding(3, 4, 3, 4);
            adminPassword.Name = "adminPassword";
            adminPassword.Size = new Size(222, 27);
            adminPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.Location = new Point(53, 355);
            label6.Name = "label6";
            label6.Size = new Size(123, 29);
            label6.TabIndex = 11;
            label6.Text = "Admin password:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(519, 504);
            Controls.Add(label6);
            Controls.Add(adminPassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(registerButton);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(nameField);
            Controls.Add(type);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox adminPassword;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        protected internal System.Windows.Forms.ComboBox type;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}