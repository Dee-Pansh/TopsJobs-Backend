using DetailsServices.Entities;
using DetailsServices.Entities.Model;
using System.Collections.Generic;
using System.Linq;
namespace DetailsServices.Repository
{
    public class JobSeekerRepository:IJobSeekerRepository
    {
        private readonly DetailsDb database;
        public JobSeekerRepository(DetailsDb db)
        {
            this.database = db;
        }
        public string AddJobSeeker(JobSeeker e)
        {
            this.database.JobSeekers.Add(e);
            database.SaveChanges();
            return "added sucessfully";
        }


        public JobSeeker Login(Login login)
        {
            JobSeeker e = this.database.JobSeekers.SingleOrDefault(o => o.EmailAddress == login.Email && o.Password == login.Password);
            return e;
        }
    }

}

