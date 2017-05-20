using RegistrtationEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Setters
{
    public class CompanySetter : Setter<Company>
    {
        public string getquery(string query, Company entity)
        {
            if (entity.CompanyID == 0)
            {
                return string.Format(query, entity.CompanyName, entity.Size, entity.CompanyForm);
            }
            else
            {
                return string.Format(query, entity.CompanyName, entity.Size, entity.CompanyForm, entity.CompanyID);

            }
        }
    }
}