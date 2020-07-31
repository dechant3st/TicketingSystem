using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class UserTeam
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int TeamId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Team Team { get; set; }
    }
}
