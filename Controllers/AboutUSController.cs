using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLwebsite.Controllers
{
    public class AboutUSController : Controller
    {
        // GET: AboutUS
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Methodology()
        {
            return View();
        }
    }
}