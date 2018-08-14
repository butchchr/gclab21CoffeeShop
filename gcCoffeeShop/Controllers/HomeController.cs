using gcCoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gcCoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Coffee of Doom";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register a New Coffee Addict";

            return View();
        }

        public ActionResult AddUser(User model)
        {
            
            if (ModelState.IsValid)
            {
                // TODO: save to db
                return RedirectToAction(nameof(UserSuccess), new { FirstName = model.FirstName, });
            }

            return View(model);
        }
        public ActionResult UserSuccess(string firstName)
        {
            ViewBag.FirstName = firstName;
            return View();
        }
    }
}