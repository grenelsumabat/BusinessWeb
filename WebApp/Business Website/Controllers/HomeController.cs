using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Business_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Legends of Alaska";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Grenel Sumabat [@shoemabat]";
            ViewBag.Message2 = "Matthew Ochavido [@mrmosole]";
   

            return View();
        }
    }
}