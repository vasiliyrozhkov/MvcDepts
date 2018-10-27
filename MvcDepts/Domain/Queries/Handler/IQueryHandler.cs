using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MvcDepts.Domain.Queries.Query;
using MvcDepts.Dapper;

namespace MvcDepts.Domain.Queries.Handler
{
    public interface IQueryHandler<in TQuery, out TResponse> where TQuery : IQuery<TResponse>
    {
        TResponse Execute(ISession session);
    }
}
