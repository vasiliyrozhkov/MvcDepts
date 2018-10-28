using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public class EditDepartmentCommandHandler : ICommandHandler<EditDepartmentCommand>
    {
        private readonly EditDepartmentCommand _command;

        public EditDepartmentCommandHandler(EditDepartmentCommand command)
        {
            _command = command;
        }

        public void Execute(MvcDeptsContext context)
        {
            context.Update(_command.Department);
        }
    }
}
