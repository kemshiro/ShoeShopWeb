using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeWebsite.Areas.AdminArea.Controllers
{
    public class LoginController : Controller
    {
        // GET: AdminArea/Login
        public ActionResult AdminLogin()
        {
            return View();
        }
    }
}