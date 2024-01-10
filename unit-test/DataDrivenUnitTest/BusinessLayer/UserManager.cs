﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserManager
    {
        public bool AddUser(string name,string phone,string mail)
        {
            if (name.Length < 4) return false;
            if (!Regex.IsMatch(phone, "[0-9]")) return false;
            if (!mail.Contains("@")) return false;

            return true;
        }
    }
}
