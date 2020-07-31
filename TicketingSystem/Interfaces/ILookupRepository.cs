using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface ILookupRepository
    {
        IEnumerable<Lookup> Lookups();
        IEnumerable<Lookup> GetLookupsByTypeId(int id);
        Lookup Add(Lookup model);
        Lookup Update(Lookup model);
        Lookup Remove(int id);
    }
}
