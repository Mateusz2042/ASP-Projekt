using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SportsCompetitions.Models;
using SportsCompetitionsMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsCompetitionsMVC.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        [Authorize(Roles = "Admin")]
        public ActionResult SetRole()
        {
            List<SetRoleViewModel> vm = new List<ViewModels.SetRoleViewModel>();

            using (var db = new ApplicationDbContext())
            {
                var allUsers = db.Users.ToList();
                foreach (var item in allUsers)
                {
                    SetRoleViewModel user = new SetRoleViewModel();
                    user.Role = new List<string>();
                    
                    foreach (var role in item.Roles)
                    {
                        user.Role.Add(role.Role.Name);
                    }

                    user.UserName = item.UserName;
                    vm.Add(user);
                }
                
            }

            return View(vm);
        }
        [HttpPost]
        public ActionResult SetRole(string t)
        {
            return View();
        }
    }
}
