﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maxis.ViewModels
{
    public class EditUserViewModel
    {
        public long UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public long RoleId { get; set; }

        public string Mobile { get; set; }

        public string Department { get; set; }

        public string Title { get; set; }

        public string Status { get; set; }

        public Nullable<System.DateTime> DateCreated { get; set; }

        public Nullable<System.DateTime> DateModified { get; set; }
    }
}