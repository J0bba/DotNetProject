using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class LanguageController : _BaseController
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }
    }
}