using MeditateBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class ArticlesController : _BaseController
    {
        // GET: Articles
        public ActionResult Index()
        {
            ArticlesListViewModel model = new ArticlesListViewModel();
            model.ListArticle = BusinessManagement.Article.GetListArticle();
            return View(model);
        }

        public ActionResult Article(int id = 0)
        {
            ArticleViewModel model = new ArticleViewModel();
            model.Article = BusinessManagement.Article.GetArticle(id);
            return View(model);
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost, ValidateInput(false)]
        public ActionResult Submit(EditArticleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Ceci ne comptabilise pas les échecs de connexion pour le verrouillage du compte
            // Pour que les échecs de mot de passe déclenchent le verrouillage du compte, utilisez shouldLockout: true
            /*var result = Membership.ValidateUser(model.Email, model.Password);
            switch (result)
            {
                case true:
                    HttpContext.Session["UserID"] = BusinessManagement.User.getIdByName(model.Email);
                    FormsAuthentication.RedirectFromLoginPage(model.Email, false);
                    return returnUrl == null ? RedirectToAction("Index", "Home") : RedirectToLocal(returnUrl);
                //case SignInStatus.LockedOut:
                //    return View("Lockout");
                //case SignInStatus.RequiresVerification:
                //    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case false:
                    ModelState.AddModelError("", "Tentative de connexion non valide.");
                    return View(model);
                default:
                    ModelState.AddModelError("", "Tentative de connexion non valide.");
                    return View(model);
            }*/
            DBO.Article article = new DBO.Article { Title = model.Title, Content = model.Content, Validated = false, CreatedDate = DateTime.Now };
            var idCreator = HttpContext.Session["UserID"];
            if (idCreator != null)
                article.IdCreator = (long)idCreator;
            BusinessManagement.Article.CreateArticle(article);
            return View();
        }


        public ActionResult EditArticle()
        {
            return View();
        }
        
        public ActionResult EditTraduction(long id)
        {
            DBO.Article article = BusinessManagement.Article.GetArticle(id);
            TradArticleModel tradModel = new TradArticleModel(article);
            return View(tradModel);
        }
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost, ValidateInput(false)]
        public ActionResult SubmitTraduction(TradArticleModel model)
        {

            DBO.Translation translation = new DBO.Translation { Content = model.Content, IdArticle = model.Id, IdLanguage = 1 };
            var idCreator = HttpContext.Session["UserID"];
            if (idCreator != null)
                translation.IdTranslator = (long)idCreator;
            BusinessManagement.Translation.CreateTranslation(translation);
            return View();
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost, ValidateInput(false)]
        public ActionResult EditArticle(EditArticleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Ceci ne comptabilise pas les échecs de connexion pour le verrouillage du compte
            // Pour que les échecs de mot de passe déclenchent le verrouillage du compte, utilisez shouldLockout: true
            var result = true;
            if (model.Title != "" && model.Content != "")
            {
                result = false;
            }
            //var result = Membership.ValidateUser(model.Email, model.Password);
            switch (result)
            {
                case true:
                    //HttpContext.Session["UserID"] = BusinessManagement.User.getIdByName(model.Email);
                    //FormsAuthentication.RedirectFromLoginPage(model.Email, false);
                    //return returnUrl == null ? RedirectToAction("Index", "Home") : RedirectToLocal(returnUrl);
                    DBO.Article article = new DBO.Article { Title = model.Title, Content = model.Content, Validated = false, CreatedDate = DateTime.Now };
                    var idCreator = HttpContext.Session["UserID"];
                    if (idCreator != null)
                        article.IdCreator = (long)idCreator;
                    BusinessManagement.Article.CreateArticle(article);
                    RedirectToAction("Submit", "Article");
                    return View(model);
                case false:
                    ModelState.AddModelError("", "Tentative de connexion non valide.");
                    return View(model);
                default:
                    ModelState.AddModelError("", "Tentative de connexion non valide.");
                    return View(model);
            }
            return View();

        }
    }
}