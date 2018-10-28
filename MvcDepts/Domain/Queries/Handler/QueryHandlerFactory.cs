using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Models;


namespace MvcDepts.Domain.Queries.Handler
{
    public class QueryHandlerFactory
    {
        public static IQueryHandler<GetDepartmentsQuery, List<DepartmentExpanded>> Build(GetDepartmentsQuery query)
        {
            return new GetDepartmentsQueryHandler();
        }

        public static IQueryHandler<GetEmployeesQuery, List<Employee>> Build(GetEmployeesQuery query)
        {
            return new GetEmployeesQueryHandler();
        }

        public static IQueryHandler<GetEmployeesFromDeptQuery, List<Employee>> Build(GetEmployeesFromDeptQuery query)
        {
            return new GetEmployeesFromDeptQueryHandler(query);
        }

        public static IQueryHandler<OneEmployeeQuery, Employee> Build(OneEmployeeQuery query)
        {
            return new OneEmployeeQueryHandler(query);
        }
    }
}
