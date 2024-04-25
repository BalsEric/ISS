namespace Flights
{
    partial class LogIn
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
            usernameField = new TextBox();
            passwordField = new TextBox();
            Username = new Label();
            Password = new Label();
            logInButton = new Button();
            label1 = new Label();
            signUpLabel = new Label();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Location = new Point(183, 178);
            usernameField.Margin = new Padding(3, 4, 3, 4);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(236, 27);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(183, 242);
            passwordField.Margin = new Padding(3, 4, 3, 4);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(236, 27);
            passwordField.TabIndex = 1;
            passwordField.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.Location = new Point(87, 181);
            Username.Name = "Username";
            Username.Size = new Size(79, 29);
            Username.TabIndex = 2;
            Username.Text = "Username:";
            // 
            // Password
            // 
            Password.Location = new Point(87, 246);
            Password.Name = "Password";
            Password.Size = new Size(79, 29);
            Password.TabIndex = 3;
            Password.Text = "Password:";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(183, 321);
            logInButton.Margin = new Padding(3, 4, 3, 4);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(75, 36);
            logInButton.TabIndex = 4;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(195, 54);
            label1.Name = "label1";
            label1.Size = new Size(123, 53);
            label1.TabIndex = 5;
            label1.Text = "LOG IN PAGE";
            // 
            // signUpLabel
            // 
            signUpLabel.Location = new Point(284, 329);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(100, 29);
            signUpLabel.TabIndex = 6;
            signUpLabel.Text = "Sign Up";
            signUpLabel.Click += signUpLabel_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(500, 436);
            Controls.Add(signUpLabel);
            Controls.Add(label1);
            Controls.Add(logInButton);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogIn";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label signUpLabel;

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;

        #endregion
    }
}