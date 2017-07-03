using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class MessageController : _BaseController
    {
        // GET: Message
        public ActionResult Index()
        {
            int userId = Int32.Parse(HttpContext.Session["UserID"].ToString());
            List<DBO.Message> messages = BusinessManagement.Message.GetListMessageByUser(userId);
            List<DBO.Conversation> conversations = new List<DBO.Conversation>();
            foreach (var message in messages)
            {
                if (message.IdReceiver != userId)
                    addToConv(message, BusinessManagement.User.GetUserById(message.IdReceiver), ref conversations);
                else 
                    addToConv(message, BusinessManagement.User.GetUserById(message.IdSender), ref conversations);
            }
            return View(conversations);
        }

        public void addToConv(DBO.Message message, DBO.User user, ref List<DBO.Conversation> conversations)
        {
            foreach (var conversation in conversations)
            {
                if (conversation.FriendName.Equals(user.Firstname + " " + user.Lastname))
                {
                    if (conversation.LastMessageDate < message.Date)
                    {
                        conversation.LastMessageDate = message.Date;
                        conversation.LastMessageContent = message.Content;
                        conversation.wasRead = message.IdSender == user.Id ? message.IsSeen : true;
                    }
                    return;
                }
            }
            
            conversations.Add(new DBO.Conversation()
            {
                FriendId = user.Id,
                FriendName = user.Firstname + " " + user.Lastname,
                LastMessageDate = message.Date,
                LastMessageContent = message.Content,
                wasRead = message.IdSender == user.Id ? message.IsSeen : true
            });
            
        }

        public ActionResult Conversation(int friend_id)
        {
            List<DBO.Message> list = BusinessManagement.Message.GetConversationMessageList(Int32.Parse(HttpContext.Session["UserID"].ToString()), friend_id);

            
            return View(list);
        }
        [HttpPost]
        public ActionResult Conversation(int friend_id, int userId=0)
        {
            int user_id = Int32.Parse(HttpContext.Session["UserID"].ToString());
            DBO.Message newMessage = new DBO.Message()
            {
                Content = Request["Content"],
                Date = DateTime.Now,
                IdReceiver = friend_id,
                IdSender = user_id,
                IsSeen = false
            };
            if (!BusinessManagement.Message.CreateMessage(newMessage))
            {
                ViewBag.Error = Resources.Views.Message.Conversation.error_send;
            }
            return View(BusinessManagement.Message.GetConversationMessageList(user_id, friend_id));
        }
    }
}