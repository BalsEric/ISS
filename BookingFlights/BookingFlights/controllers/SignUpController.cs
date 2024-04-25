namespace BookingFlights.controllers;

public class SignUpController
{
    private Service.Service service;
    public SignUpController(Service.Service service)
    {
        this.service = service;
    }

    public void signUp(string typeUser, string name, string username, string password, string admin)
    {
        service.signUp(typeUser, name, username, password, admin);
    }

    public void show()
    {
        SignUp signUp = new SignUp(this);
        signUp.Show();
    }

    public void showLogIn()
    {
        LogInController logInController = new LogInController(service);
        logInController.show();
    }
    
}