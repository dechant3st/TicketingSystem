using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.ViewModels
{
    public class MaintainRoleViewModel
    {
        public MaintainRoleViewModel()
        {
            Roles = new List<Role>();
            Modules = new List<Module>();
            RoleModules = new List<RoleModule>();
        }

        public List<Role> Roles { get; set; }
        public List<Module> Modules { get; set; }
        public List<RoleModule> RoleModules { get; set; }
    }
}
