using CompetitionRegistration.Models;
using CompetitionRegistration.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetitionRegistration.Controllers
{
    public class CompetitionsController : Controller
    {
        // GET: Competitions
        
        public ActionResult Display()
        {
            //using (var db = new CompetitionContext())
            //{
            //    var comp = new Competition()
            //    {
            //        Category = eCategory.Athletic,
            //        Title = "rzut dyskiem",
            //        StartDate = DateTime.Now
            //    };
            //    db.Competition.Add(comp);
            //    db.SaveChanges();
            //    var allCompetitions = db.Competition;
                
            //}
            return View(new CompetitionsViewModel());
        }
    }
}