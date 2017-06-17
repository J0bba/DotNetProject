using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class Translation
    {
        public static bool CreateTranslation(DBO.Translation translation)
        {
            return DataAccess.Translation.CreateTranslation(translation);
        }

        public static bool DeleteTranslation(long id)
        {
            return DataAccess.Translation.DeleteTranslation(id);
        }

        public static bool UpdateTranslation(DBO.Translation translation)
        {
            return DataAccess.Translation.UpdateTranslation(translation);
        }

        public static List<DBO.Translation> GetListTranslationByArticle(long id_article)
        {
            return DataAccess.Translation.GetListTranslationByArticle(id_article);
        }

        public static List<DBO.Translation> GetListNonValidatedTranslation()
        {
            return DataAccess.Translation.GetListNonValidatedTranslation();
        }
    }
}