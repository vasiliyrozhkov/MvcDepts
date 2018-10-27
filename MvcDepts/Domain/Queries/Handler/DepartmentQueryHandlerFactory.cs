using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Models;


namespace MvcDepts.Domain.Queries.Handler
{
    public class DepartmentQueryHandlerFactory
    {
        public static IQueryHandler<GetDepartmentsQuery, IEnumerable<DepartmentExpanded>> Build(GetDepartmentsQuery query)
        {
            return new GetDepartmentsQueryHandler();
        }
    }
}
