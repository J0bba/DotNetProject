using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class Article
    {
        public static bool CreateArticle(ref DBO.Article article)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article newArticle = new T_Article()
                    {
                        title = article.Title,
                        content = article.Content,
                        id_creator = article.IdCreator,
                        created_date = article.CreatedDate,
                        validated = article.Validated
                    };
                    bdd.T_Article.Add(newArticle);
                    bdd.SaveChanges();
                    article.Id = newArticle.id;
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public static bool DeleteArticle(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Article.Remove(bdd.T_Article.Where(a => a.id == id).FirstOrDefault());
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

        public static bool UpdateArticle(DBO.Article article)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article oldarticle = bdd.T_Article.Where(x => x.id == article.Id).FirstOrDefault();
                    if (oldarticle != null)
                    {
                        oldarticle.title = article.Title;
                        oldarticle.content = article.Content;
                        oldarticle.id_creator = article.IdCreator;
                        oldarticle.validated = article.Validated;
                        oldarticle.created_date = article.CreatedDate;

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

        public static DBO.Article GetArticle(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Article article = bdd.T_Article.Where(x => x.id == id).FirstOrDefault();
                    if (article != null)
                    {
                        DBO.Article result = new DBO.Article()
                        {
                            Id = article.id,
                            Title = article.title,
                            Content = article.content,
                            CreatedDate = article.created_date,
                            IdCreator = article.id_creator,
                            Validated = article.validated
                        };
                        return result;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }

        public static List<DBO.Article> GetListArticle()
        {
            List<DBO.Article> result = new List<DBO.Article>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Article> list = bdd.T_Article.ToList();
                    foreach (T_Article article in list)
                    {
                        DBO.Article newArticle = new DBO.Article()
                        {
                            Id = article.id,
                            Title = article.title,
                            Content = article.content,
                            CreatedDate = article.created_date,
                            Validated = article.validated,
                            IdCreator = article.id_creator
                        };
                        result.Add(newArticle);
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

        public static List<DBO.Article> GetListArticleByUser(long user_id)
        {
            List<DBO.Article> result = new List<DBO.Article>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Article> list = bdd.T_Article.Where(x => x.id_creator == user_id).ToList();
                    foreach (T_Article article in list)
                    {
                        DBO.Article newArticle = new DBO.Article()
                        {
                            Id = article.id,
                            Title = article.title,
                            Content = article.content,
                            CreatedDate = article.created_date,
                            Validated = article.validated,
                            IdCreator = article.id_creator
                        };
                        result.Add(newArticle);
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

        public static List<DBO.Article> GetListArticleByText(string word)
        {
            List<DBO.Article> result = new List<DBO.Article>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Article> list = bdd.T_Article.Where(x => x.content.Contains(word) || x.title.Contains(word)).ToList();
                    foreach (T_Article article in list)
                    {
                        DBO.Article newArticle = new DBO.Article()
                        {
                            Id = article.id,
                            Title = article.title,
                            Content = article.content,
                            CreatedDate = article.created_date,
                            Validated = article.validated,
                            IdCreator = article.id_creator
                        };
                        result.Add(newArticle);
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

        public static List<Tuple<DBO.Article, List<DBO.Language>>> GetListArticleWithMissingTrans()
        {
            List<Tuple<DBO.Article, List<DBO.Language>>> result = new List<Tuple<DBO.Article, List<DBO.Language>>>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    var list = bdd.T_Article.GroupJoin(bdd.T_Translation, article => article.id, translation => translation.id_article, (article, translation) => new { article, translation }).ToList();
                    foreach (var elm in list)
                    {
                        List<DBO.Language> languages = Language.GetListLanguage();
                        if (elm.translation.Count() != languages.Count)
                        {
                            DBO.Article newArticle = new DBO.Article()
                            {
                                Id = elm.article.id,
                                Title = elm.article.title,
                                Content = elm.article.content,
                                CreatedDate = elm.article.created_date,
                                Validated = elm.article.validated,
                                IdCreator = elm.article.id_creator
                            };
                            foreach (var obj in elm.translation)
                            {
                                foreach (var language in languages)
                                {
                                    if (obj.id_language == language.Id)
                                        languages.Remove(language);
                                }
                            }
                            Tuple<DBO.Article, List<DBO.Language>> item = new Tuple<DBO.Article, List<DBO.Language>>(newArticle, languages);
                            result.Add(item);
                        }
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