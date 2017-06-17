using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public long IdCreator { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Validated { get; set; }

    }
}