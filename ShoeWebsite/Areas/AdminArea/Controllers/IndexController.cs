using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeWebsite.Areas.AdminArea.Controllers
{
    public class IndexController : Controller
    {
        // GET: AdminArea/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}