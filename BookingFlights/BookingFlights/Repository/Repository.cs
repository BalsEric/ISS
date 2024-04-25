using System.Collections.Generic;
using BookingFlights.Model;

namespace BookingFlights.Repository;

public interface Repository<ID, entityType> where entityType : Entity<ID>
{
    List<entityType> getAll();
    void add(entityType entity);
    void remove(entityType entity);
    entityType findById(ID id);
}