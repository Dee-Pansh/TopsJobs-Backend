using System;
using Employer.Entities;
using System.Collections.Generic;
namespace Employer.Repository
{
    public interface IEmployeRepository
    {
        Jobs JobById(int id);
        string AddJob(Jobs job);
        string DeleteJob(Jobs job);
        string UpdateJob(Jobs job);

       List<Jobs> JobsByCategory(string category);
    }
}