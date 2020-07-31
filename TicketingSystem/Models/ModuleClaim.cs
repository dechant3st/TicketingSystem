using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class ModuleClaim
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public int AppClaimId { get; set; }

        public virtual AppClaim AppClaim { get; set; }
    }
}
