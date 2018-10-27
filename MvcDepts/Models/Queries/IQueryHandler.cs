using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDepts.Models.Queries
{
    public interface IQueryHandler<TQuery, TResult>
    {
        Task<TResult> Execute(TQuery query);
    }
}
