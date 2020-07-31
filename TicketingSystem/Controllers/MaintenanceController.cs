using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Interfaces;
using TicketingSystem.Models;
using TicketingSystem.ViewModels;

namespace TicketingSystem.Controllers
{
    public class MaintenanceController : Controller
    {
        #region Declarations

        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly IAppClaimRepository appClaimRepository;
        private readonly IModuleRepository moduleRepository;
        private readonly IModuleClaimRepository moduleClaimRepository;
        private readonly IRoleModuleRepository roleModuleRepository;
        private readonly ITeamRepository teamRepository;
        private readonly IUserTeamRepository userTeamRepository;

        #endregion

        #region Constructor
        public MaintenanceController(UserManager<AppUser> userManager,
            RoleManager<Role> roleManager,
            IAppClaimRepository appClaimRepository,
            IModuleRepository moduleRepository,
            IModuleClaimRepository moduleClaimRepository,
            IRoleModuleRepository roleModuleRepository,
            ITeamRepository teamRepository,
            IUserTeamRepository userTeamRepository)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.appClaimRepository = appClaimRepository;
            this.moduleRepository = moduleRepository;
            this.moduleClaimRepository = moduleClaimRepository;
            this.roleModuleRepository = roleModuleRepository;
            this.teamRepository = teamRepository;
            this.userTeamRepository = userTeamRepository;
        }

        #endregion

        #region HTTP Get Methods
        [HttpGet]
        public ViewResult MaintainClaims()
        {
            var claims = appClaimRepository.Claims();
            return View(claims);
        }

        [HttpGet]
        public ViewResult MaintainModules()
        {
            var claims = appClaimRepository.Claims();
            var modules = moduleRepository.Modules();
            List<ModuleClaim> moduleClaims = moduleClaimRepository.ModuleClaims().ToList();

            MaintainModuleViewModel model = new MaintainModuleViewModel
            {
                Claims = claims,
                Modules = modules,
                ModuleClaims = moduleClaims
            };

            return View(model);
        }

        [HttpGet]
        public ViewResult EditModule(int id)
        {
            var claims = appClaimRepository.Claims();
            var module = moduleRepository.GetModuleById(id);
            List<ModuleClaim> moduleClaim = moduleClaimRepository.GetModuleClaimById(module.Id).ToList();
            List<ClaimSwitch> editClaims = new List<ClaimSwitch>();

            foreach(AppClaim claim in claims.ToList())
            {
                editClaims.Add(new ClaimSwitch
                {
                    Id = claim.Id,
                    ClaimType = claim.ClaimType,
                    ClaimValue = claim.ClaimValue,
                    status = moduleClaim.Where(x => x.AppClaimId == claim.Id).Any() ? true : false
                });
            }

            EditModuleViewModel model = new EditModuleViewModel
            {
                Claims = editClaims,
                Module = module
            };

            return View(model);
        }

        [HttpGet]
        public ViewResult NewModule()
        {
            NewModuleViewModel model = new NewModuleViewModel
            {
                claims = appClaimRepository.Claims().Select<AppClaim, ClaimSwitch>(x =>
                {
                    return new ClaimSwitch
                    {
                        Id = x.Id,
                        ClaimType = x.ClaimType,
                        ClaimValue = x.ClaimValue,
                        status = false
                    };
                }).ToList()
            };

            return View(model);
        }

        [HttpGet]
        public ViewResult MaintainRoles()
        {
            MaintainRoleViewModel model = new MaintainRoleViewModel
            {
                Roles = roleManager.Roles.ToList(),
                Modules = moduleRepository.Modules().ToList(),
                RoleModules = roleModuleRepository.RoleModules() != null ? 
                    roleModuleRepository.RoleModules().ToList() : new List<RoleModule>()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<ViewResult> EditRole(string id)
        {
            Role role = await roleManager.FindByIdAsync(id);
            List<ModuleSwitch> modules = new List<ModuleSwitch>();

            foreach(Module module in moduleRepository.Modules().ToList())
            {
                modules.Add(new ModuleSwitch
                {
                    Id = module.Id,
                    Name = module.Name,
                    Status = (roleModuleRepository.GetRoleModuleById(id)
                        .Where(x => x.ModuleId == module.Id).Any() ? true : false) ||
                        role.isSuperAdmin
                });
            }

            EditRoleViewModel model = new EditRoleViewModel
            {
                Id = role.Id,
                Name = role.Name,
                IsSuperAdmin = role.isSuperAdmin,
                Modules = modules
            };

            return View(model);
        }

        [HttpGet]
        public async Task<ViewResult> MaintainEmployees()
        {
            var users = userManager.Users;
            List<MaintainEmployeeViewModel> model = new List<MaintainEmployeeViewModel>();
            
            if (users != null)
            {
                foreach (AppUser user in users.ToList())
                {
                    var roleString = await userManager.GetRolesAsync(user);
                    string roleName = "Not Assigned";
                   
                    if(roleString.Any())
                    {
                        roleName = roleString[0];
                    }

                    model.Add(new MaintainEmployeeViewModel
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        Phone = user.PhoneNumber,
                        Address = user.Address,
                        IsActive= user.isActive,
                        CreatedBy = user.CreatedBy,
                        UpdatedBy = user.UpdatedBy,
                        PhotoPath = user.PhotoPath,
                        RoleName = roleName
                    });
                }
            }
            

            return View(model);
        }

        [HttpGet]
        public ViewResult NewEmployee()
        {
            NewEmployeeViewModel model = new NewEmployeeViewModel
            {
                Roles = roleManager.Roles.Select(x => x.Name).ToList()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<ViewResult> MaintainTeams()
        {
            List<MaintainTeamsViewModel> model = new List<MaintainTeamsViewModel>();

            foreach(Team team in teamRepository.Teams().ToList())
            {
                List<UserTeamSwitch> users = new List<UserTeamSwitch>();
                foreach(UserTeam userTeam in teamRepository.GetUsersById(team.Id).ToList())
                {
                    AppUser appUser = await userManager.FindByIdAsync(userTeam.UserId);

                    if(appUser != null)
                    {
                        users.Add(new UserTeamSwitch
                        {
                            UserId = appUser.Id,
                            Email = appUser.Email,
                            FirstName = appUser.FirstName,
                            LastName = appUser.LastName,
                            Phone = appUser.PhoneNumber,
                            TeamId = team.Id,
                            Status = true
                        });
                    }
                }

                model.Add(new MaintainTeamsViewModel
                {
                    Id = team.Id,
                    Name = team.Name,
                    Users = users
                });
            }

            return View(model);
        }

        [HttpGet]
        public ViewResult AssignTeamMember(int id)
        {
            var team = teamRepository.FindById(id);

            if (team == null)
            {

            }

            List<AppUser> users = userManager.Users.Where(x => x.isActive == true).ToList();

            List<UserTeamSwitch> userTeams = new List<UserTeamSwitch>();

            foreach(var user in users)
            {
                userTeams.Add(new UserTeamSwitch
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Phone = user.PhoneNumber,
                    TeamId = id,
                    Status = userTeamRepository.Exist(id, user.Id)
                });
            }

            MaintainTeamsViewModel model = new MaintainTeamsViewModel
            {
                Id = id,
                Name = team.Name,
                Users = userTeams
            };

            return View(model);
        }

        #endregion

        #region HTTP Post Methods

        [HttpPost]
        public IActionResult EditModule(EditModuleViewModel model)
        {
            if(ModelState.IsValid)
            {
                Module module = moduleRepository.GetModuleById(model.Module.Id);
                module.Name = model.Module.Name;
                module.Access = model.Module.Access;
                module.Path = model.Module.Path;
                moduleRepository.Update(module);

                List<ModuleClaim> moduleClaims = moduleClaimRepository.GetModuleClaimById(module.Id).ToList();

                if (moduleClaims != null)
                {
                    foreach(ModuleClaim moduleClaim in moduleClaims)
                    {
                        moduleClaimRepository.Remove(moduleClaim.Id);
                    }
                }

                foreach (ClaimSwitch claim in model.Claims)
                {
                    if(claim.status)
                    {
                        moduleClaimRepository.Add(new ModuleClaim
                        {
                            ModuleId = module.Id,
                            AppClaimId= claim.Id
                        });
                    }
                }

                
                return RedirectToAction("MaintainModules");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult NewModule(NewModuleViewModel model)
        {
            if(ModelState.IsValid)
            {
                moduleRepository.Add(model.module);


                List<ModuleClaim> moduleClaims = moduleClaimRepository.GetModuleClaimById(model.module.Id).ToList();

                if (moduleClaims != null)
                {
                    foreach (ModuleClaim moduleClaim in moduleClaims)
                    {
                        moduleClaimRepository.Remove(moduleClaim.Id);
                    }
                }

                foreach (ClaimSwitch claim in model.claims)
                {
                    if (claim.status)
                    {
                        moduleClaimRepository.Add(new ModuleClaim
                        {
                            ModuleId = model.module.Id,
                            AppClaimId = claim.Id
                        });
                    }
                }

                return RedirectToAction("MaintainModules");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                Role role = await roleManager.FindByIdAsync(model.Id);
                role.Name = model.Name;
                role.isSuperAdmin = model.IsSuperAdmin;
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    var modules = roleModuleRepository.GetRoleModuleById(model.Id);

                    if(modules != null)
                    {
                        foreach (RoleModule module in modules.ToList())
                        {
                            roleModuleRepository.Remove(module.Id);
                        }
                    }                    

                    foreach(ModuleSwitch module in model.Modules)
                    {
                        if (role.isSuperAdmin) break;
                        if (module.Status)
                        {
                            roleModuleRepository.Add(new RoleModule
                            {
                                RoleId = model.Id,
                                ModuleId = module.Id
                            });
                        }
                    }

                    return RedirectToAction("MaintainRoles");
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NewEmployee(NewEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    FirstName = model.FirstName,
                    LastName=model.LastName,
                    Email=model.Email,
                    PhoneNumber=model.Phone,
                    isActive=true,
                    UserName=model.UserName
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(model.Role))
                    {
                        foreach(var role in roleManager.Roles)
                        {
                            user = await userManager.FindByNameAsync(model.UserName);

                            if(await userManager.IsInRoleAsync(user, role.Name))
                            {
                                result = await userManager.RemoveFromRoleAsync(user, role.Name);
                            }
                        }

                        result = await userManager.AddToRoleAsync(user, model.Role);

                        if(!result.Succeeded)
                        {
                            ViewBag.ErrorMessage = "Error in adding role to employee.";
                            return View("NotFound");
                        }

                        return RedirectToAction("MaintainEmployees");
                    }
                }
            }

            model.Roles = roleManager.Roles.Select(x => x.Name).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult AssignTeamMember(MaintainTeamsViewModel model)
        {
            foreach(UserTeamSwitch user in model.Users)
            {
                if(user.Status)
                {
                    if (userTeamRepository.Exist(user.TeamId, user.UserId)) continue;
                    userTeamRepository.Add(new UserTeam
                    {
                        UserId = user.UserId,
                        TeamId = user.TeamId
                    });
                }
                else
                {
                    if (!userTeamRepository.Exist(user.TeamId, user.UserId)) continue;
                    userTeamRepository.Remove(user.TeamId, user.UserId);
                }
            }

            return RedirectToAction("maintainteams");
        }

        #endregion

        #region Utility

        [AcceptVerbs("Post", "Get")]
        public async Task<JsonResult> IsEmailUnique(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }

        #endregion
    }
}
