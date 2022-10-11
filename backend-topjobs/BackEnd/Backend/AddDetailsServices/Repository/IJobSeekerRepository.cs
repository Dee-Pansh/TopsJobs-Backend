using DetailsServices.Entities;
using System.Collections.Generic;
using DetailsServices.Entities.Model;
namespace DetailsServices.Repository
{
    public interface IJobSeekerRepository
    {
       
        string AddJobSeeker(JobSeeker e);

        JobSeeker Login(Login login);

    }
}
