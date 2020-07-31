using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface IUserTeamRepository
    {
        IEnumerable<UserTeam> UserTeams();
        IEnumerable<UserTeam> GetByTeamId(int id);
        IEnumerable<UserTeam> GetByUserId(string id);
        UserTeam Add(UserTeam model);
        IEnumerable<UserTeam> RemoveByTeamId(int id);
        IEnumerable<UserTeam> RemoveByUserId(string id);
        UserTeam Remove(int teamId, string userId);
        bool Exist(int teamId, string userId);
    }
}
