using System.Collections.Generic;
using System.Linq;
using BookingFlights.Model;

namespace BookingFlights.Repository;

public class RequestRepository : Repository<int, Request>
{
    private DBContext dataBaseContext;
    
    public RequestRepository(DBContext dataBaseContext)
    {
        this.dataBaseContext = dataBaseContext;
    }
    public List<Request> getAll()
    {
        return dataBaseContext.requests.ToList();
    }

    public void add(Request entity)
    {
        dataBaseContext.requests.Add(entity);
        dataBaseContext.SaveChanges();
    }

    public void remove(Request entity)
    {
        dataBaseContext.requests.Remove(entity);
        dataBaseContext.SaveChanges();
    }

    public Request findById(int id)
    {
        return dataBaseContext.requests.Where(r => r.id == id).FirstOrDefault();
    }
}