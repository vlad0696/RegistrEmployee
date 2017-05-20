using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RegistrtationEmployees.Controllers;
using RegistrtationEmployees.Models;
using RegistrtationEmployees.dao;
namespace RegistrtationEmployees.Services
{
    public class ServiceEmployee: TemplateService<Employee, adoEmployee>
    {

        new public List<Employee> getAll()
        {
            return base.getAll();
        }

        new public void createOrUpdate(Employee employee)
        {
            base.createOrUpdate(employee);
        }
        new public void delete(int id)
        {
            base.delete(id);
        }

    }
}