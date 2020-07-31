using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            CreatedDate = DateTime.UtcNow;
            UpdatedDate = DateTime.UtcNow;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool isActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string PhotoPath { get; set; }


        public virtual List<UserModule> UserModules { get; set; }
        public virtual List<UserModuleClaim> UserModuleClaims { get; set; }
        public virtual List<UserTeam> UserTeams { get; set; }
    }
}
