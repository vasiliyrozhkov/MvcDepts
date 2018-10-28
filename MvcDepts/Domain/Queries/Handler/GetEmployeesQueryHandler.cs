using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Dapper;

namespace MvcDepts.Domain.Queries.Handler
{
    public class GetEmployeesQueryHandler : IQueryHandler<GetEmployeesQuery, List<Employee>>
    {
        public List<Employee> Execute(ISession session)
        {
            string sql = "SELECT * FROM Employee";
            return session.Query<Employee>(sql).ToList();
        }
    }
}
