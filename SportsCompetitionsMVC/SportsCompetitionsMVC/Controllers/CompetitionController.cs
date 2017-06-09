using SportsCompetitions.Models;
using SportsCompetitionsMVC.Models;
using SportsCompetitionsMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        [Authorize]
        public ActionResult DisplayEvents()
        {
            List<DisplayEventViewModel> vm = new List<DisplayEventViewModel>();
            using (var db = new ApplicationDbContext())
            {
                var allCompetitions = db.SingleCompetition.Where(n => n.StartDate >= DateTime.Today).ToList();
                foreach (var item in allCompetitions)
                {
                    DisplayEventViewModel _event = new DisplayEventViewModel();
                    _event.Category = item.Category.ToString();
                    //_event.CompetitorsCount = item.CompetitorsId.Count;

                    _event.Image = item.Image;
                    _event.StartDate = item.StartDate;
                    _event.Title = item.Title;
                    _event.Description = item.Description;
                    vm.Add(_event);

                }


            }


            return View(vm);
        }
        [Authorize]
        public ActionResult DisplayYourEvents()
        {
            // uzytkownik i jego eventy
            //trzeba zrobic widok z evetami urzytkownika 
            List<DisplayEventViewModel> vm = new List<DisplayEventViewModel>();
            using (var db = new ApplicationDbContext())
            {
                var userCompetitions = db.Users.Include(n => n.SingleCompetition).Where(n => n.UserName == User.Identity.Name).First();

                var competitions = userCompetitions.SingleCompetition.Where(n => n.StartDate >= DateTime.Today);


                foreach (var item in competitions)
                {
                    DisplayEventViewModel _event = new DisplayEventViewModel();
                    _event.Category = item.Category.ToString();
                    //_event.CompetitorsCount = item.CompetitorsId.Count;
                    _event.Image = item.Image;
                    _event.StartDate = item.StartDate;
                    _event.Title = item.Title;
                    vm.Add(_event);


                }





            }
            return View(vm);
        }
        [Authorize]
        public ActionResult Display3Events()
        {
            List<DisplayEventViewModel> vm = new List<DisplayEventViewModel>();
            using (var db = new ApplicationDbContext())
            {

                var allCompetitions = db.SingleCompetition.Where(n => n.StartDate == DateTime.MinValue).ToList();
                foreach (var item in allCompetitions)
                {
                    DisplayEventViewModel _event = new DisplayEventViewModel();
                    _event.Category = item.Category.ToString();
                    //_event.CompetitorsCount = item.CompetitorsId.Count;
                    _event.Image = item.Image;
                    _event.StartDate = item.StartDate;
                    _event.Title = item.Title;
                    vm.Add(_event);


                }
                ViewBag.bag = vm;

            }


            return View("Home", vm);
        }
        [Authorize]
        public ActionResult Create()
        {

            return View(new CompetitonViewModel());
        }
        [HttpPost]
        [Authorize]
        public ActionResult Create(CompetitonViewModel viewModel, string type)
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
                    newCompetiton.Competitors = new List<Competitor>();


                    db.SingleCompetition.Add(newCompetiton);


                    db.SaveChanges();
                }

            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Join(int id)
        {
            // wyslij email do zalogowanego uzytkownika z kodem qr
            //dodawanie zrobic
            List<SingleCompetition> _single = new List<Models.SingleCompetition>();

            return RedirectToAction("DisplayYourEvents");
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