﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class HomeController : _BaseController
    {
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine(Thread.CurrentThread.CurrentUICulture);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}