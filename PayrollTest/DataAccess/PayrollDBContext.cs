using Microsoft.EntityFrameworkCore;
using PayrollTest.API.Models;

namespace PayrollTest.API.DataAccess
{
    public class PayrollDBContext : DbContext
    {
        public PayrollDBContext(DbContextOptions Options)
            : base(Options) { }

        public DbSet<Benefit> Benefits { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PayCheck> PayChecks { get; set; }
    }
}
