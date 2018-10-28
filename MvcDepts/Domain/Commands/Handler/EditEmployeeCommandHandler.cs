using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public class EditEmployeeCommandHandler : ICommandHandler<EditEmployeeCommand>
    {
        private readonly EditEmployeeCommand _command;

        public EditEmployeeCommandHandler(EditEmployeeCommand command)
        {
            _command = command;
        }

        public void Execute(MvcDeptsContext context)
        {
            context.Update(_command.Employee);
        }
    }
}
