using Microsoft.EntityFrameworkCore;
namespace DetailsServices.Entities
{
    public class DetailsDb:DbContext
    {
       public DbSet<Employer> Employers { get; set; }
       public DbSet<JobSeeker> JobSeekers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            //optionsBuilder.UseSqlServer(@"server=DESKTOP-ER8Q6A8\SQLEXPRESS;database=AddDetailsServicesDb;trusted_connection=true");
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4SQVS51\SQLEXPRESS;database=DetailsDb;trusted_connection=true");
        }
    }
}