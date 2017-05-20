using RegistrtationEmployees.dao;
using RegistrtationEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrtationEmployees.Services
{
    public class ServiceCompany:TemplateService<Company, adoCompany>
    {
        new public List<Company> getAll()
        {
            return base.getAll();
        }
        new public void createOrUpdate(Company company)
        {
            base.createOrUpdate(company);
        }
    }
}