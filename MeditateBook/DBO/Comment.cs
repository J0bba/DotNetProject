using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class Comment
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long IdUser { get; set; }
        public long IdArticle { get; set; }
        public DateTime Date { get; set; }
    }
}