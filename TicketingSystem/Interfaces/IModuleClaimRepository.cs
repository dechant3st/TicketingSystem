using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface IModuleClaimRepository
    {
        IEnumerable<ModuleClaim> ModuleClaims();
        IEnumerable<ModuleClaim> GetModuleClaimById(int moduleId);
        ModuleClaim Remove(int id);
        ModuleClaim Add(ModuleClaim model);
    }
}
