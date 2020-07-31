using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.ViewModels
{
    public class NewModuleViewModel
    {
        public NewModuleViewModel()
        {
            module = new Module();
            claims = new List<ClaimSwitch>();
        }
        public Module module { get; set; }
        public List<ClaimSwitch> claims { get; set; }
    }
}
