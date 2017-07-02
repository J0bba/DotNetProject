using MeditateBook.Models;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class SearchController : _BaseController
    {
        // POST: Search
        public ActionResult Index(string searchString)
        {
            SearchViewModel model = new SearchViewModel();
            model.searchedText = searchString;
            model.Results = BusinessManagement.Article.GetListArticleBySearch(searchString);
            return View(model);
        }
    }
}