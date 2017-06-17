using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class Comment
    {
        public static bool CreateComment(DBO.Comment comment)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Comment newComment = new T_Comment()
                    {
                        content = comment.Content,
                        id_user = comment.IdUser,
                        id_article = comment.IdArticle,
                        date = comment.Date
                    };
                    bdd.T_Comment.Add(newComment);
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

        public static bool DeleteComment(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Comment.Remove(bdd.T_Comment.Where(x => x.id == id).FirstOrDefault());
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

        public static bool UpdateComment(DBO.Comment comment)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Comment oldComment = bdd.T_Comment.Where(x => x.id == comment.Id).FirstOrDefault();
                    oldComment.content = comment.Content;
                    oldComment.id_article = comment.IdArticle;
                    oldComment.id_user = comment.IdUser;
                    oldComment.date = comment.Date;
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

        public static List<DBO.Comment> GetListCommentByArticle(long article_id)
        {
            List<DBO.Comment> result = new List<DBO.Comment>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Comment> list = bdd.T_Comment.Where(x => x.id_article == article_id).ToList();
                    foreach (T_Comment comment in list)
                    {
                        DBO.Comment newComment = new DBO.Comment()
                        {
                            Id = comment.id,
                            Content = comment.content,
                            IdArticle = comment.id_article,
                            Date = comment.date,
                            IdUser = comment.id_user
                        };
                        result.Add(newComment);
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