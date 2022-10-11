using Microsoft.EntityFrameworkCore;

namespace ApplicationService.Entities
{
    public class ApplicationDb:DbContext
    {
        public DbSet<Application> Applications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            //optionsBuilder.UseSqlServer(@"server=DESKTOP-ER8Q6A8\SQLEXPRESS;database=Apllications;trusted_connection=true");
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4SQVS51\SQLEXPRESS;database=Apllications;trusted_connection=true");
        }
    }
}
