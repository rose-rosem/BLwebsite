using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLwebsite.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Advanced()
        {
            return View();
        }

        public ActionResult Phonetic()
        {
            return View();
        }
    }
}