using RegistrtationEmployees.Models;
using RegistrtationEmployees.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrtationEmployees.Controllers
{
    public class CompanyController:Controller
    {
        ServiceCompany serviceCompany = new ServiceCompany();
        public ActionResult Index()
        {

            List<Company> list = serviceCompany.getAll();
            ViewBag.entites = list;
            return View();
        }

        public void CreateOrUpdate(Company company)
        {
            serviceCompany.createOrUpdate(company);
        } 
    }
}