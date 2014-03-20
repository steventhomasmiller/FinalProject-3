using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hi.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "No.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Leave me alone.";

            return View();
        }
    }
}
