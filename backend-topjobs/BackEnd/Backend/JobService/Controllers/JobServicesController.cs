using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JobService.Entities;
using JobService.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
namespace JobService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobServicesController : ControllerBase
    {
        private readonly IJobServices db;
        public JobServicesController(IJobServices db)
        {
            this.db = db;
        }
        [HttpGet,Route("GetAllJob")]
        public List<Job> GetAllJob()
        {
            return this.db.AllJobs();
        }
        [HttpPost,Route("AddJob")]
        public string AddJob(Job j)
        {   
            return this.db.AddJob(j);
        }
        [HttpDelete,Route("DeleteJob")]
        public string Deleltee(int j)
        {
            return this.db.DeleteJob(j);
        }
        [HttpGet,Route("GetJobsByCategory")]
        public List<Job> GetJobsByCategory(string category)
        {
            return this.db.AllJobByCategory(category);
        }
        [HttpGet,Route("GetJobsByEmployerId")]
        public List<Job> GetJobsByEmployerId(int EmployerId)
        {
            return this.db.GetJobsByEmployerId(EmployerId);
        }
        [HttpGet,Route("GetJobByJobId")]
        public Job GetJobByJobId(int jobId)
        {
            return this.db.GetJobByJobId(jobId);
        }
    }
}
