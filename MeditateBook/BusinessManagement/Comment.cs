using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class Comment
    {
        public static bool CreateComment(DBO.Comment comment)
        {
            return DataAccess.Comment.CreateComment(comment);
        }

        public static bool DeteleComment(long id)
        {
            return DataAccess.Comment.DeleteComment(id);
        }

        public static bool UpdateComment(DBO.Comment comment)
        {
            return DataAccess.Comment.UpdateComment(comment);
        }

        public static List<DBO.Comment> GetListCommentByArticle(long article_id)
        {
            return DataAccess.Comment.GetListCommentByArticle(article_id);
        }
    }
}