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
    public class OneEmployeeQueryHandler : IQueryHandler<OneEmployeeQuery, Employee>
    {
        private readonly OneEmployeeQuery _query;

        public OneEmployeeQueryHandler(OneEmployeeQuery query)
        {
            _query = query;
        }

        public Employee Execute(ISession session)
        {
            return session.Query<Employee>("SELECT * FROM Employee WHERE EmployeeID = @id", new { _query.ID }).FirstOrDefault();
        }
    }
}
