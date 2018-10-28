using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Dapper;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Models;


namespace MvcDepts.Domain.Queries.Handler
{
    public class GetEmployeesFromDeptQueryHandler : IQueryHandler<GetEmployeesFromDeptQuery, List<Employee>>
    {
        private readonly GetEmployeesFromDeptQuery _query;

        public GetEmployeesFromDeptQueryHandler (GetEmployeesFromDeptQuery query)
        {
            _query = query;
        }

        public List<Employee> Execute(ISession session)
        {
            return session.Query<Employee>("SELECT * FROM Employee WHERE DepartmentID = @id", new { _query.ID }).ToList();
        }
    }
}
