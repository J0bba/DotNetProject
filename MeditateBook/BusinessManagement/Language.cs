using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class Language
    {
        public static bool CreateLanguage(DBO.Language language)
        {
            return DataAccess.Language.CreateLanguage(language);
        }

        public static bool DeleteLanguage(int id)
        {
            return DataAccess.Language.DeleteLanguage(id);
        }

        public static bool UpdateLanugage(DBO.Language language)
        {
            return DataAccess.Language.UpdateLanguage(language);
        }

        public static DBO.Language GetLanguageById(int id)
        {
            return DataAccess.Language.GetLanguageById(id);
        }

        public static List<DBO.Language> GetListLanguage()
        {
            return DataAccess.Language.GetListLanguage();
        }
    }
}