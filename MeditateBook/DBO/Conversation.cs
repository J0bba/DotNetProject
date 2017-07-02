using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class Conversation
    {
        public long FriendId { get; set; }
        public string FriendName { get; set; }
        public DateTime LastMessageDate { get; set; }
        public string LastMessageContent { get; set; }
        public bool wasRead { get; set; }
    }
}