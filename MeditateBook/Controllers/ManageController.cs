﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MeditateBook.Models;
using System.Collections.Generic;

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
            model.Users = BusinessManagement.User.GetUsersUnderRole(model.User.Id, model.User.Role);
            return View(model);
        }

        public ActionResult EditUser(int id)
        {
            EditRoleViewModel model = new EditRoleViewModel();
            model.User = BusinessManagement.User.GetUserById(id);
            model.Enum = model.User.Role;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUser(int id, EditRoleViewModel model)
        {
            model.User = BusinessManagement.User.GetUserById(id);
            model.User.Role = model.Enum;
            BusinessManagement.User.UpdateUser(model.User);
            return RedirectToAction("ManageUsers", "Manage");
        }

        public ActionResult ShowUser(int id)
        {
            return RedirectToAction("Index", "Profile", new { id = id });
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
            model.Translations = new List<Tuple<DBO.Article, DBO.Translation>>();
            var translations = BusinessManagement.Translation.GetListNonValidatedTranslation();
            foreach (var translation in translations)
                model.Translations.Add(new Tuple<DBO.Article, DBO.Translation>(BusinessManagement.Article.GetArticle(translation.IdArticle), translation));
            List<Tuple<DBO.Article, List<DBO.Language>>> missingTransArticles = BusinessManagement.Article.GetListArticleWithMissingTrans();
            model.MissingTransArticles = missingTransArticles;

            return View(model);
        }

        public ActionResult ValidateTrad(int id)
        {
            DBO.Translation translation = BusinessManagement.Translation.GetTranslationById(id);
            translation.Validated = true;
            BusinessManagement.Translation.UpdateTranslation(translation);
            return RedirectToAction("ManageTranslations", "Manage");
        }

        public ActionResult ShowTrad(int id)
        {
            ArticleViewModel model = new ArticleViewModel();
            model.Translation = BusinessManagement.Translation.GetTranslationById(id);
            model.Translator = BusinessManagement.User.GetUserById(model.Translation.IdTranslator);
            model.Article = BusinessManagement.Article.GetArticle(model.Translation.IdArticle);
            model.User = BusinessManagement.User.GetUserById(model.Article.IdCreator);
            model.Image = BusinessManagement.ArticleImage.GetArticleImageByArticle(id);

            return View(model);
        }

        public ActionResult DeleteTrad(int id)
        {
            BusinessManagement.Translation.DeleteTranslation(id);
            return RedirectToAction("ManageTranslations", "Manage");
        }
    }
}