using Microsoft.EntityFrameworkCore;

namespace CSSDPROJECT.Model
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
