using SportsCompetitions.Models;
using SportsCompetitionsMVC.Models;
using SportsCompetitionsMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsCompetitionsMVC.Controllers
{
    public class CompetitionController : Controller
    {
        // GET: Competition
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Create()
        {

            return View(new CompetitonViewModel());
        }
        [HttpPost]
        public ActionResult Create(CompetitonViewModel viewModel)
        {

            if (ModelState.IsValid)
            {

                var _event = new SingleCompetition();



                var serverPath = Server.MapPath("~/Content/Upload/");
                var filename = Guid.NewGuid().ToString();
                var extension = System.IO.Path.GetExtension(viewModel.Image.FileName);

                _event.Image = "/Content/Upload/" + filename + extension;

                Directory.CreateDirectory(serverPath);
                viewModel.Image.SaveAs(serverPath + filename + extension);

                UpdateModel(_event);

                ApplicationUser _dbUser;
                SingleCompetition newCompetiton = new SingleCompetition();
                using (var db = new ApplicationDbContext())
                {
                    _dbUser = db.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();

                    newCompetiton = _event;
                    newCompetiton.Image = "/Content/Upload/" + filename + extension;
                    newCompetiton.ModeratorId = _dbUser.Id;
                    newCompetiton.CompetitorsId = new List<string>();



                    db.SaveChanges();
                }

            }
            return View("Index","Home");
        }
        public ActionResult Join()
        {
            List<SingleCompetition> _single = new List<Models.SingleCompetition>();
            return View();
        }
        public ActionResult JoinSingle()
        {
            List<SingleCompetition> _single = new List<Models.SingleCompetition>();
            return View();
        }
        public ActionResult JoinTeam()
        {
            List<SingleCompetition> _single = new List<Models.SingleCompetition>();
            return View();
        }

    }
}