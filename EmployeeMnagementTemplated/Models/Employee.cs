﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMnagementTemplated.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public string Country { get; set; }
    }
}