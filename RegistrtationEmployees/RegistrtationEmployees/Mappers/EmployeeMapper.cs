using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RegistrtationEmployees.Models;

namespace RegistrtationEmployees.Mappers
{
    public class EmployeeMapper : Mapper<Employee>
    {
        public Employee mapRow(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.EmployeeID = (int)reader["EmployeeID"];
            employee.Name = reader.GetString(1);
            employee.Surname = reader.GetString(2);
            employee.Lastname = reader.GetString(3);
            employee.DateHiring = reader.GetDateTime(4);
            employee.Position = (Position)reader["Position"];
            employee.CompanyID = (int)reader["CompanyID"]; 
            return employee; 
        }
    }
}