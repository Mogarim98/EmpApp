using Emp.Models;
using Microsoft.EntityFrameworkCore;

namespace Emp.Data
{
    public class ApplicaeionDbContext: DbContext
    {
        //ctor

        public ApplicaeionDbContext(DbContextOptions<ApplicaeionDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
