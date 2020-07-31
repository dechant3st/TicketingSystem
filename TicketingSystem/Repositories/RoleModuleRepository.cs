using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;

namespace TicketingSystem.Repositories
{
    public class RoleModuleRepository : IRoleModuleRepository
    {
        private readonly AppDbContext context;

        public RoleModuleRepository(AppDbContext context)
        {
            this.context = context;
        }
        public RoleModule Add(RoleModule model)
        {
            context.RoleModules.Add(model);
            context.SaveChanges();

            return model;
        }

        public IEnumerable<RoleModule> GetRoleModuleById(string roleId)
        {
            return context.RoleModules.Where(x => x.RoleId == roleId);
        }

        public RoleModule Remove(int id)
        {
            RoleModule model = context.RoleModules.Find(id);
            if (model != null)
            {
                context.RoleModules.Remove(model);
                context.SaveChanges();
            }
            return model;
        }

        public IEnumerable<RoleModule> RoleModules()
        {
            return context.RoleModules;
        }
    }
}
