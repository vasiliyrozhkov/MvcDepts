using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Command
{
    public class CreateDepartmentCommand : ICommand
    {
        public Department Department { get; private set; }

        public CreateDepartmentCommand(Department item)
        {
            Department = item;
        }
    }
}
