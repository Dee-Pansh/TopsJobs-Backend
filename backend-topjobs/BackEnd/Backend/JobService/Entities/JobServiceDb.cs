using Microsoft.EntityFrameworkCore;
namespace JobService.Entities
{
    public class JobServiceDb:DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            //optionsBuilder.UseSqlServer(@"server=DESKTOP-ER8Q6A8\SQLEXPRESS;database=JobServiceDb;trusted_connection=true");
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4SQVS51\SQLEXPRESS;database=JobServiceDb;trusted_connection=true");
        }
    }
}
