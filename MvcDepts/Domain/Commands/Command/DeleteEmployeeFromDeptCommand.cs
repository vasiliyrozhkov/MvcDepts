using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Command
{
    public class DeleteEmployeeFromDeptCommand : ICommand
    {
        public Employee Employee { get; private set; }

        public DeleteEmployeeFromDeptCommand(Employee employee)
        {
            Employee = employee;
        }
    }
}
