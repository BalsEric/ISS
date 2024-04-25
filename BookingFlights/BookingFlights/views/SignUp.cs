using System;
using System.Windows.Forms;
using BookingFlights.controllers;

namespace BookingFlights
{
    public partial class SignUp : Form
    {
        Service.Service service;
        private SignUpController signUpController;
        public SignUp(SignUpController signUpController)
        {
            InitializeComponent();
            // this.service = service;
            this.signUpController = signUpController;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var typeUser = type.Text;
                var name = nameField.Text;
                var username = usernameField.Text;
                var password = passwordField.Text;
                var admin = adminPassword.Text;
                signUpController.signUp(typeUser, name, username, password, admin);
                MessageBox.Show("You signed up successfully!");
                this.Hide();
                signUpController.showLogIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}