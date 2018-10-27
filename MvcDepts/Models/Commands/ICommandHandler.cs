using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDepts.Models.Commands
{
    interface ICommandHandler<TCommand>
    {
        Task Execute(TCommand command);
    }
}
