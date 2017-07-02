using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MeditateBook.Models;

namespace MeditateBook.Controllers
{
    public class ManageController : _BaseController
    {
        public ActionResult Index()
        {
            ProfileViewModel model = new ProfileViewModel();
            model.User = BusinessManagement.User.GetUserById(Int32.Parse(HttpContext.Session["UserID"].ToString()));
            return View(model);
        }

        public ActionResult ChangePassword()
        {
            ChangePasswordModel model = new ChangePasswordModel();
            model.User = BusinessManagement.User.GetUserById(Int32.Parse(HttpContext.Session["UserID"].ToString()));
            return View(model);
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            return View();
        }
    }
}