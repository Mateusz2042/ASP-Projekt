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
        public ActionResult Index()
        {
            return View("Register",new CompetitorRegistrationViewModel());
        }
        [HttpPost]
        public ActionResult Index(CompetitorRegistrationViewModel user)
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


    }
}