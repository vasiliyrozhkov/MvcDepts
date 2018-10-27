using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcDepts.Models;

namespace MvcDepts.Models
{
    public class MvcDeptsContext : DbContext
    {
        public MvcDeptsContext (DbContextOptions<MvcDeptsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcDepts.Models.Department> Department { get; set; }

        public DbSet<MvcDepts.Models.Employee> Employee { get; set; }
    }
}
