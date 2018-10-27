using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcDepts.Models;
using MvcDepts.Domain.Queries.Handler;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Dapper;

namespace MvcDepts.Controllers
{
    public class SelectRequestController : Controller
    {
        ISelectRequest _request;
        ISession _session;

        public SelectRequestController(ISelectRequest request, ISession session)
        {
            _request = request;
            _session = session;

        }

        // GET: SelectRequest
        public IActionResult Index()
        {
            var query = new GetDepartmentsQuery();
            var handler = DepartmentQueryHandlerFactory.Build(query);
            return View(handler.Execute(_session));
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