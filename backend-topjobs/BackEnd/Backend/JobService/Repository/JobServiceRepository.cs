using JobService.Entities;
using System.Collections.Generic;
using System.Linq;
namespace JobService.Repository
{
    public class JobServiceRepository:IJobServiceRepository
    {
        private readonly JobServiceDb db;
        public JobServiceRepository(JobServiceDb database)
        {
            this.db = database;
        }
        
        public string AddJob(Job job)
        {
            this.db.Jobs.Add(job);
            db.SaveChanges(); 
            return "added sucessfully";
        }

        public List<Job> AllJobByCategory(string category)
        {
            return this.db.Jobs.Where(t => t.JobCategory == category && t.status=="active").ToList();
        }

        public string DeleteJob(int id)
        {
            Job j = this.db.Jobs.SingleOrDefault(p => p.JobId == id);
            if (j != null)
            {
                j.status = "inactive";
                db.SaveChanges();
                return "deleted successfully";
            }
            return "not found this job";
        }

        public Job GetJobByJobId(int jobId)
        {
            return this.db.Jobs.SingleOrDefault(u => u.JobId == jobId);
        }

        public List<Job> GetJobsByEmployerId(int EmployerId)
        {
            return this.db.Jobs.Where(t => t.EmployerId == EmployerId && t.status=="active").ToList();
        }

        List<Job> IJobServiceRepository.AllJobs()
        {
            return db.Jobs.Where(y => y.status == "active").ToList();
        }
    }
}

