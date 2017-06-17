using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class Translation
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long IdLanguage { get; set; }
        public long IdArticle { get; set; }
        public long IdTranslator { get; set; }
        public bool Validated { get; set; }
    }
}