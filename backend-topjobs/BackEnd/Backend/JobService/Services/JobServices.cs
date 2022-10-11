using JobService.Entities;
using JobService.Repository;
using System.Collections.Generic;

namespace JobService.Services
{
    public class JobServices : IJobServices
    {
        private readonly IJobServiceRepository _repository;
        
        public JobServices(IJobServiceRepository db)
        {
            this._repository = db;
        }
        public string AddJob(Job job)
        {
            //try
            //{
               return this._repository.AddJob(job);
          //  }
           // catch (System.Exception)
            //{

              //  throw new System.Exception();
            //}
        }

        public List<Job> AllJobByCategory(string category)
        {
           // try
            //{
                return this._repository.AllJobByCategory(category);
            //}
           // catch (System.Exception)
           // {
             //   throw new System.Exception();
            //}
        }

        public List<Job> AllJobs()
        {
            return this._repository.AllJobs();
        }

        public string DeleteJob(int job)
        {
           
            

                return this._repository.DeleteJob(job);
            
        }

        public Job GetJobByJobId(int jobId)
        {
            return this._repository.GetJobByJobId(jobId);
        }

        public List<Job> GetJobsByEmployerId(int EmployerId)
        {
            return this._repository.GetJobsByEmployerId(EmployerId);
        }
    }
}
