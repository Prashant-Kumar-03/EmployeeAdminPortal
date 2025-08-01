using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // DbSet for Employee entity
        public DbSet<Models.Entities.Employee> Employees { get; set; }
        //instead of Models.Entities.Employee   you can write only Employee 



    }

}
