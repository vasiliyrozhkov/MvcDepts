using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public class CreateDepartmentCommandHandler : ICommandHandler<CreateDepartmentCommand>
    {
        private readonly CreateDepartmentCommand _command;

        public CreateDepartmentCommandHandler(CreateDepartmentCommand command)
        {
            _command = command;
        }

        public void Execute(MvcDeptsContext context)
        {
            context.Add(_command.Department);
        }
    }
}
