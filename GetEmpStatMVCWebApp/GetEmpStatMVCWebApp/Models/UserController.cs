﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetEmpStatMVCWebApp.Controllers
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public int NationalNumber { get; set; }
    }
}