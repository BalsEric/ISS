using System.Collections.Generic;
using System.Linq;
using BookingFlights.Model;

namespace BookingFlights.Repository;

public class TicketRepository : Repository<int, Ticket>
{
    private DBContext dataBaseContext;
    
    public TicketRepository(DBContext dataBaseContext)
    {
        this.dataBaseContext = dataBaseContext;
    }
    
    public List<Ticket> getAll()
    {
        return dataBaseContext.tickets.ToList();
    }

    public void add(Ticket entity)
    {
        dataBaseContext.tickets.Add(entity);
        dataBaseContext.SaveChanges();
    }

    public void remove(Ticket entity)
    {
        dataBaseContext.tickets.Remove(entity);
        dataBaseContext.SaveChanges();
    }

    public Ticket findById(int id)
    {
        return dataBaseContext.tickets.Where(t=>t.id == id).FirstOrDefault();
    }

    public void update(Ticket entity)
    {
        var ticket = dataBaseContext.tickets.Find(entity.id);
        ticket.lastname = entity.lastname;
        ticket.firstname = entity.firstname;
        ticket.cnp = entity.cnp;
        ticket.birthday = entity.birthday;
        dataBaseContext.SaveChanges();
    }
}