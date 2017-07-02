using MeditateBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class EditArticleController : _BaseController
    {
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
    }

    
}