using Microsoft.EntityFrameworkCore;
namespace MembershipService.Entities
{
    public class MembershipDb:DbContext
    {
        public DbSet<Membership> Membership { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define the connectionstring
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4SQVS51\SQLEXPRESS;database=MemberDb;trusted_connection=true");

        }
    }
}
