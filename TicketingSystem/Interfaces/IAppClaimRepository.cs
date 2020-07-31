using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface IAppClaimRepository
    {
        AppClaim GetClaimById(int id);
        IEnumerable<AppClaim> Claims();
        AppClaim Add(AppClaim model);
        AppClaim Update(AppClaim modelChanges);
        AppClaim Delete(int id);
    }
}
