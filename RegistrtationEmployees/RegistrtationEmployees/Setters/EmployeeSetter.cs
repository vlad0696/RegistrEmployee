using RegistrtationEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Setters
{
    public class EmployeeSetter : Setter<Employee>
    {
        public string getquery(string query, Employee entity)
        {
            if (entity.EmployeeID==0)
                query=  string.Format(query, entity.Name, entity.Surname, entity.Lastname, 123,(int)entity.Position, entity.CompanyID);
            else
                query = string.Format(query, entity.Name, entity.Surname, entity.Lastname, 123, (int)entity.Position, entity.CompanyID, entity.EmployeeID);

            return query;
        }
    }
}