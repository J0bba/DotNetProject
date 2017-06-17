using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class ArticleAttach
    {
        public static bool CreateArticleAttach(DBO.ArticleAttach articleAttach)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article_Attach newArticleAttach = new T_Article_Attach()
                    {
                        id_article = articleAttach.IdArticle,
                        file_path = articleAttach.FilePath
                    };
                    bdd.T_Article_Attach.Add(newArticleAttach);
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

        public static bool DeleteArticleAttach(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Article_Attach.Remove(bdd.T_Article_Attach.Where(x => x.id == id).FirstOrDefault());
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

        public static bool UpdateArticleAttach(DBO.ArticleAttach articleAttach)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article_Attach old = bdd.T_Article_Attach.Where(x => x.id == articleAttach.Id).FirstOrDefault();
                    if (old != null)
                    {
                        old.id_article = articleAttach.IdArticle;
                        old.file_path = articleAttach.FilePath;
                        bdd.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public static List<DBO.ArticleAttach> GetListArticleAttachByArticle(long article_id)
        {
            List<DBO.ArticleAttach> result = new List<DBO.ArticleAttach>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Article_Attach> list = bdd.T_Article_Attach.Where(x => x.id_article == article_id).ToList();
                    foreach (T_Article_Attach ArticleAttach in list)
                    {
                        DBO.ArticleAttach newAttach = new DBO.ArticleAttach()
                        {
                            Id = ArticleAttach.id,
                            IdArticle = ArticleAttach.id_article,
                            FilePath = ArticleAttach.file_path
                        };
                        result.Add(newAttach);
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