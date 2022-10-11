using System;
using System.Collections.Generic;
using ResumeServices.Entities;
using ResumeServices.Repository;
namespace ResumeServices.Services
{
    public class ResumeService:IResumeService
    {
        private readonly IResumeRepository repo;
        public ResumeService(IResumeRepository repo)
        {
            this.repo = repo;
        }

        public string AddResume(Resume r)
        {
            try
            {
                return this.repo.AddResume(r);
            }
            catch (SystemException)
            {

                throw new SystemException();
            }
        }

        public List<Resume> AllResumesForParticularJobId(int jobId)
        {
            try
            {
                return this.repo.AllResumesForParticularJobId(jobId);
            }
            catch (System.Exception)
            {

                throw new SystemException();
            }
        }

        public string JobSeekerRegisteredConfirmation(int applicantId)
        {
            try
            {
                return this.repo.JobSeekerRegisteredConfirmation(applicantId);
            }
            catch (System.Exception)
            {
                throw new SystemException();
            }
        }
    }
}
