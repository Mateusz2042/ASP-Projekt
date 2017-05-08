using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompetitionRegistration.Controllers
{
    public class UserInterfaceController : Controller
    {
        // GET: UserInterface
        public ActionResult Index()
        {
            return View();
        }
    }
}