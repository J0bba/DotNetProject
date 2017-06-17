using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.BusinessManagement
{
    public class User
    {
        public static bool CreateUser(DBO.User user)
        {
            // TODO : Password Management
            return DataAccess.User.CreateUser(user);
        }

        public static bool DeleteUser(long id)
        {
            return DataAccess.User.DeleteUser(id);
        }

        public static bool UpdateUser(DBO.User user)
        {
            // TODO : Password Management
            return DataAccess.User.UpdateUser(user);
        }

        public static DBO.User GetUserByUd(long id)
        {
            return DataAccess.User.GetUserById(id);
        }
        public static bool ValidateUser(string username, string password)
        {
            // TODO : Bails de mdp
            return DataAccess.User.ValidateUser(username, password);
        }
    }
}