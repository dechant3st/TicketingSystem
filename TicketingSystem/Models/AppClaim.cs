using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class AppClaim
    {
        public int Id { get; set; }
        [Required]
        public string ClaimType { get; set; }
        [Required]
        public string ClaimValue { get; set; }
    }
}
