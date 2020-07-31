using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface ILookupTypeRepository
    {
        IEnumerable<LookupType> LookupTypes();
        IEnumerable<Lookup> GetLookupsById(int id);
        LookupType Add(LookupType model);
        LookupType Update(LookupType model);
        LookupType Remove(int id);
    }
}
