﻿using MeditateBook.Models;
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
    }
}