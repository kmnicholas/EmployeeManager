using EmployeeManager.Domain.Entities;
using System.Data.Entity;

namespace EmployeeManager.Domain
{
    public class EmployeeContext : DbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
