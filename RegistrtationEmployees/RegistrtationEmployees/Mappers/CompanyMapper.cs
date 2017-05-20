using RegistrtationEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace RegistrtationEmployees.Mappers
{
    public class CompanyMapper : Mapper<Company>
    {
        public Company mapRow(SqlDataReader reader)
        {
            Company company = new Company();
            company.CompanyID = (int)reader["CompanyiD"];
            company.CompanyName = reader.GetString(1);
            company.CompanyForm = reader.GetString(2);
            company.Size = (int)reader["Size"]; 
            return company;
        }
    }
}