using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    public static class AccountDataSettings
    {
        public static List<Claim> Claims = new List<Claim>
        {
            new Claim("Read Claim", "Can Read"),
            new Claim("Write Claim", "Can Write"),
            new Claim("Edit Claim", "Can Edit"),
            new Claim("Delete Claim", "Can Delete")
        };
    }
}
