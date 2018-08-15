using gcCoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // TODO: save to db
                return RedirectToAction(nameof(CookieCrisp), new { model.FirstName, model.FavoriteCoffee, });
            }

            return View(model);
        }

        public ActionResult UserSuccess(string firstName)
        {
            ViewBag.FirstName = firstName;
            return View();
        }

        //build cookie
        public ActionResult CookieCrisp(User model)
        {
            HttpCookie UserCookie;
            if (Request.Cookies["UserFirstNameCookie"] == null)
            {
                UserCookie = new HttpCookie("UserFirstNameCookie");
                UserCookie.Expires = DateTime.UtcNow.AddYears(1);
            }
            else
            {
                UserCookie = Request.Cookies["UserFirstNameCookie"];
            }
            UserCookie.Values ["FirstName"]  = model.FirstName.ToString();
            //UserCookie.Values ["FavoriteCoffee"] = model.FavoriteCoffee.ToString();
            Response.Cookies.Add(UserCookie);
            ViewBag.FirstName = model.FirstName;
            ViewBag.FavoriteCoffee = model.FavoriteCoffee;
            return View();
        }
    }
}