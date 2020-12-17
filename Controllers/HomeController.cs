using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogGaelle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Landing()
        {
            return View();
        } 
        public ActionResult Hobbies()
        {
            return View();
        }
        public ActionResult Competences()
        {
            return View();
        }

        public ActionResult Formation()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Parcours()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}