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
    public class GetEmployeesQueryHandler : IQueryHandler<GetEmployeesQuery, List<Employee>>
    {
        public List<Employee> Execute(ISession session)
        {
            return session.Query<Employee>("SELECT * FROM Employee").ToList();
        }
    }
}
