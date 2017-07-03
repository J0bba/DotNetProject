using MeditateBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index(long id)
        {
            ProfileViewModel model = new ProfileViewModel();
            model.User = BusinessManagement.User.GetUserById(id);
            model.idCurrentUser = (long)HttpContext.Session["UserID"];
            return View(model);
        }
    }
}