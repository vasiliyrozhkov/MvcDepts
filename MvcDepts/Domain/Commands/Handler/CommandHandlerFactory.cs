using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Models;
using MvcDepts.Domain.Commands.Command;

namespace MvcDepts.Domain.Commands.Handler
{
    public class CommandHandlerFactory
    {
        public static ICommandHandler<CreateDepartmentCommand> Build(CreateDepartmentCommand command)
        {
            return new CreateDepartmentCommandHandler(command);
        }

        public static ICommandHandler<EditDepartmentCommand> Build(EditDepartmentCommand command)
        {
            return new EditDepartmentCommandHandler(command);
        }

        public static ICommandHandler<CreateEmployeeCommand> Build(CreateEmployeeCommand command)
        {
            return new CreateEmployeeCommandHandler(command);
        }

        public static ICommandHandler<EditEmployeeCommand> Build(EditEmployeeCommand command)
        {
            return new EditEmployeeCommandHandler(command);
        }

        public static ICommandHandler<AddEmployeeToDeptCommand> Build(AddEmployeeToDeptCommand command)
        {
            return new AddEmployeeToDeptCommandHandler(command);
        }

        public static ICommandHandler<DeleteEmployeeFromDeptCommand> Build(DeleteEmployeeFromDeptCommand command)
        {
            return new DeleteEmployeeFromDeptCommandHandler(command);
        }
    }
}
