using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.ViewModels
{
    public class EditModuleViewModel
    {
        public EditModuleViewModel()
        {
            Claims = new List<ClaimSwitch>();
        }
        public Module Module { get; set; }
        public List<ClaimSwitch> Claims { get; set; }
    }

    public class ClaimSwitch
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public bool status { get; set; }
    }
}
