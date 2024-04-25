using System.Collections.Generic;
using BookingFlights.Model;

namespace BookingFlights.controllers;

public class EmployeePageController
{
    private Service.Service service;
    Employee currentEmployee;
    private Dictionary<Ticket, Flight> tickets;
    private List<Request> requests;
    private EmployeePage employeePage;
    
    public EmployeePageController(Service.Service service)
    {
        this.service = service;
        this.employeePage = new EmployeePage(this);
    }
    

    public void initializeTables()
    {
        this.tickets = service.getAllTickets();
        this.requests = service.getAllRequests();
        employeePage.initializeTicketsTable(tickets);
        employeePage.initializeRequestTabel(requests);
    }

    public void show()
    {
       initializeTables();
       employeePage.Show();
    }

    public void signUp()
    {
        LogInController logInController = new LogInController(service);
        logInController.show();
    }

    public void modifyTicket(Dictionary<string, string> param)
    {
        var request = service.getRequest(param["ticketid"], param["type"]);
        service.solveRequest(request);
        initializeTables();
        
    }

    public void cancelTicket(Dictionary<string, string> param)
    {
        var request = service.getRequest(param["ticketid"], param["type"]);
        service.solveRequest(request);
        initializeTables();
    }
}