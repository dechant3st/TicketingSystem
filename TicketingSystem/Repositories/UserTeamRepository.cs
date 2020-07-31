using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;

namespace TicketingSystem.Repositories
{
    public class UserTeamRepository : IUserTeamRepository
    {
        private readonly AppDbContext context;

        public UserTeamRepository(AppDbContext context)
        {
            this.context = context;
        }
        public UserTeam Add(UserTeam model)
        {
            context.UserTeams.Add(model);
            context.SaveChanges();
            return model;
        }

        public bool Exist(int teamId, string userId)
        {
            return context.UserTeams.Where(x => x.UserId == userId && x.TeamId == teamId).Any();
        }

        public IEnumerable<UserTeam> GetByTeamId(int id)
        {
            return context.UserTeams.Where(x => x.TeamId == id);
        }

        public IEnumerable<UserTeam> GetByUserId(string id)
        {
            return context.UserTeams.Where(x => x.UserId == id);
        }

        public UserTeam Remove(int teamId, string userId)
        {
            UserTeam model = context.UserTeams
                .Where(x => x.TeamId == teamId && x.UserId == userId)
                .FirstOrDefault();
            context.UserTeams.Remove(model);
            context.SaveChanges();
            return model;
        }

        public IEnumerable<UserTeam> RemoveByTeamId(int id)
        {
            var model = context.UserTeams.Where(x => x.TeamId == id);
            context.UserTeams.RemoveRange(model);
            context.SaveChanges();
            return model;
        }

        public IEnumerable<UserTeam> RemoveByUserId(string id)
        {
            var model = context.UserTeams.Where(x => x.UserId == id);
            context.UserTeams.RemoveRange(model);
            context.SaveChanges();
            return model;
        }

        public IEnumerable<UserTeam> UserTeams()
        {
            return context.UserTeams;
        }
    }
}
