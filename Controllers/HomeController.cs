using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using BlogGaelle.Repository;

//librairie MySql ajoutée précédemment dans les ref
namespace BlogGaelle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Construction()
        {
            return View();
        }
        // GET: Home/Landing/1
        public ActionResult Landing()
        {
            return View();
        }
        
    }
}
            //return View(utilisateur);




        //public ActionResult Hobbies()
        //{
        //    return View();
        //}
        //public ActionResult Competences()
        //{
        //    return View();
        //}

        //public ActionResult Formation()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Parcours()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
