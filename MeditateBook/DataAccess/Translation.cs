using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class Translation
    {
        public static bool CreateTranslation(DBO.Translation translation)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Translation newTranslation = new T_Translation()
                    {
                        content = translation.Content,
                        id_article = translation.IdArticle,
                        id_language = translation.IdLanguage,
                        id_translator = translation.IdTranslator,
                        validated = translation.Validated
                    };

                    bdd.T_Translation.Add(newTranslation);
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

        public static bool DeleteTranslation(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Translation.Remove(bdd.T_Translation.Where(x => x.id == id).FirstOrDefault());
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

        public static bool UpdateTranslation(DBO.Translation translation)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Translation oldTranslation = bdd.T_Translation.Where(x => x.id == translation.Id).FirstOrDefault();
                    if (oldTranslation != null)
                    {
                        oldTranslation.content = translation.Content;
                        oldTranslation.id_article = translation.IdArticle;
                        oldTranslation.id_language = translation.IdLanguage;
                        oldTranslation.id_translator = translation.IdTranslator;
                        oldTranslation.validated = translation.Validated;

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

        public static List<DBO.Translation> GetListTranslationByArticle(long id_article)
        {
            List<DBO.Translation> result = new List<DBO.Translation>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Translation> translations = bdd.T_Translation.Where(x => x.id_article == id_article).ToList();
                    foreach (T_Translation translation in translations)
                    {
                        DBO.Translation newTranslation = new DBO.Translation()
                        {
                            Content = translation.content,
                            Id = translation.id,
                            IdArticle = translation.id_article,
                            IdLanguage = translation.id_language,
                            IdTranslator = translation.id_translator,
                            Validated = translation.validated
                        };
                        result.Add(newTranslation);
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

        public static List<DBO.Translation> GetListNonValidatedTranslation()
        {
            List<DBO.Translation> result = new List<DBO.Translation>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Translation> translations = bdd.T_Translation.Where(x => x.validated == false).ToList();
                    foreach (T_Translation translation in translations)
                    {
                        DBO.Translation newTranslation = new DBO.Translation()
                        {
                            Content = translation.content,
                            Id = translation.id,
                            IdArticle = translation.id_article,
                            IdLanguage = translation.id_language,
                            IdTranslator = translation.id_translator,
                            Validated = translation.validated
                        };
                        result.Add(newTranslation);
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