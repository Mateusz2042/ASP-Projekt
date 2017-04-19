using CompetitionRegistration.Models;
using CompetitionRegistration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetitionRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {
            return View(new CompetitorRegistrationViewModel());
        }
        [HttpPost]
        public ActionResult Register(CompetitorRegistrationViewModel user)
        {
            if (ModelState.IsValid)
            {
                var competitor = new Competitor();
                UpdateModel(competitor);
                using (var db = new CompetitionContext())
                {
                    db.Competitor.Add(competitor);
                    db.SaveChanges();
                }
                //zapis cu do bazy

            }
            return RedirectToAction("Home/Index");


        }
        public ActionResult Display()
        {
            List<CompetiorsDisplayViewModel> allUsers = new List<CompetiorsDisplayViewModel>();
            using (var db = new CompetitionContext())
            {
                foreach (var user in db.Competitor)
                {
                    CompetiorsDisplayViewModel du = new CompetiorsDisplayViewModel()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Sex = user.Sex.ToString(),
                        BirthDate = user.BirthDate.Date.ToString()

                    };

                    allUsers.Add(du);
                }

            }
            return View(allUsers);
        }



    }
}