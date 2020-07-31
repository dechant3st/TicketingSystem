using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.ViewModels
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsSuperAdmin { get; set; }
        public List<ModuleSwitch> Modules { get; set; }
    }

    public class ModuleSwitch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
