using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegistrtationEmployees.Models;
using RegistrtationEmployees.Mappers;
using System.Data.SqlClient;
using RegistrtationEmployees.Setters;

namespace RegistrtationEmployees.dao
{
    public class adoEmployee: adoTemplate<Employee>
    {

        private Dictionary<string, string> queryDB = new Dictionary<string, string>()
        {
            {"getAll", "SELECT EmployeeID, Name, Surname, Lastname, DateHiring, Position, CompanyID FROM employees" },
            {"create", "INSERT INTO employees (Name, Surname, Lastname, DateHiring, Position, CompanyID) VALUES "
                    + "('{0}', '{1}', '{2}', {3}, {4}, {5})" },
            {"update", "UPDATE employees SET Name='{0}', Surname='{1}', Lastname='{2}', DateHiring={3}, Position={4}, CompanyID= {5} "
                    + "WHERE EmployeeID= {6}" },
            {"delete", "DELETE FROM employees WHERE  EmployeeID= {0}" }

        };

        public override List<Employee> getAll(SqlConnection connection)
        {
            string query;
            queryDB.TryGetValue("getAll", out query);
            return base.getAll(connection, query, new EmployeeMapper());
            
        }
        public override void createOrUpdate(SqlConnection connection, Employee employee)
        {
            string query;
            if (employee.EmployeeID==0)
                queryDB.TryGetValue("create", out query);
            else
                queryDB.TryGetValue("update", out query);

            base.createOrUpdate(connection, query, new EmployeeSetter(), employee);

        }
        public override void delete(SqlConnection connectinon, int id)
        {
            string query;
            queryDB.TryGetValue("delete", out query);
            base.delete(connectinon, string.Format(query, id));
        }

    }
}