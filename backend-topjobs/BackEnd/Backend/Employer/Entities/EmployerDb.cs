using Microsoft.EntityFrameworkCore;
namespace Employer.Entities
{
    public class EmployerDb : DbContext
    {

        public DbSet<Jobs> Jobs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4SQVS51\SQLEXPRESS;database=EmployerDb;trusted_connection=true");

        }
    }
}
