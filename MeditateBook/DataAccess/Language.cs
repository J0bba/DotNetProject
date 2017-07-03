using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class Language
    {
        public static bool CreateLanguage(DBO.Language language)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Language newLanguage = new T_Language()
                    {
                        name = language.Name,
                        shortname = language.ShortName
                    };
                    bdd.T_Language.Add(newLanguage);
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

        public static bool DeleteLanguage(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Language.Remove(bdd.T_Language.Where(x => x.id == id).FirstOrDefault());
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

        public static bool UpdateLanguage(DBO.Language language)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Language oldLanguage = bdd.T_Language.Where(x => x.id == language.Id).FirstOrDefault();
                    if (oldLanguage != null)
                    {
                        oldLanguage.name = language.Name;
                        oldLanguage.shortname = language.ShortName;
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

        public static List<DBO.Language> GetListLanguage()
        {
            List<DBO.Language> result = new List<DBO.Language>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Language> list = bdd.T_Language.ToList();
                    foreach (T_Language language in list)
                    {
                        DBO.Language newLang = new DBO.Language()
                        {
                            Name = language.name,
                            Id = language.id,
                            ShortName = language.shortname
                        };
                        result.Add(newLang);
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

        public static DBO.Language GetLanguageById(int id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Language language = bdd.T_Language.Where(x => x.id == id).FirstOrDefault();

                        DBO.Language newLang = new DBO.Language()
                        {
                            Name = language.name,
                            Id = language.id,
                            ShortName = language.shortname
                        };

                    return newLang;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }
    }
}