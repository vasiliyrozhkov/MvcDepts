using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Command
{
    public class AddEmployeeToDeptCommand : ICommand
    {
        public Employee Employee { get; private set; }

        public AddEmployeeToDeptCommand(Employee employee)
        {
            Employee = employee;
        }
    }
}
