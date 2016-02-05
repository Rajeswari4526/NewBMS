using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bug Management System is used to keeptrack of the bugs in a project.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
