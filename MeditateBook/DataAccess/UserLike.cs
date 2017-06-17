using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class UserLike
    {
        public static bool CreateUserLike(DBO.UserLike userLike)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_User_Like newUserLike = new T_User_Like()
                    {
                        id_article = userLike.IdArticle,
                        id_user = userLike.IdUser
                    };

                    bdd.T_User_Like.Add(newUserLike);
                    bdd.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public static bool DeleteUserLike(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_User_Like.Remove(bdd.T_User_Like.Where(x => x.id == id).FirstOrDefault());
                    bdd.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public static List<DBO.UserLike> GetListUserLikeByArticle(long article_id)
        {
            List<DBO.UserLike> result = new List<DBO.UserLike>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_User_Like> list = bdd.T_User_Like.Where(x => x.id_article == article_id).ToList();
                    foreach (T_User_Like userLike in list)
                    {
                        DBO.UserLike newLike = new DBO.UserLike()
                        {
                            Id = userLike.id,
                            IdArticle = userLike.id_article,
                            IdUser = userLike.id_user
                        };
                        result.Add(newLike);
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return result;
            }
        }
    }
}