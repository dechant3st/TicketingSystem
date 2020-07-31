using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class RoleModule
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public int ModuleId { get; set; }

        public virtual Module Module { get; set; }
    }
}
