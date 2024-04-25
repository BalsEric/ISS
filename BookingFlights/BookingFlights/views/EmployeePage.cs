using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookingFlights.controllers;
using BookingFlights.Model;

namespace BookingFlights
{
    public partial class EmployeePage : Form
    {
        private EmployeePageController employeePageController;
        public EmployeePage(EmployeePageController employeePageController)
        {
            InitializeComponent();
            this.employeePageController = employeePageController;
        }

        public void initializeTicketsTable(Dictionary<Ticket, Flight> tickets)
        {
            allTicketsTabel.Rows.Clear();
            this.allTicketsTabel.ColumnCount = 6;
            this.allTicketsTabel.Columns[0].Name = "TICKET ID";
            this.allTicketsTabel.Columns[1].Name = "NAME";
            this.allTicketsTabel.Columns[2].Name = "CNP";
            this.allTicketsTabel.Columns[3].Name = "DOB";
            this.allTicketsTabel.Columns[4].Name = "FLIGHT ID";
            foreach (var ticketFlg in tickets)
            {
                var ticket = ticketFlg.Key;
                var flight = ticketFlg.Value;
                var id = ticket.id.ToString();
                var name = ticket.lastname + " " + ticket.firstname;
                var cnp = ticket.cnp;
                var dob = ticket.birthday;
                var flgID = flight.id.ToString();
                string[] row = { id, name, cnp, dob, flgID };

                allTicketsTabel.Rows.Add(row);
            }
        }

        public void initializeRequestTabel(List<Request> requests)
        {
            requestsTabel.Rows.Clear();
            this.requestsTabel.ColumnCount = 3;
            this.requestsTabel.Columns[0].Name = "TYPE";
            this.requestsTabel.Columns[1].Name = "TICKET ID";

            string type = "";
            foreach (var request in requests)
            {
                if (request.type == 0)
                {
                    type = "MODIFY";
                }
                else
                {
                    type = "CANCEL";
                }

                var ticket = request.ticketid;
                string[] row = { type, ticket.ToString() };

                requestsTabel.Rows.Add(row);
            }


        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = this.allTicketsTabel.SelectedCells[0].RowIndex;
                var row = allTicketsTabel.Rows[selectedrowindex];
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("ticketid", Convert.ToString(row.Cells["TICKET ID"].Value));
                param.Add("type", "MODIFY");
                employeePageController.modifyTicket(param);
                MessageBox.Show("The ticket has been modified!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = this.allTicketsTabel.SelectedCells[0].RowIndex;
                var row = allTicketsTabel.Rows[selectedrowindex];
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("ticketid", Convert.ToString(row.Cells["TICKET ID"].Value));
                param.Add("type", "CANCEL");
                employeePageController.cancelTicket(param);
                MessageBox.Show("The ticket has been canceled!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeePageController.signUp();
        }
    }
}