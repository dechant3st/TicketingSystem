using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;

namespace TicketingSystem.Repositories
{
    public class ModuleClaimRepository : IModuleClaimRepository
    {
        private readonly AppDbContext context;

        public ModuleClaimRepository(AppDbContext context)
        {
            this.context = context;
        }

        public ModuleClaim Add(ModuleClaim model)
        {
            context.ModuleClaims.Add(model);
            context.SaveChanges();
            return model;
        }

        public IEnumerable<ModuleClaim> GetModuleClaimById(int moduleId)
        {
            return context.ModuleClaims.Where(x => x.ModuleId == moduleId);
        }

        public IEnumerable<ModuleClaim> ModuleClaims()
        {
            return context.ModuleClaims;
        }

        public ModuleClaim Remove(int id)
        {
            ModuleClaim model = context.ModuleClaims.Find(id);
            if (model != null)
            {
                context.ModuleClaims.Remove(model);
                context.SaveChanges();
            }
            return model;
        }
    }
}
