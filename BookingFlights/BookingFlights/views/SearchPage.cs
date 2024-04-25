using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BookingFlights.controllers;
using BookingFlights.Model;

namespace BookingFlights
{
    public partial class SearchPage : Form
    {
        private Service.Service service;
        private SearchPageController searchPageController;
        public SearchPage(SearchPageController searchPageController)
        {
            InitializeComponent();
            this.searchPageController = searchPageController;
            var destinations = searchPageController.getAllDestinations();
            foreach (var dep in destinations["from"])
            {
                this.fromComboBox.Items.Add(dep);
            }
            fromComboBox.ValueMember = "Text";

            foreach (var arr in destinations["to"])
            {
                this.toComboBox.Items.Add(arr);
            }
            toComboBox.ValueMember = "Text";     
        }
        
        public void initializeTable(List<Flight> flights)
        {
            flightsTable.Rows.Clear();
            this.flightsTable.ColumnCount = 5;
            this.flightsTable.Columns[0].Name = "DEPARTURE";
            this.flightsTable.Columns[1].Name = "ARRIVAL";
            this.flightsTable.Columns[2].Name = "DATE";
            this.flightsTable.Columns[3].Name = "AVAILABLE SEATS";
            this.flightsTable.Columns[4].Name = "PRICE";
            foreach (var flight in flights)
            {
                var from = flight.from;
                var to = flight.to;
                var date = flight.date;
                var availb = flight.available_seats.ToString();
                var price = flight.price.ToString() + "Euro";
                string[] row = { from, to, date, availb, price };

                flightsTable.Rows.Add(row);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedFrom = (string)this.fromComboBox.SelectedItem;
                string selectedTo = (string)this.toComboBox.SelectedItem;
                var date = this.datePicker.Value;
                var passangers = Int16.Parse(this.passangerField.Text);
                searchPageController.search(selectedFrom, selectedTo, date, passangers);
                // initializeTable(flights);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = this.flightsTable.SelectedCells[0].RowIndex;
            var row = flightsTable.Rows[selectedrowindex];
            string from = Convert.ToString(row.Cells["DEPARTURE"].Value);
            string to = Convert.ToString(row.Cells["ARRIVAL"].Value);
            string date = Convert.ToString(row.Cells["DATE"].Value);
            var passangers = Int16.Parse(this.passangerField.Text);
            searchPageController.setSelectedFlight(from, to, date);
            searchPageController.setPassangerNumber(passangers);
            searchPageController.showReservationPage();
        }

        private void showTicketsButton_Click(object sender, EventArgs e)
        {
            searchPageController.showTicketsPage();
        }

        private void flightsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void signOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchPageController.signOut();
        }
    }
}