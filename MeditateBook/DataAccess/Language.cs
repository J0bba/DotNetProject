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
    }
}