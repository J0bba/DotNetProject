using MeditateBook.RSSFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class RSSFeedController : _BaseController
    {
        // GET: RSSFeed
        public ActionResult Index()
        {
            var items = new List<SyndicationItem>();
            List<DBO.Article> articles = BusinessManagement.Article.GetListArticle().OrderByDescending(x => x.CreatedDate).Take(20).ToList();
            foreach (var article in articles)
            {
                var item = new SyndicationItem()
                {
                    Id = article.Id.ToString(),
                    Title = SyndicationContent.CreatePlaintextContent(article.Title),
                    Authors = { new SyndicationPerson(BusinessManagement.User.GetUserById(article.IdCreator).Email) },
                    Content = SyndicationContent.CreateHtmlContent(article.Content),
                    PublishDate = article.CreatedDate
                };
                items.Add(item);
            }

            return new RssFeed(title: "MeditateBook",
                               items: items,
                               contentType: "application/rss+xml",
                               description: "RSSFeed - MeditateBook");
        }
    }
}