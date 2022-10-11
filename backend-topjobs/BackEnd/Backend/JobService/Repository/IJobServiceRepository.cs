using System;
using JobService.Entities;
using System.Collections.Generic;
namespace JobService.Repository
{
    public interface IJobServiceRepository
    {
        List<Job> AllJobs();
        string AddJob(Job job);
        string DeleteJob(int job);
        List<Job> GetJobsByEmployerId(int EmployerId);
        List<Job> AllJobByCategory(string category);
        public Job GetJobByJobId(int jobId);
    }
}
