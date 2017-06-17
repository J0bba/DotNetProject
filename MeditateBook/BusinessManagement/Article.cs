using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class Article
    {
        public static bool CreateArticle(DBO.Article article)
        {
            return DataAccess.Article.CreateArticle(article);
        }

        public static bool DeleteArticle(long id)
        {
            return DataAccess.Article.DeleteArticle(id);
        }

        public static bool UpdateArticle(DBO.Article article)
        {
            return DataAccess.Article.UpdateArticle(article);
        }

        public static DBO.Article GetArticle(long id)
        {
            return DataAccess.Article.GetArticle(id);
        }

        public static List<DBO.Article> GetListArticle()
        {
            return DataAccess.Article.GetListArticle();
        }

        public static List<DBO.Article> GetListArticleByUser(long user_id)
        {
            return DataAccess.Article.GetListArticleByUser(user_id);
        }
    }
}