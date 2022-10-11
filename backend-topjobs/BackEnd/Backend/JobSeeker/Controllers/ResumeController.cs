using System.Collections.Generic;
using ResumeServices.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ResumeServices.Entities;
namespace ResumeServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController
    {
        private readonly IResumeService _seekerService;

        public ResumeController(IResumeService db)
        {
            _seekerService = db;
        }
       //[Authorize(Roles= "JobSeeker")]
        [HttpPost,Route("AddResume")]
        public string AddResume(Resume r)
        {
            return this._seekerService.AddResume(r);
        }
        //[Authorize(Roles = "Employer")]
        [HttpGet,Route("ViewResumes")]
        public List<Resume> AllResumesForParticularJobId(int jobId)
        {
            return this._seekerService.AllResumesForParticularJobId(jobId);
        }
        [HttpGet,Route("JobSeekerRegisteredConfirmation")]
        public string JobSeekerRegisteredConfirmation(int applicantId)
        {
            return this._seekerService.JobSeekerRegisteredConfirmation(applicantId);
        }
    }
}
