using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

namespace MeditateBook.BusinessManagement
{
    public class User
    {

        public static string Encrypt(string clearPass)
        {
            if (clearPass == null) throw new ArgumentException();
            var data = Encoding.Unicode.GetBytes(clearPass);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string encrypted)
        {
            if (encrypted == null) throw new ArgumentException();
            byte[] data = Convert.FromBase64String(encrypted);
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.Unicode.GetString(decrypted);
        }
        public static bool CreateUser(DBO.User user)
        {
            user.Password = Encrypt(user.Password);
            return DataAccess.User.CreateUser(user);
        }

        public static bool DeleteUser(long id)
        {
            return DataAccess.User.DeleteUser(id);
        }

        public static bool UpdateUser(DBO.User user)
        {
            user.Password = Encrypt(user.Password);
            return DataAccess.User.UpdateUser(user);
        }

        public static DBO.User GetUserByUd(long id)
        {
            DBO.User user = DataAccess.User.GetUserById(id);
            user.Password = Decrypt(user.Password);
            return DataAccess.User.GetUserById(id);
        }
        public static bool ValidateUser(string username, string password)
        {
            string userPass = DataAccess.User.GetPasswordByUser(username);
            string pass = Decrypt(userPass);
            return password.Equals(pass);
        }

        public static long getIdByName(string username)
        {
            DBO.User user = DataAccess.User.GetUserByName(username);
            return user.Id;
        }
    }
}