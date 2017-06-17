using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class UserLike
    {
        public static bool CreateUserLike(DBO.UserLike userLike)
        {
            return DataAccess.UserLike.CreateUserLike(userLike);
        }

        public static bool DeleteUserLike(long id)
        {
            return DataAccess.UserLike.DeleteUserLike(id);
        }

        public static List<DBO.UserLike> GetListUserLikeByArticle(long id_article)
        {
            return DataAccess.UserLike.GetListUserLikeByArticle(id_article);
        }
    }
}