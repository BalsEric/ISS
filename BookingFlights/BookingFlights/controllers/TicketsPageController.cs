using System.Collections.Generic;
using BookingFlights.Model;

namespace BookingFlights.controllers;

public class TicketsPageController
{
    private Service.Service service;
    private Client client;

    public TicketsPageController(Service.Service service)
    {
        this.service = service;
    }

    public void setClient(Client client)
    {
        this.client = client;
    }

    public void show()
    {
        Dictionary<Ticket, Flight> tickets = service.getTicketsForClient(this.client);
        TicketPage ticketsPage = new TicketPage(this);
        ticketsPage.initializeTable(tickets);
        ticketsPage.Show();
    }

    public void cancelReservation(Dictionary<string, string> param)
    {
        var ticket = service.findTicket(param, this.client);
        Request request = new Request(RequestType.CANCEL, "-", "-", "-", "-", ticket.id);
        service.makeRequest(request);
    }

    public void modifyReservation(Dictionary<string, string> param, Dictionary<string, string> newValues)
    {
        var ticket = service.findTicket(param, this.client);
        if (newValues["lname"] == "") newValues["lname"] = "-";
        if (newValues["fname"] == "") newValues["fname"] = "-";
        if (newValues["cnp"] == "") newValues["cnp"] = "-";
        if (newValues["dob"] == "") newValues["dob"] = "-";
        Request request = new Request(RequestType.MODIFY, newValues["lname"], newValues["fname"], newValues["cnp"],
            newValues["dob"], ticket.id);
        service.makeRequest(request);
    }
}