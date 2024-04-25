using System;
using System.Collections.Generic;
using System.Linq;
using BookingFlights.Model;
using BookingFlights.Repository;

namespace BookingFlights.Service
{
    public class Service
    {
        public DBContext dataBaseContext;
        private List<Employee> loggedEmployees = new List<Employee>();
        private List<Client> loggedClients = new List<Client>();
        private ClientRepository _clientRepository;
        private EmployeeRepository _employeeRepository;
        private FlightRepository _flightRepository;
        private TicketRepository _ticketRepository;
        private RequestRepository _requestRepository;

        public Service(DBContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
            this._clientRepository = new ClientRepository(this.dataBaseContext);
            this._employeeRepository = new EmployeeRepository(this.dataBaseContext);
            this._flightRepository = new FlightRepository(this.dataBaseContext);
            this._ticketRepository = new TicketRepository(this.dataBaseContext);
            this._requestRepository = new RequestRepository(this.dataBaseContext);
        }

        public List<Client> getLoggedClients()
        {
            return this.loggedClients;
        }

        public List<Employee> getLoggedEmployees()
        {
            return this.loggedEmployees;
        }

        public void addLoggedClient(Client client)
        {
            this.loggedClients.Add(client);
        }

        public void addLoggedEmployee(Employee employee)
        {
            this.loggedEmployees.Add(employee);
        }

        public int logIn(string username, string password)
        {
            if (dataBaseContext == null)
            {
                throw new ArgumentNullException();
            }

            var employee = _employeeRepository.find(username, password);
            if (employee == null)
            {
                var client = _clientRepository.find(username, password);
                if (client == null)
                {
                    throw new Exception("Username and password invalid!");
                }

                addLoggedClient(client);
                return 0;
            }

            addLoggedEmployee(employee);
            return 1;
        }

        public void signUp(string type, string name, string username, string password, string admin)
        {
            if (dataBaseContext == null)
            {
                throw new ArgumentNullException();
            }

            if (type == "Client")
            {
                var exists = 0;
                foreach (var client in _clientRepository.getAll())
                {
                    if (client.username == username && client.password == password)
                        exists = 1;
                }

                if (exists == 0)
                {
                    _clientRepository.add(new Client(username, password, name));
                }
                else
                {
                    throw new Exception("This user already exists!");
                }
            }
            else if (type == "Employee")
            {
                if (admin == "ericsuperuser")
                {
                    var exists = 0;
                    foreach (var employee in dataBaseContext.employees.ToList())
                    {
                        if (employee.username == username && employee.password == password)
                            exists = 1;
                    }

                    if (exists == 0)
                    {
                        _employeeRepository.add(new Employee(username, password, name));
                    }
                    else
                    {
                        throw new Exception(
                            "This employee already exists!"); // schimba asta sa nu poata oricine crea cont 
                    }
                }
                else
                {
                    throw new Exception("You can not create an admin account!");
                }
            }
        }

        public Dictionary<string, HashSet<string>> getAllDestinations()
        {
            Dictionary<string, HashSet<string>> destinations = new Dictionary<string, HashSet<string>>();
            HashSet<string> from = new HashSet<string>();
            HashSet<string> to = new HashSet<string>();
            foreach (var flight in _flightRepository.getAll())
            {
                from.Add(flight.from);
                to.Add(flight.to);
            }

            destinations.Add("from", from);
            destinations.Add("to", to);
            return destinations;
        }

        public List<Flight> getFilteredFlights(string from, string to, DateTime date, int passangers)
        {
            List<Flight> filteredFlights = new List<Flight>();
            foreach (var flight in _flightRepository.getAll())
            {
                var date1 = flight.date.Split(' ');
                var date2 = date.ToString().Split(' ');
                if (flight.from == from && flight.to == to && date1[0] == date2[0] &&
                    flight.available_seats - passangers > 0)
                    filteredFlights.Add(flight);
            }

            return filteredFlights;
        }

        public Flight getFlight(string from, string to, string date)
        {
            foreach (var flight in _flightRepository.getAll())
            {
                if (flight.from == from && flight.to == to && flight.date == date)
                    return flight;
            }

            return null;
        }

        public void makeReservation(Ticket ticket)
        {
            _ticketRepository.add(ticket);
        }

        public Dictionary<Ticket, Flight> getAllTickets()
        {
            Dictionary<Ticket, Flight> tickets = new Dictionary<Ticket, Flight>();
            foreach (var ticket in _ticketRepository.getAll())
            {
                var flight = _flightRepository.findById(ticket.flightid);
                tickets.Add(ticket, flight);
            }

            return tickets;
        }

        public List<Request> getAllRequests()
        {
            return _requestRepository.getAll();
        }

        public Request getRequest(string ticketid, string type)
        {
            foreach (var request in _requestRepository.getAll())
            {
                var ty = request.type;
                if (request.type.ToString() == type && request.ticketid.ToString() == ticketid)
                    return request;
            }

            throw new Exception("This request was not made!");
        }

        public Dictionary<Ticket, Flight> getTicketsForClient(Client client)
        {
            Dictionary<Ticket, Flight> tickets = new Dictionary<Ticket, Flight>();
            foreach (var ticket in _ticketRepository.getAll())
            {
                if (client.id == ticket.clientid)
                {
                    var flight = _flightRepository.findById(ticket.flightid);
                    tickets.Add(ticket, flight);
                }
            }

            return tickets;
        }

        public Ticket findTicket(Dictionary<string, string> param, Client client)
        {
            var flight = getFlight(param["from"], param["to"], param["date"]);
            foreach (var ticket in _ticketRepository.getAll())
            {
                var name = param["name"].Split(' ');
                if (ticket.firstname == name[1] && ticket.lastname == name[0] && ticket.cnp == param["cnp"] &&
                    ticket.birthday == param["dob"] && ticket.clientid == client.id && ticket.flightid == flight.id)
                    return ticket;
            }

            throw new Exception("Ticket invalid!");
        }

        public void makeRequest(Request request)
        {
            var exists = false;
            foreach (var req in _requestRepository.getAll())
            {
                if (request.type == req.type && request.ticketid == req.ticketid)
                    exists = true;
            }

            if (exists == false)
                _requestRepository.add(request);
            else throw new Exception("Request already made!");
        }

        public void solveRequest(Request request)
        {
            if (request.type == 0)
            {
                var ticket = _ticketRepository.findById(request.ticketid);
                if (request.firstname == "-") request.firstname = ticket.firstname;
                if (request.lastname == "-") request.lastname = ticket.lastname;
                if (request.cnp == "-") request.cnp = ticket.cnp;
                if (request.birthday != "-") request.birthday = ticket.birthday;
                Ticket newTicket = new Ticket(request.lastname, request.firstname, request.cnp, request.birthday,
                    ticket.flightid, ticket.clientid);
                newTicket.id = ticket.id;
                _ticketRepository.update(newTicket);
                _requestRepository.remove(request);
            }
            else
            {
                var ticket = _ticketRepository.findById(request.ticketid);
                _ticketRepository.remove(ticket);
                _requestRepository.remove(request);
            }
        }
    }
}