using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class Message
    {
        public static bool CreateMessage(DBO.Message message)
        {
            return DataAccess.Message.CreateMessage(message);
        }

        public static bool DeleteMessage(long id)
        {
            return DataAccess.Message.DeleteMessage(id);
        }

        public static bool UpdateMessage(DBO.Message message)
        {
            return DataAccess.Message.UpdateMessage(message);
        }

        public static List<DBO.Message> GetListMessageByUser(long user_id)
        {
            return DataAccess.Message.GetListMessageByUser(user_id);
        }

        public static List<DBO.Message> GetConversationMessageList(int user_id, int friend_id)
        {
            return DataAccess.Message.GetConversationsMessageList(user_id, friend_id);
        }
    }
}