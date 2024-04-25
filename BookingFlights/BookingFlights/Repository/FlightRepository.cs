using System;
using System.Collections.Generic;
using System.Linq;
using BookingFlights.Model;

namespace BookingFlights.Repository;

public class FlightRepository : Repository<int, Flight>
{
    private DBContext dataBaseContext;
    
    public FlightRepository(DBContext dataBaseContext)
    {
        this.dataBaseContext = dataBaseContext;
    }
    
    public List<Flight> getAll()
    {
        return dataBaseContext.flights.ToList();
    }

    public void add(Flight entity)
    {
        dataBaseContext.flights.Add(entity);
        dataBaseContext.SaveChanges();
    }

    public void remove(Flight entity)
    {
        throw new NotImplementedException();
    }

    public Flight findById(int id)
    {
        return dataBaseContext.flights.Where(f => f.id == id).FirstOrDefault();
    }
}