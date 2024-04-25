using System;
using System.Windows.Forms;
using BookingFlights.controllers;
namespace BookingFlights
{
    public partial class LogIn : Form
    {
        private LogInController logInController;
        public LogIn(LogInController logInController)
        {
            InitializeComponent();
            this.logInController = logInController;

        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            logInController.signUp();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameField.Text;
                string password = passwordField.Text;
                logInController.logIn(username, password);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}