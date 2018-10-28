using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Command
{
    public class CreateEmployeeCommand : ICommand
    {
        public Employee Employee { get; private set; }

        public CreateEmployeeCommand(Employee employee)
        {
            Employee = employee;
        }
    }
}
