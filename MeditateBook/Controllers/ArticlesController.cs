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
                    RedirectToAction("SubmitTraduction", "Article");
                    return View(model);
                case false:
                    ModelState.AddModelError("", "Insertion de traduction invalide");
                    return View(model);
                default:
                    ModelState.AddModelError("", "Insertion de traduction invalide");
                    return View(model);
            }
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
            
            var result = true;
            switch (result)
            {
                case true:
                    DBO.Article article = new DBO.Article { Title = model.Title, Content = model.Content, Validated = false, CreatedDate = DateTime.Now };
                    var idCreator = HttpContext.Session["UserID"];
                    if (idCreator != null)
                        article.IdCreator = (long)idCreator;
                    BusinessManagement.Article.CreateArticle(article);
                    RedirectToAction("Submit", "Article");
                    return View(model);
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