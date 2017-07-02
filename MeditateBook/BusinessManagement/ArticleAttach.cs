using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class ArticleAttach
    {
        public static bool CreateArticleAttach(DBO.ArticleAttach articleAttach)
        {
            return DataAccess.ArticleAttach.CreateArticleAttach(articleAttach);
        }

        public static bool DeleteArticleAttach(long id)
        {
            return DataAccess.ArticleAttach.DeleteArticleAttach(id);
        }

        public static bool UpdateArticleAttach(DBO.ArticleAttach articleAttach)
        {
            return DataAccess.ArticleAttach.UpdateArticleAttach(articleAttach);
        }

        public static List<DBO.ArticleAttach> GetListArticleAttachByArticle(long article_id)
        {
            return DataAccess.ArticleAttach.GetListArticleAttachByArticle(article_id);
        }

        public static List<DBO.ArticleAttach> GetListWithWord(string word)
        {
            return DataAccess.ArticleAttach.GetListWithWord(word);
        }
    }
}