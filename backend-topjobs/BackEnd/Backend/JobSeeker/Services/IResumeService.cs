using ResumeServices.Entities;
using System.Collections.Generic;
namespace ResumeServices.Services
{
    public interface IResumeService
    {
        string AddResume(Resume r);
        string JobSeekerRegisteredConfirmation(int applicantId);
        List<Resume> AllResumesForParticularJobId(int jobId);
    }
}
