using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MvcDepts.Models
{
    public interface ISelectRequest
    {
        List<DepartmentExpanded> GetDepartments(string procedureName);
        List<Employee> GetEmployees();
        List<Employee> GetEmployeesFromDepartment(int? id);
        Employee Get(int? id);
    }

    public class SelectRequest : ISelectRequest
    {
        string connectionString = null;

        public SelectRequest(string conn)
        {
            connectionString = conn;
        }

        public List<DepartmentExpanded> GetDepartments(string procedureName)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();
                return db.Query<DepartmentExpanded>(procedureName, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<Employee> GetEmployees()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Employee>("SELECT * FROM Employee").ToList();
            }
        }

        public List<Employee> GetEmployeesFromDepartment(int? id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Employee>("SELECT * FROM Employee WHERE DepartmentID = @id", new { id }).ToList();
            }
        }

        public Employee Get(int? id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Employee>("SELECT * FROM Employee WHERE EmployeeID = @id", new { id }).FirstOrDefault();
            }
        }
    }
}
