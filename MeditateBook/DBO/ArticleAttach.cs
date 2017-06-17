using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class ArticleAttach
    {
        public long Id { get; set; }
        public long IdArticle { get; set; }
        public string FilePath { get; set; }
    }
}