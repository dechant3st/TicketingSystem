using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.ViewModels
{
    public class MaintainModuleViewModel
    {
        public IEnumerable<AppClaim> Claims { get; set; }
        public IEnumerable<Module> Modules { get; set; }
        public List<ModuleClaim> ModuleClaims { get; set; }
    }
}
