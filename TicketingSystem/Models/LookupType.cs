using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models
{
    public class LookupType
    {
        public LookupType()
        {
            CreatedDate = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual List<Lookup> Lookups { get; set; }
    }
}
