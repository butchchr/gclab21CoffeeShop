using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gcCoffeeShop.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            HttpCookie userCookie = Request.Cookies["UserCookie"];
            if (userCookie != null)
            {
                ViewBag.FavoriteCoffee = userCookie.Values["FavoriteCoffee"];
            }

            HttpCookie quantityCookie = Request.Cookies["ProductQuantity"];
            if (quantityCookie != null)
            {
                ViewBag.Quantity = quantityCookie.Value;
            }

            return View();
        }
    }
}