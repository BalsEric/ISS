using System;
using System.Windows.Forms;
using BookingFlights.controllers;

namespace BookingFlights
{
    public partial class ReservationPage : Form
    {
        private ReservationPageController reservationPageController;
        public ReservationPage(ReservationPageController reservationPageController)
        {
            InitializeComponent();
            this.reservationPageController = reservationPageController;
        }
        

        private void reserveButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                var lastName = lastNameText.Text;
                var firstName = firstNameText.Text;
                var cnp = cnpText.Text;
                var birthDate = bithDatePicker.Value.Date;
                var passangerNo = reservationPageController.makeReservation(lastName, firstName, cnp, birthDate);
                if (passangerNo != 0)
                {
                    MessageBox.Show("You've made one reservation, you have " + passangerNo.ToString() +
                                    " more to make.");
                }
                else
                {
                    MessageBox.Show("All reservations are made!");
                    this.Hide();
                }
                lastNameText.Clear();
                firstNameText.Clear();
                cnpText.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}