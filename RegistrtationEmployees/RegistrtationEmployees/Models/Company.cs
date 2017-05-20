using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        public string CompanyName { get; set; }

        public int Size { get; set; }
            
        public string CompanyForm { get; set; }

    }
}