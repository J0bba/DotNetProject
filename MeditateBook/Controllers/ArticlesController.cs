using MeditateBook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            int i = 0;
            if (HttpContext.Session["ListAttach" + i] != null)
            {
                while (HttpContext.Session["ListAttach" + i] != null)
                {
                    HttpContext.Session["ListAttach" + i] = null;
                    i++;
                }
            }
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
            model.Image = BusinessManagement.ArticleImage.GetArticleImageByArticle(id);
            model.User = BusinessManagement.User.GetUserById(model.Article.IdCreator);
            if (translation_id != -1)
            {
                model.Translation = BusinessManagement.Translation.GetTranslationById(translation_id);
                model.Translator = BusinessManagement.User.GetUserById(model.Translation.IdTranslator);
            }
            model.listAttach = BusinessManagement.ArticleAttach.GetListArticleAttachByArticle(id);
            return View(model);
        }
        

        public ActionResult Submit()
        {
            int i = 0;
            if (HttpContext.Session["ListAttach" + i] != null)
            {
                while (HttpContext.Session["ListAttach" + i] != null)
                {
                    HttpContext.Session["ListAttach" + i] = null;
                    i++;
                }
            }
            return View();
        }

        public ActionResult SubmitTraduction()
        {
            return View();
        }

        public ActionResult EditArticle()
        {
            return View(new EditArticleModel());
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
                        string dir = Server.MapPath("~/images/article");
                        string path = System.IO.Path.Combine(dir, pic);

                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }

                        // file is uploaded
                        file.SaveAs(path);
                        DBO.ArticleImage image = new DBO.ArticleImage();
                        image.ImagePath = path;
                        image.Name = pic;
                        image.IdArticle = article.Id;
                        BusinessManagement.ArticleImage.CreateArticleImage(image);
                    }
                    string dirAttach = Server.MapPath("~/images/attach");
                    int i = 0;
                    if (HttpContext.Session["ListAttach" + i] != null)
                    {
                        while (HttpContext.Session["ListAttach" + i] != null)
                        {
                            DBO.ArticleAttach articleAttach = new DBO.ArticleAttach();
                            articleAttach.Name = (string)HttpContext.Session["ListAttach" + i];
                            articleAttach.FilePath = Path.Combine(dirAttach, articleAttach.Name);
                            articleAttach.IdArticle = article.Id;
                            BusinessManagement.ArticleAttach.CreateArticleAttach(articleAttach);
                            i++;
                        }
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

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost, ValidateInput(false)]
        public ActionResult AddAttach(HttpPostedFileBase file, EditArticleModel model)
        {
            if (file != null)
            {
                string attach = System.IO.Path.GetFileName(file.FileName);
                string dir = Server.MapPath("~/images/attach");
                string path = System.IO.Path.Combine(dir, attach);

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                int i = 0;
                if (HttpContext.Session["ListAttach" + i] != null)
                {
                    while (HttpContext.Session["ListAttach" + i] != null)
                        i++;
                }
                HttpContext.Session["ListAttach" + i] = attach;
            }
            return RedirectToAction("EditArticle", "Articles", model);
        }

        public ActionResult DownloadAttach(long id, long idArticle)
        {
            List<DBO.ArticleAttach> list = BusinessManagement.ArticleAttach.GetListArticleAttachByArticle(idArticle);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                    return File(list[i].FilePath, Server.UrlEncode(list[i].FilePath));
            }
            return RedirectToAction("Index", "Home");
        }
    }
}