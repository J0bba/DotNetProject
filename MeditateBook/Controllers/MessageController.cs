using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeditateBook.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            int userId = Int32.Parse(HttpContext.Session["UserID"].ToString());
            System.Diagnostics.Debug.WriteLine("User: " + userId);
            List<DBO.Message> messages = BusinessManagement.Message.GetListMessageByUser(userId);
            List<DBO.Conversation> conversations = new List<DBO.Conversation>();
            foreach (var message in messages)
            {
                if (message.IdReceiver != userId)
                    addToConv(message, BusinessManagement.User.GetUserById(message.IdReceiver), ref conversations);
                else 
                    addToConv(message, BusinessManagement.User.GetUserById(message.IdSender), ref conversations);
            }
            System.Diagnostics.Debug.WriteLine("starting to print");
            foreach (var conv in conversations)
                System.Diagnostics.Debug.WriteLine(conv.FriendName);
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
            ViewBag.sender = BusinessManagement.User.GetUserById(friend_id);
            
            return View();
        }
    }
}