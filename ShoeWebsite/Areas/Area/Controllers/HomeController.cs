using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoeWebsite.Areas.Area.Models;

namespace ShoeWebsite.Areas.Area.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Product> products = new List<Product>()
            {
            new Product { id = 1, name = "Adidas", price = "$120" },
            new Product { id = 2, name = "Adidas", price = "$120" },
            new Product { id = 3, name = "Adidas", price = "$120" },
            new Product { id = 4, name = "Adidas", price = "$120" },
            new Product { id = 5, name = "Adidas", price = "$120" },
            new Product { id = 6, name = "Adidas", price = "$120" }

            };

            return View(products);
        }

        public ActionResult Single()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CheckOut()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Shop()
        {
            return View();
        }
    }
}