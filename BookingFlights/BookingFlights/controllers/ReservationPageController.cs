using System;
using BookingFlights.Model;

namespace BookingFlights.controllers;

public class ReservationPageController
{
    private Service.Service service;
    private Client client;
    private Flight flight;
    private int passangers;

    public ReservationPageController(Service.Service service)
    {
        this.service = service;
    }

    public void setClient(Client client)
    {
        this.client = client;
    }

    public void setPassangersNo(int passangers)
    {
        this.passangers = passangers;
    }

    public void setFlight(Flight flight)
    {
        this.flight = flight;
    }

    public void show()
    {
        ReservationPage reservationPage = new ReservationPage(this);
        reservationPage.Show();
    }

    public int makeReservation(string lastName, string firstName, string cnp, DateTime birthDate)
    {
        DateTime todaysDate = DateTime.Today;
        if (lastName == "" || firstName == "" || cnp == "" || DateTime.Compare(birthDate, todaysDate) > 0)
        {
            throw new Exception("The data you provided are invalid!");
        }

        Ticket ticket = new Ticket(lastName, firstName, cnp, birthDate.ToString(), this.flight.id, this.client.id);
        service.makeReservation(ticket);
        this.passangers--;
        return this.passangers;
    }
    
    
}