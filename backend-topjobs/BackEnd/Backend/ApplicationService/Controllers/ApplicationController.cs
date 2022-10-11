using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationService.Entities;
using ApplicationService.Services;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using ApplicationService.Entities.ViewApplicationModel;
namespace ApplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationServices db;
        public ApplicationController(IApplicationServices DB)
        {
            this.db = DB;
        }


     //   [Authorize(Roles ="JobSeeker")]
        [HttpGet,Route("ListAllApplications/jobseekerId")]
        public List<Application> AllAppsByJobSeekerId(int jobseekerid)
        {
            return this.db.ViewAllApplicationsByJobSeeker(jobseekerid);
        }



       // [Authorize(Roles = "Employer")]
        [HttpDelete,Route("DeleteApplicationsByJobId")]
        public string DeleteApplicationsByJobId(int id)
        {
            return this.db.DeleteApplicationsByJobId(id);
        }



        //[Authorize(Roles = "Employer")]
        [HttpGet,Route("ViewAllApplicationsByJobId")]
        public List<Application> ViiewApplicationsByByJobId(int jobid)
        {
            return this.db.ViewApplicationsByJOBId(jobid);
        }



        [HttpPut,Route("UpdateApplicationStatus")]
        public string UpdateApplicationStatus(UpdateApplicationStatus app)
        {
            return this.db.UpdateApplicationStatus(app);
        }




        [HttpPost,Route("PostApplication")]
        public string PostApplication(Application application)
        {
            return this.db.PostApplication(application);
        }
        
        [HttpGet,Route("IsGivenJobIdExist")]
        public string IsGivenJobIdExist(int id)
        {
            return this.db.IsGivenJobIdExist(id);
        }

        [HttpGet,Route("GetApplicationsInfoForParticularJobSeeker")]
        public List<Application> GetApplicationsInfoForParticularJobSeeker(int applicantId)
        {
            return this.db.GetApplicationsInfoForParticularJobSeeker(applicantId);
        }
    }
}
