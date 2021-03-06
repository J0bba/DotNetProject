﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeditateBook.DBO
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public MeditateBook.BusinessManagement.UserRoles.Roles Role { get; set; } 
    }
}