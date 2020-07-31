using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;

namespace TicketingSystem.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext context;

        public TeamRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Team Add(Team model)
        {
            if(model != null)
            {
                context.Teams.Add(model);
                context.SaveChanges();
            }
            return model;
        }

        public Team FindById(int Id)
        {
            return context.Teams.Where(x => x.Id == Id).FirstOrDefault();
        }

        public IEnumerable<UserTeam> GetUsersById(int id)
        {
            return context.UserTeams.Where(x => x.TeamId == id);
        }


        public IEnumerable<Team> Teams()
        {
            return context.Teams;
        }

        public Team Update(Team model)
        {
            var change = context.Teams.Attach(model);
            change.State = EntityState.Modified;
            context.SaveChanges();
            return model;
        }
    }
}
