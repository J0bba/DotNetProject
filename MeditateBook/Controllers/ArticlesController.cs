using MeditateBook.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
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
            model.CurrentLang = Thread.CurrentThread.CurrentUICulture.ToString().ToLower();
            model.ListArticle = BusinessManagement.Article.GetListArticle();
            List<List<DBO.Translation>> translations = new List<List<DBO.Translation>>();
            if (!model.CurrentLang.Equals("fr-fr"))
                foreach (var article in model.ListArticle)
                    translations.Add(BusinessManagement.Translation.GetListValidatedTranslationByArticle(article.Id));
            model.ListTranslations = translations;
            return View(model);
        }

        public ActionResult Article(int id, int translation_id = -1)
        {
            ArticleViewModel model = new ArticleViewModel();
            model.Article = BusinessManagement.Article.GetArticle(id);
            model.User = BusinessManagement.User.GetUserById(model.Article.IdCreator);
            if (translation_id != -1)
            {
                model.Translation = BusinessManagement.Translation.GetTranslationById(translation_id);
                model.Translator = BusinessManagement.User.GetUserById(model.Translation.IdTranslator);
            }
            return View(model);
        }
        

        public ActionResult Submit()
        {
            return View();
        }

        public ActionResult SubmitTraduction()
        {
            return View();
        }

        public ActionResult EditArticle()
        {
            return View();
        }
        
        public ActionResult EditTraduction(long id)
        {
            DBO.Article article = BusinessManagement.Article.GetArticle(id);
            TradArticleModel tradModel = new TradArticleModel();
            tradModel.titleOriginal = article.Title;
            tradModel.contentOriginal = article.Content;
            tradModel.IdOriginal = article.Id;
            List<DBO.Language> listLanguages = BusinessManagement.Language.GetListLanguage();
            tradModel.listLangues = listLanguages;
            return View(tradModel);
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost, ValidateInput(false)]
        public ActionResult EditTraduction(TradArticleModel model)
        {
            model.listLangues = BusinessManagement.Language.GetListLanguage();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = true;
            //verify things that are not possibly verified by ModelState here and change result.
            switch (result)
            {
                case true:
                    DBO.Translation translation = new DBO.Translation { Content = model.Content, IdArticle = model.IdOriginal, IdLanguage = model.Langue, Validated = false };
                    var idCreator = HttpContext.Session["UserID"];
                    if (idCreator != null)
                        translation.IdTranslator = (long)idCreator;
                    BusinessManagement.Translation.CreateTranslation(translation);
                    return RedirectToAction("SubmitTraduction", "Articles");
                default:
                    return View(model);
            }
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost, ValidateInput(false)]
        public ActionResult EditArticle(EditArticleModel model, HttpPostedFileBase file)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = true;
            switch (result)
            {
                case true:
                    DBO.Article article = new DBO.Article { Title = model.Title, Content = model.Content, Validated = false, CreatedDate = DateTime.Now };
                    var idCreator = HttpContext.Session["UserID"];
                    if (idCreator != null)
                        article.IdCreator = (long)idCreator;
                    BusinessManagement.Article.CreateArticle(ref article);

                    if (file != null)
                    {
                        string pic = System.IO.Path.GetFileName(file.FileName);
                        string path = System.IO.Path.Combine(
                                               Server.MapPath("~/images/article"), pic);

                        if (!Directory.Exists("~/images/article"))
                        {
                            Directory.CreateDirectory("~/images/article");
                        }

                        // file is uploaded
                        file.SaveAs(path);
                        DBO.ArticleImage image = new DBO.ArticleImage();
                        image.ImagePath = path;
                        image.Name = pic;
                        image.IdArticle = article.Id;
                        BusinessManagement.ArticleImage.CreateArticleImage(image);
                    }
                    return RedirectToAction("Submit", "Articles");
                case false:
                    ModelState.AddModelError("", "Insertion d'article invalide");
                    return View(model);
                default:
                    ModelState.AddModelError("", "Insertion d'article invalide");
                    return View(model);
            }
        }


    }
}