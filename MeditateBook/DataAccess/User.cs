﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DataAccess
{
    public class User
    {
        public static bool CreateUser(DBO.User user)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_User newUser = new T_User()
                    {
                        email = user.Email,
                        firstname = user.Firstname,
                        lastname = user.Lastname,
                        password = user.Password,
                        role = (int)user.Role
                    };

                    bdd.T_User.Add(newUser);
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

        public static bool DeleteUser(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    bdd.T_User.Remove(bdd.T_User.Where(x => x.id == id).FirstOrDefault());
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

        public static bool UpdateUser(DBO.User user)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_User oldUser = bdd.T_User.Where(x => x.id == user.Id).FirstOrDefault();

                    oldUser.firstname = user.Firstname;
                    oldUser.email = user.Email;
                    oldUser.lastname = user.Lastname;
                    oldUser.password = user.Password;
                    oldUser.role = (int)user.Role;

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

        public static DBO.User GetUserById(long id)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_User user = bdd.T_User.Where(x => x.id == id).FirstOrDefault();
                    if (user != null)
                    {
                        DBO.User result = new DBO.User()
                        {
                            Email = user.email,
                            Firstname = user.firstname,
                            Id = user.id,
                            Lastname = user.lastname,
                            Password = user.password,
                            Role = (BusinessManagement.UserRoles.Roles)user.role
                        };
                        return result;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return null;
            }
        }
        public static string GetPasswordByUser(string email)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_User user = bdd.T_User.Where(x => x.email == email).FirstOrDefault();
                    if (user != null)
                        return user.password;
                    return "";
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return "";
            }
        }

        public static bool ValidateUser(string email, string password)
        {
            try
            {
                using (MeditateBookEntities bdd = new MeditateBookEntities())
                {
                    T_User user = bdd.T_User.Where(x => x.email == email && x.password == password).FirstOrDefault();
                    if (user != null)
                        return true;
                    return false;
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