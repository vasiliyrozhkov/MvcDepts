using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Queries.Query
{
    public class OneEmployeeQuery : IQuery<Employee>
    {
        public int ID { get; private set; }

        public OneEmployeeQuery(int id)
        {
            ID = id;
        }
    }
}
