
using System.Linq;
using BookingFlights;
using BookingFlights.controllers;
using BookingFlights.Service;

public class LogInController
{
    private Service service;

    public LogInController(Service service)
    {
        this.service = service;
    }

    public void logIn(string username, string password)
    {
        var userType = service.logIn(username, password);
        if (userType == 0)
        {
            SearchPageController searchPageController = new SearchPageController(service);
            searchPageController.setClient(service.getLoggedClients().Last());
            searchPageController.show();
        }
        else if (userType == 1)
        {
            EmployeePageController employeePageController = new EmployeePageController(service);
            employeePageController.show();

        }
    }

    public void signUp()
    {
        SignUpController signUpController = new SignUpController(service);
        signUpController.show();
    }

    public void show()
    {
        LogIn logIn = new LogIn(this);
        logIn.Show();
    }
}