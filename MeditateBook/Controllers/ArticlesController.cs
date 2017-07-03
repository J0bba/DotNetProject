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
    }
}