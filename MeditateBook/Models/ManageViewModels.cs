﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace MeditateBook.Models
{
    public class ProfileViewModel
    {
        public DBO.User User { get; set; }
    }

    public class ChangePasswordModel
    {
        public DBO.User User { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }

    public class ManageUsersModel
    {
        public DBO.User User { get; set; }
        public List<DBO.User> Users { get; set; }
    }

    public class ManageTranslationsModel
    {
        public DBO.User User { get; set; }
        public List<DBO.Translation> Translations { get; set; }
    }
}