using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MvcDepts.Dapper;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Models;


namespace MvcDepts.Domain.Queries.Handler
{
    public class GetDepartmentsQueryHandler : IQueryHandler<GetDepartmentsQuery, List<DepartmentExpanded>>
    {

        public List<DepartmentExpanded> Execute(ISession session)
        {
            {
                string sql = "SELECT a.DepartmentID AS DepartmentID, a.DepartmentName AS DepartmentName, count(b.EmployeeID)" +
                             "AS EmployeeNumber FROM Department a LEFT JOIN Employee b ON a.DepartmentID = b.DepartmentID GROUP BY a.DepartmentID, a.DepartmentName";
                return session.Query<DepartmentExpanded>(sql).ToList();
            }
        }
    }
}
