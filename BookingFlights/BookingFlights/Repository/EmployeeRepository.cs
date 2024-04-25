using System.Collections.Generic;
using System.Linq;
using BookingFlights.Model;

namespace BookingFlights.Repository;

public class EmployeeRepository:Repository<int, Employee>
{
    private DBContext dataBaseContext;
    public EmployeeRepository(DBContext dataBaseContext)
    {
        this.dataBaseContext = dataBaseContext;
    }
    
    public List<Employee> getAll()
    {
        return dataBaseContext.employees.ToList();
    }

    public void add(Employee entity)
    {
        dataBaseContext.employees.Add(entity);
        dataBaseContext.SaveChanges();
    }

    public void remove(Employee entity)
    {
        dataBaseContext.employees.Remove(entity);
        dataBaseContext.SaveChanges();
    }

    public Employee findById(int id)
    {
        return dataBaseContext.employees.Find(id);
    }

    public Employee find(string username, string password)
    {
        return dataBaseContext.employees.Where(e => e.username == username && e.password == password).FirstOrDefault();
    }
}