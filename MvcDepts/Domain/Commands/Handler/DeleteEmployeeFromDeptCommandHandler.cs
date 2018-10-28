using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public class DeleteEmployeeFromDeptCommandHandler : ICommandHandler<DeleteEmployeeFromDeptCommand>
    {
        private readonly DeleteEmployeeFromDeptCommand _command;

        public DeleteEmployeeFromDeptCommandHandler(DeleteEmployeeFromDeptCommand command)
        {
            _command = command;
        }

        // Delete user from department; DepartmentID = 1 means: is not Department
        public void Execute(MvcDeptsContext context)
        {
            context.Employee.Where(e => e.EmployeeID == _command.Employee.EmployeeID).AsEnumerable().Select(e => { e.DepartmentID = 1; return e; });
        }
    }
}
