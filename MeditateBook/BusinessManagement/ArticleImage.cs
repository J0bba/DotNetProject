using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class ArticleImage
    {
        public static bool CreateArticleImage(DBO.ArticleImage articleImage)
        {
            return DataAccess.ArticleImage.CreateArticleImage(articleImage);
        }

        public static bool DeleteArticleImage(long id)
        {
            return DataAccess.ArticleImage.DeleteArticleImage(id);
        }

        public static bool UpdateArticleImage(DBO.ArticleImage articleImage)
        {
            return DataAccess.ArticleImage.UpdateArticleImage(articleImage);
        }

        public static List<DBO.ArticleImage> GetListArticleImageByArticle(long article_id)
        {
            return DataAccess.ArticleImage.GetListArticleImageByArticle(article_id);
        }

        public static List<DBO.ArticleImage> GetListWithWord(string word)
        {
            return DataAccess.ArticleImage.GetListWithWord(word);
        }
    }
}