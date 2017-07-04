using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeditateBook.Models
{
    public class ArticlesListViewModel
    {
        public string CurrentLang { get; set; }
        public List<DBO.Article> ListArticle { get; set; }
        public List<List<DBO.Translation>> ListTranslations { get; set; }
        public DBO.Translation Translation { get; set; }
        public DBO.User Translator { get; set; }
    }

    public class ArticleViewModel
    {
        public DBO.Article Article { get; set; }
        public DBO.User User { get; set; }
        public DBO.Translation Translation { get; set; }
        public DBO.User Translator { get; set; }
        public DBO.ArticleImage Image { get; set; }
    }
}
