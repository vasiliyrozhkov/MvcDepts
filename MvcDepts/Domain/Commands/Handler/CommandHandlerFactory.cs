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
    }
}
