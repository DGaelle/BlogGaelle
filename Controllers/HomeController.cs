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
        private BlogGaelleEntities db = new BlogGaelleEntities();
        [RequireHttps]
        public ActionResult Construction()
        {
            return View();
        }
        // GET: Home/Landing/1
        [RequireHttps]
        public ActionResult Landing()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequireHttps]
        public ActionResult Landing([Bind(Include = "IdUser,Nom,Prenom,Email,Telephone,Message")] User user)
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
