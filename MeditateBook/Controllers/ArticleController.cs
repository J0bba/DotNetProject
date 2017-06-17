using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class ArticleController : Controller
    {
       //GET
       public ActionResult Index()
        {
            List<DBO.Article> articles = BusinessManagement.Article.GetListArticle();
            System.Diagnostics.Debug.WriteLine(articles.First().Content);
            return View();
        }
    }
}
