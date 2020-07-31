using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface ITeamRepository
    {
        IEnumerable<Team> Teams();
        IEnumerable<UserTeam> GetUsersById(int id);
        Team FindById(int Id);
        Team Add(Team model);
        Team Update(Team model);
    }
}
