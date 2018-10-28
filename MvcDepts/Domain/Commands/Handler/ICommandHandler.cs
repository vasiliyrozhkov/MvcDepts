using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDepts.Domain.Commands.Command;
using MvcDepts.Models;

namespace MvcDepts.Domain.Commands.Handler
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Execute(MvcDeptsContext context);
    }
}
