using MeditateBook.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class SearchController : _BaseController
    {
        // POST: Search
        public ActionResult Index(string searchString)
        {
            List<DBO.Article> articles = BusinessManagement.Article.GetListArticleBySearch(searchString);
            return View(articles);
        }
    }
}