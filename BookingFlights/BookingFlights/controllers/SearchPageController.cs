using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BookingFlights.Model;

namespace BookingFlights.controllers;

public class SearchPageController
{
    private Service.Service service;
    Client currentClient;
    private Flight selectedFlight;
    private int passangers;
    private SearchPage searchPage;
    public SearchPageController(Service.Service service)
    {
        this.service = service;
        this.searchPage = new SearchPage(this);
    }

    public void setClient(Client client)
    {
        this.currentClient = client;
    }
    

    public Dictionary<string, HashSet<string>> getAllDestinations()
    {
        return service.getAllDestinations();
    }

    public void search(string from, string to, DateTime date, int pass)
    {
        List<Flight> flights =  service.getFilteredFlights(from, to, date, pass);
        searchPage.initializeTable(flights);
    }

    public void signOut()
    {
        LogInController logInController = new LogInController(service);
        logInController.show();
    }

    public void show()
    {
        // SearchPage searchPage = new SearchPage(this);
        searchPage.Show();
    }

    public void showReservationPage()
    {
        ReservationPageController reservationPageController = new ReservationPageController(service);
        reservationPageController.setClient(this.currentClient);
        reservationPageController.setFlight(this.selectedFlight);
        reservationPageController.setPassangersNo(this.passangers);
        reservationPageController.show();
    }

    public void showTicketsPage()
    {
        TicketsPageController ticketsPageController = new TicketsPageController(service);
        ticketsPageController.setClient(currentClient);
        ticketsPageController.show();
    }

    public void setSelectedFlight(string from, string to, string date)
    {
        this.selectedFlight = service.getFlight(from, to, date);
    }

    public void setPassangerNumber(int passangers)
    {
        this.passangers = passangers;
    }

}