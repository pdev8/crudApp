﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult MainPage()
        {
            return View();
        }
    }
}