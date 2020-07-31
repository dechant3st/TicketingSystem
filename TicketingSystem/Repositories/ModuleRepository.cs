using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;

namespace TicketingSystem.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly AppDbContext context;

        public ModuleRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Module Add(Module model)
        {
            context.Add(model);
            context.SaveChanges();
            return model;
        }

        public Module Delete(int id)
        {
            Module model = context.Modules.Find(id);
            if(model!= null)
            {
                context.Modules.Remove(model);
                context.SaveChanges();
            }

            return model;
        }

        public Module GetModuleById(int id)
        {
            return context.Modules.Find(id);
        }

        public IEnumerable<Module> Modules()
        {
            return context.Modules;
        }

        public Module Update(Module modelChanges)
        {
            var model = context.Modules.Attach(modelChanges);
            model.State = EntityState.Modified;
            context.SaveChanges();
            return modelChanges;
        }
    }
}
