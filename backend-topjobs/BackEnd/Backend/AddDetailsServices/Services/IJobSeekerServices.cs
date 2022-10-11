using DetailsServices.Entities;
using System.Collections.Generic;
using DetailsServices.Entities.Model;
namespace DetailsServices.Services
{
    public interface IJobSeekerServices
    {
       
        string AddJobSeeker(JobSeeker e);
        JobSeeker Login(Login login);

    }
}
