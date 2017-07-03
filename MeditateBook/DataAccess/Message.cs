using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class Message
    {
        public static bool CreateMessage(DBO.Message message)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Message newMessage = new T_Message()
                    {
                        content = message.Content,
                        date = message.Date,
                        id_receiver = message.IdReceiver,
                        id_sender = message.IdSender,
                        isSeen = message.IsSeen
                    };

                    bdd.T_Message.Add(newMessage);
                    bdd.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public static bool DeleteMessage(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_Message.Remove(bdd.T_Message.Where(x => x.id == id).FirstOrDefault());
                    bdd.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public static bool UpdateMessage(DBO.Message message)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Message oldMessage = bdd.T_Message.Where(x => x.id == message.Id).FirstOrDefault();
                    oldMessage.content = message.Content;
                    oldMessage.date = message.Date;
                    oldMessage.id_receiver = message.IdReceiver;
                    oldMessage.id_sender = message.IdSender;
                    oldMessage.isSeen = message.IsSeen;
                    bdd.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }

        public static List<DBO.Message> GetListMessageByUser(long user_id)
        {
            List<DBO.Message> result = new List<DBO.Message>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    List<T_Message> list = bdd.T_Message.Where(x => x.id_sender == user_id || x.id_receiver == user_id).ToList();
                    foreach (T_Message message in list)
                    {
                        DBO.Message newMessage = new DBO.Message()
                        {
                            Content = message.content,
                            Date = message.date,
                            Id = message.id,
                            IdReceiver = message.id_receiver,
                            IdSender = message.id_sender,
                            IsSeen = message.isSeen.Value
                        };
                        result.Add(newMessage);
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return result;
            }
        }

        public static List<DBO.Message> GetConversationsMessageList(int user_id, int friend_id)
        {
            List<DBO.Message> result = new List<DBO.Message>();
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities()) {
                    List<T_Message> list = bdd.T_Message.Where(x => ((x.id_receiver == user_id && x.id_sender == friend_id) || (x.id_receiver == friend_id && x.id_sender == user_id))).OrderBy(x => x.date).ToList();
                    foreach (T_Message message in list)
                    {
                        DBO.Message newMessage = new DBO.Message()
                        {
                            Content = message.content,
                            Date = message.date,
                            Id = message.id,
                            IdReceiver = message.id_receiver,
                            IdSender = message.id_sender,
                            IsSeen = message.isSeen.Value
                        };
                        result.Add(newMessage);
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return result;
            }
        }

        public static bool DoesUserHaveNewMessage(int user_id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_Message message = bdd.T_Message.Where(x => x.id_receiver == user_id && x.isSeen == false).FirstOrDefault();
                    return message != null;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return false;
            }
        }
    }
}