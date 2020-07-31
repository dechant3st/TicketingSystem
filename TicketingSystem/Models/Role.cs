using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Role : IdentityRole
    {
        public bool isSuperAdmin { get; set; }
        public List<RoleModule> RoleModules { get; set; }
    }
}
