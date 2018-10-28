using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public class CreateEmployeeCommandHandler : ICommandHandler<CreateEmployeeCommand>
    {
        private readonly CreateEmployeeCommand _command;

        public CreateEmployeeCommandHandler(CreateEmployeeCommand command)
        {
            _command = command;
        }

        public void Execute(MvcDeptsContext context)
        {
            context.Add(_command.Employee);
        }
    }
}
