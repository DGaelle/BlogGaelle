using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        // POST: Home/Landing/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(([Bind(Include = "IdUser,Nom,Prenom,Email,Telephone")] User user))
        {
            if (ModelState.IsValid)
            {
                db.Entry(utilisateur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Compte");
    }
    }
            return View(utilisateur);


} 

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
