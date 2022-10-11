using Microsoft.EntityFrameworkCore;
namespace ResumeServices.Entities
{
    public class ResumeDb:DbContext
    {
        public ResumeDb(DbContextOptions<ResumeDb> options):base(options)
        {

        }
        public DbSet<Resume> Resumes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
           //optionsBuilder.UseSqlServer(@"server=DESKTOP-4SQVS51\SQLEXPRESS;database=ResumesDb;trusted_connection=true");

        }
    }
}
