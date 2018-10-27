using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDepts.Models
{
    public class DepartmentExpanded
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int EmployeeNumber { get; set; }
    }
}
