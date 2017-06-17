using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class ArticleImage
    {
        public static bool CreateArticleImage(DBO.ArticleImage articleImage)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article_Image newArticleAttach = new T_Article_Image()
                    {
                        id_article = articleImage.IdArticle,
                        image_path = articleImage.ImagePath
                    };
                    bdd.T_Article_Image.Add(newArticleAttach);
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

        public static bool DeleteArticleImage(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Article_Image.Remove(bdd.T_Article_Image.Where(x => x.id == id).FirstOrDefault());
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

        public static bool UpdateArticleImage(DBO.ArticleImage articleImage)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article_Image old = bdd.T_Article_Image.Where(x => x.id == articleImage.Id).FirstOrDefault();
                    if (old != null)
                    {
                        old.id_article = articleImage.IdArticle;
                        old.image_path = articleImage.ImagePath;
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

        public static List<DBO.ArticleImage> GetListArticleImageByArticle(long article_id)
        {
            List<DBO.ArticleImage> result = new List<DBO.ArticleImage>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Article_Image> list = bdd.T_Article_Image.Where(x => x.id_article == article_id).ToList();
                    foreach (T_Article_Image ArticleImage in list)
                    {
                        DBO.ArticleImage newAttach = new DBO.ArticleImage()
                        {
                            Id = ArticleImage.id,
                            IdArticle = ArticleImage.id_article,
                            ImagePath = ArticleImage.image_path
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