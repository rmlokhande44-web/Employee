using Microsoft.EntityFrameworkCore;
using Employee.Models;
namespace Employee
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            
        }
        public DbSet<EmployeeTb> EmployeeTb { get; set; }
    }
}
