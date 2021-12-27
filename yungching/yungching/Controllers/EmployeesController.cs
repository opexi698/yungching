using System.Collections.Generic;
using System.Web.Mvc;
using yungching.Model;
using yungching.Service.Services;
using yungching.WebBase;

namespace yungching.Controllers
{
    public class EmployeesController : yungChingControllerBase
    {
        [HttpGet]
        public JsonResult GetEmployees()
        {
            IList<Employees> employees = new List<Employees>();
            IEmployeesService employeesService = new EmployeesService();
            employees = employeesService.GetEmployees();
            return Json(employees);
        }
    }
}