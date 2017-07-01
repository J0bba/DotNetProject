using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeditateBook.Models
{
    public class ArticlesListViewModel
    {
        public List<DBO.Article> ListArticle { get; set; }
    }

    public class ArticleViewModel
    {
        public DBO.Article Article { get; set; }
    }
}
