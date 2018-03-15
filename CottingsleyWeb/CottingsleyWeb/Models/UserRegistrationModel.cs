﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CottingsleyWeb.Models
{
    public class UserRegistrationModel
    {
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public string Designation { get; set; }
        public string SchoolLocation { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }
    }
}