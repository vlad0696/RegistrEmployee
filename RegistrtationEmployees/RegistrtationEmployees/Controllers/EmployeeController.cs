using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrtationEmployees.Services;
using RegistrtationEmployees.Models;

namespace RegistrtationEmployees.Controllers
{
    public class EmployeeController : Controller
    {
        ServiceEmployee serviceEmployee = new ServiceEmployee();
        public ActionResult Index()
        {
          
            List<Employee> list = serviceEmployee.getAll();
            ViewBag.entites = list;
            return View();
        }

    
        [HttpPost]
        public void CreateOrUpdate(Employee employee)
        {
                serviceEmployee.createOrUpdate(employee);

        }

        [HttpPost]
        public void Delete(int id)
        {
            serviceEmployee.delete(id);
        }

    }
}