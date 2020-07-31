using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Interfaces
{
    public interface IModuleRepository
    {
        Module GetModuleById(int id);
        IEnumerable<Module> Modules();
        Module Add(Module model);
        Module Update(Module modelChanges);
        Module Delete(int id);
    }
}
