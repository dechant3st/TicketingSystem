using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.ViewModels
{
    public class MaintainTeamsViewModel
    {
        public MaintainTeamsViewModel()
        {
            Users = new List<UserTeamSwitch>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserTeamSwitch> Users { get; set; }
    }

    public class UserTeamSwitch
    {
        public int TeamId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
    }
}
