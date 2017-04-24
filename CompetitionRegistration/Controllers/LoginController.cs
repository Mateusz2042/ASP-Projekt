using CompetitionRegistration.Models;
using CompetitionRegistration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetitionRegistration.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View(new CompetitorLoginViewModel());
        }
        [HttpPost]
        public ActionResult Login(CompetitorLoginViewModel user)
        {

            
            using (var db = new CompetitionContext())
            {
                var currentUser = db.Competitor.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();

                



            }
            return View();
        }
    }
}