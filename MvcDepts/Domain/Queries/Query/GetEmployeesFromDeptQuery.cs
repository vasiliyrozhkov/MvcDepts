using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Queries.Query
{
    public class GetEmployeesFromDeptQuery : IQuery<List<Employee>>
    {
        public int ID { get; private set; }

        public GetEmployeesFromDeptQuery(int id)
        {
            ID = id;
        }
    }
}
