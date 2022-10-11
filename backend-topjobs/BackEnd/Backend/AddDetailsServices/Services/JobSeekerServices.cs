using DetailsServices.Entities;
using DetailsServices.Entities.Model;
using DetailsServices.Repository;
using System.Collections.Generic;

namespace DetailsServices.Services
{
    public class JobSeekerServices : IJobSeekerServices
    {
        private readonly IJobSeekerRepository db;
        public JobSeekerServices(IJobSeekerRepository db)
        {
            this.db = db;
        }
        public string AddJobSeeker(JobSeeker e)
        {
            try
            {
                return this.db.AddJobSeeker(e);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }



        public JobSeeker Login(Login login)
        {
            try
            {
                return this.db.Login(login);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

       
    }
}
