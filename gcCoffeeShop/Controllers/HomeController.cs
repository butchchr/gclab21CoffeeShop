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
                HttpCookie userCookie = Request.Cookies["UserCookie"];
                if (userCookie == null)
                {
                    userCookie = new HttpCookie("UserCookie");
                    userCookie.Expires = DateTime.UtcNow.AddYears(1);
                    Response.Cookies.Add(userCookie);
                }

                userCookie.Values["FirstName"] = model.FirstName;
                userCookie.Values["FavoriteCoffee"] = model.FavoriteCoffee;

                return RedirectToAction(nameof(CookieCrisp));
            }

            return View(model);
        }

        //build cookie
        public ActionResult CookieCrisp()
        {
            HttpCookie userCookie = Request.Cookies["UserCookie"];
            if (userCookie != null)
            {
                ViewBag.FirstName = userCookie.Values["FirstName"];
                ViewBag.FavoriteCoffee = userCookie.Values["FavoriteCoffee"];
            }

            return View();
        }
    }
}