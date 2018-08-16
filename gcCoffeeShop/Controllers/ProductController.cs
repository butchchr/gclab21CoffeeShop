using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gcCoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
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