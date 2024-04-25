using System;
using System.Collections.Generic;
using System.Linq;
using BookingFlights.Model;

namespace BookingFlights.Repository;

public class ClientRepository : Repository<int, Client>
{
    private DBContext dataBaseContext;
    
    public ClientRepository(DBContext dataBaseContext)
    {
        this.dataBaseContext = dataBaseContext;
    }
    
    public List<Client> getAll()
    {
        return dataBaseContext.clients.ToList();
    }

    public void add(Client entity)
    {
        dataBaseContext.clients.Add(entity);
        dataBaseContext.SaveChanges();
    }

    public void remove(Client entity)
    {
        throw new NotImplementedException();
    }

    public Client findById(int id)
    {
        throw new NotImplementedException();
    }
    
    public Client find(string username, string password)
    {
        return dataBaseContext.clients.Where(c=>c.username == username && c.password == password).FirstOrDefault();
    }
}