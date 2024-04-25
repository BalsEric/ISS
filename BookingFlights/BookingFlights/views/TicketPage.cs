using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookingFlights;
using BookingFlights.Windows.Forms;
using BookingFlights.controllers;
using BookingFlights.Model;

namespace BookingFlights
{
    public partial class TicketPage : Form
    {
        private TicketsPageController ticketsPageController;
        public TicketPage(TicketsPageController ticketsPageController)
        {
            InitializeComponent();
            this.ticketsPageController = ticketsPageController;
        }
        
        public void initializeTable(Dictionary<Ticket, Flight> tickets)
        {
            dataGridView1.Rows.Clear();
            this.dataGridView1.ColumnCount = 6;
            this.dataGridView1.Columns[0].Name = "DEPARTURE";
            this.dataGridView1.Columns[1].Name = "ARRIVAL";
            this.dataGridView1.Columns[2].Name = "DATE";
            this.dataGridView1.Columns[3].Name = "NAME";
            this.dataGridView1.Columns[4].Name = "CNP";
            this.dataGridView1.Columns[5].Name = "DOB";
            foreach (var ticketFlg in tickets)
            {
                var ticket = ticketFlg.Key;
                var flight = ticketFlg.Value;
                var from = flight.from;
                var to = flight.to;
                var date = flight.date;
                var name = ticket.lastname + " " + ticket.firstname;
                var cnp = ticket.cnp;
                var dob = ticket.birthday;
                string[] row = { from, to, date, name, cnp, dob };

                dataGridView1.Rows.Add(row);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = this.dataGridView1.SelectedCells[0].RowIndex;
                var row = dataGridView1.Rows[selectedrowindex];
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("from", Convert.ToString(row.Cells["DEPARTURE"].Value));
                param.Add("to", Convert.ToString(row.Cells["ARRIVAL"].Value));
                param.Add("date", Convert.ToString(row.Cells["DATE"].Value));
                param.Add("name", Convert.ToString(row.Cells["NAME"].Value));
                param.Add("cnp", Convert.ToString(row.Cells["CNP"].Value));
                param.Add("dob", Convert.ToString(row.Cells["DOB"].Value));

                Dictionary<string, string> newValues = new Dictionary<string, string>();
                newValues.Add("lname", lnameText.Text);
                newValues.Add("fname", fnameText.Text);
                newValues.Add("cnp", cnpText.Text);
                newValues.Add("dob", birthDatePicker.Value.Date.ToString());
                ticketsPageController.modifyReservation(param, newValues);
                MessageBox.Show("Modify request sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = this.dataGridView1.SelectedCells[0].RowIndex;
                var row = dataGridView1.Rows[selectedrowindex];
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("from",Convert.ToString(row.Cells["DEPARTURE"].Value));
                param.Add("to", Convert.ToString(row.Cells["ARRIVAL"].Value));
                param.Add("date",Convert.ToString(row.Cells["DATE"].Value));
                param.Add("name", Convert.ToString(row.Cells["NAME"].Value));
                param.Add("cnp",Convert.ToString(row.Cells["CNP"].Value));
                param.Add("dob",Convert.ToString(row.Cells["DOB"].Value));
                ticketsPageController.cancelReservation(param);
                MessageBox.Show("Cancel request sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}