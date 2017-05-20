using RegistrtationEmployees.Mappers;
using RegistrtationEmployees.Models;
using RegistrtationEmployees.Setters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace RegistrtationEmployees.dao
{
    public class adoCompany:adoTemplate<Company>
    {
        private Dictionary<string, string> queryDB = new Dictionary<string, string>()
        {
            {"getAll", "SELECT CompanyID, CompanyName, CompanyForm, Size FROM Company" },
            {"create", "INSERT INTO Company (CompanyName, Size, CompanyForm) VALUES "
                    + "('{0}', '{1}', '{2}')" },
            {"update", "UPDATE Company SET CompanyName='{0}', Size='{1}', CompanyForm='{2}' WHERE CompanyID= {3}" },
            {"delete", "DELETE FROM Company WHERE  CompanyID= {0}" }

        };
        public override List<Company> getAll(SqlConnection connection)
        {
            string query;
            queryDB.TryGetValue("getAll", out query);
            return base.getAll(connection, query, new  CompanyMapper());
        }
        public override void createOrUpdate(SqlConnection connection, Company company)
        {
            string query;
            if (company.CompanyID == 0)
                queryDB.TryGetValue("create", out query);
            else
                queryDB.TryGetValue("update", out query);

            base.createOrUpdate(connection, query, new CompanySetter(), company);

        }
        public override void delete(SqlConnection connectinon, int id)
        {
            string query;
            queryDB.TryGetValue("delete", out query);
            base.delete(connectinon, string.Format(query, id));
        }
    }
}