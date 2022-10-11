using System;
using ResumeServices.Entities;
using System.Collections.Generic;
namespace ResumeServices.Repository
{
    public interface IResumeRepository
    {
        string AddResume(Resume r);
        string JobSeekerRegisteredConfirmation(int applicantId);
        List<Resume> AllResumesForParticularJobId(int jobId);
    }
}
