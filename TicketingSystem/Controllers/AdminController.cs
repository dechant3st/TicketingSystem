using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;
using TicketingSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.Controllers
{
    public class AdminController : Controller
    {
        #region Declarations

        private readonly UserManager<AppUser> userManager;

        #endregion

        #region Constructor
        public AdminController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        #endregion

        #region HTTP Get Methods

        [HttpGet]
        public ViewResult ManageUser()
        {
            var users = userManager.Users;
            return View(users);
        }


        #endregion

        #region HTTP Post Methods

        #endregion

        #region Utilities

        public async Task<JsonResult> IsEmailUnique(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null) return Json(true);
            else return Json($"Email address '{email}' is already in use");
        }

        public async Task<JsonResult> IsUserNameUnique(string userName)
        {
            var user = await userManager.FindByNameAsync(userName);

            if (user == null) return Json(true);
            else return Json($"User name '{userName}' is already in use");
        }

        #endregion
    }
}
