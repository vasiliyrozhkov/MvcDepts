using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcDepts.Models;

namespace MvcDepts.Controllers
{
    public class SelectRequestController : Controller
    {
        ISelectRequest _request;

        public SelectRequestController(ISelectRequest request)
        {
            _request = request;
        }

        // GET: SelectRequest
        public IActionResult Index()
        {
            return View(_request.GetDepartments("getDept"));
        }

        // GET: SelectRequest/Employees
        public IActionResult Employees()
        {
            return View(_request.GetEmployees());
        }

        // GET: SelectRequest/EmployeesFromDepartment/5
        public IActionResult EmployeesFromDepartment(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View(_request.GetEmployeesFromDepartment(id));
        }

        // GET: SelectRequest/EmployeeDetails/5
        public IActionResult EmployeeDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = _request.Get(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
    }
}