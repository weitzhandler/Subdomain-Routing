﻿using System.Web.Mvc;

namespace Subdomain.Routing.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(string tenant)
        {
            ViewData["Message"] = string.Format("And the tenant is '{0}'.", tenant);
            return View();
        }
    }
}
