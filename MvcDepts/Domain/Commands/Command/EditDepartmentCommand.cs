using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Command
{
    public class EditDepartmentCommand : ICommand
    {
        public Department Department { get; private set; }

        public EditDepartmentCommand(Department department)
        {
            Department = department;
        }
    }
}
