using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class ArticleImage
    {
        public long Id { get; set; }
        public long IdArticle { get; set; }
        public string ImagePath { get; set; }
    }
}