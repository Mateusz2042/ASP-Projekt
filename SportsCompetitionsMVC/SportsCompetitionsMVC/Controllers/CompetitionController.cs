using SportsCompetitionsMVC.Models;
using System;
using System.Collections.Generic;
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