using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;

namespace TicketingSystem.Repositories
{
    public class AppClaimRepository : IAppClaimRepository
    {
        private readonly AppDbContext context;

        public AppClaimRepository(AppDbContext context)
        {
            this.context = context;
        }
        public AppClaim Add(AppClaim model)
        {
            context.AppClaims.Add(model);
            context.SaveChanges();
            return model;
        }

        public IEnumerable<AppClaim> Claims()
        {
            return context.AppClaims;
        }

        public AppClaim Delete(int id)
        {
            AppClaim model = context.AppClaims.Find(id);
            context.AppClaims.Remove(model);
            context.SaveChanges();
            return model;
        }

        public AppClaim GetClaimById(int id)
        {
            return context.AppClaims.Find(id);
        }

        public AppClaim Update(AppClaim modelChanges)
        {
            var model = context.AppClaims.Attach(modelChanges);
            model.State = EntityState.Modified;
            context.SaveChanges();
            return modelChanges;
        }
    }
}
