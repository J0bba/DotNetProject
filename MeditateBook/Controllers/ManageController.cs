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
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NewPassword.Equals(model.ConfirmNewPassword))
                {
                    model.User = BusinessManagement.User.GetUserById(Int32.Parse(HttpContext.Session["UserID"].ToString()));
                    model.User.Password = model.NewPassword;
                    var result = BusinessManagement.User.UpdateUser(model.User);
                    if (result)
                        return RedirectToAction("Index", "Manage");
                }
            }
            return View(model);
        }

        public ActionResult ManageUsers()
        {
            ManageUsersModel model = new ManageUsersModel();
            model.User = BusinessManagement.User.GetUserById(Int32.Parse(HttpContext.Session["UserID"].ToString()));
            model.Users = BusinessManagement.User.GetUsersUnderRole(model.User.Role);
            return View(model);
        }

        public ActionResult EditUser(int id)
        {
            return RedirectToAction("ManageUsers", "Manage");
        }

        public ActionResult DeleteUser(int id)
        {
            BusinessManagement.User.DeleteUser(id);
            return RedirectToAction("ManageUsers", "Manage");
        }

        public ActionResult ManageTranslations()
        {
            ManageTranslationsModel model = new ManageTranslationsModel();
            model.User = BusinessManagement.User.GetUserById(Int32.Parse(HttpContext.Session["UserID"].ToString()));
            model.Translations = BusinessManagement.Translation.GetListNonValidatedTranslation();
            return View(model);
        }
    }
}