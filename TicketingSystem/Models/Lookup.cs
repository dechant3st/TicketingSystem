using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class Lookup
    {
        public Lookup()
        {
            CreatedDate = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Sort { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public int LookupTypeId { get; set; }
        public virtual LookupType LookupType { get; set; }
    }
}