using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class UserLike
    {
        public long Id { get; set; }
        public long IdUser { get; set; }
        public long IdArticle { get; set; }
    }
}