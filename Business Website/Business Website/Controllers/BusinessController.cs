using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Business_Website.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Business/Email
        public ActionResult Email()
        {
            return View();
        }


        // GET: Business/Gallery
        public ActionResult Gallery()
        {
            return View();
        }
    }
}