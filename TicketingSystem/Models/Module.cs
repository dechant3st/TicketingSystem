using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Module
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Access { get; set; }
        public string Path { get; set; }    

        public List<ModuleClaim> ModuleClaims { get; set; }
    }
}
