using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class Message
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long IdSender { get; set; }
        public long IdReceiver { get; set; }
        public DateTime Date { get; set; }
    }
}