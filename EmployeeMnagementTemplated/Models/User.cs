using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMnagementTemplated.Models
{
    public class EmployeeUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}