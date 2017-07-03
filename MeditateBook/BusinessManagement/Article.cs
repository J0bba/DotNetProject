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

        public static List<DBO.Article> GetListArticleWithText(string word)
        {
            return DataAccess.Article.GetListArticleByText(word);
        }

        public static List<DBO.Article> GetListArticleBySearch(string searchString)
        {
            var result = new List<DBO.Article>();
            searchString = searchString.ToLower();
            string[] words = searchString.Split();
            foreach (var word in words)
            {
                result = GetListArticleWithText(word);
                foreach (DBO.Article res in result)
                    System.Diagnostics.Debug.WriteLine(res.Title);
                List<DBO.ArticleAttach> attachs = ArticleAttach.GetListWithWord(word);
                foreach(var attach in attachs)
                {
                    var article = GetArticle(attach.IdArticle);
                    if (!isInList(article, result))
                        result.Add(article);
                }
                List<DBO.ArticleImage> images = ArticleImage.GetListWithWord(word);
                foreach (var image in images)
                {
                    var article = GetArticle(image.IdArticle);
                    if (!isInList(article, result))
                        result.Add(article);
                }
            }
            return result;
        }

        private static bool isInList(DBO.Article article, List<DBO.Article> list)
        {
            foreach(var articl in list)
            {
                if (articl.Id == article.Id)
                    return true;
            }
            return false;
        }

        private static List<DBO.Article> MergeList(List<DBO.Article> list1, List<DBO.Article> list2)
        {
            List<DBO.Article> result = list1;
            foreach (var article in list2)
            {
                if (!isInList(article, list1))
                    result.Add(article);
            }
            return result;
        }

        public static List<Tuple<DBO.Article, List<DBO.Language>>> GetListArticleWithMissingTrans()
        {
            return DataAccess.Article.GetListArticleWithMissingTrans();
        }

    }
}