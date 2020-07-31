using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
    }
}
