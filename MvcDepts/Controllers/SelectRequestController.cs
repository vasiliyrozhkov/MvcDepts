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
        ISession _session;

        public SelectRequestController(ISession session)
        {
            _session = session;

        }

        // GET: SelectRequest
        public IActionResult Index()
        {
            var query = new GetDepartmentsQuery();
            var handler = QueryHandlerFactory.Build(query);
            return View(handler.Execute(_session));
        }

        // GET: SelectRequest/Employees
        public IActionResult Employees()
        {
            var query = new GetEmployeesQuery();
            var handler = QueryHandlerFactory.Build(query);
            return View(handler.Execute(_session));
        }

        // GET: SelectRequest/EmployeesFromDepartment/5
        public IActionResult EmployeesFromDepartment(int id)
        {
            var query = new GetEmployeesFromDeptQuery(id);
            var handler = QueryHandlerFactory.Build(query);
            return View(handler.Execute(_session));
        }

        // GET: SelectRequest/EmployeeDetails/5
        public IActionResult EmployeeDetails(int id)
        {
            var query = new OneEmployeeQuery(id);
            var handler = QueryHandlerFactory.Build(query);
            var employee = handler.Execute(_session);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
    }
}