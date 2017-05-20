using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateHiring { get; set; }

        public Position Position { get; set; }

        public int CompanyID { get; set; }
    }
}