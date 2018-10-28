using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public class AddEmployeeToDeptCommandHandler : ICommandHandler<AddEmployeeToDeptCommand>
    {
        private readonly AddEmployeeToDeptCommand _command;

        public AddEmployeeToDeptCommandHandler(AddEmployeeToDeptCommand command)
        {
            _command = command;
        }

        public void Execute(MvcDeptsContext context)
        {
            context.Update(_command.Employee);
        }
    }
}
