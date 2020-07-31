using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface IRoleModuleRepository
    {
        IEnumerable<RoleModule> RoleModules();
        IEnumerable<RoleModule> GetRoleModuleById(string roleId);
        RoleModule Add(RoleModule model);
        RoleModule Remove(int id);
    }
}
