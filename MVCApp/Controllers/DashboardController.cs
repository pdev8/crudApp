using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class DashboardController : Controller
    {

        /*[Route("~/")]*/
        // GET: App
        public ActionResult Trainer()
        {
            return View();
        }
    }
}