using System.Collections.Generic;
using ApplicationService.Entities.ViewApplicationModel;
namespace ApplicationService.Repository
{
    public interface IApplicationRepository
    {
        string PostApplication(Application application);
        public string UpdateApplicationStatus(UpdateApplicationStatus updateApplicationStatus);
        List<Application> ViewAllApplications();
        List<Application> ViewAllApplicationsByJobSeeker(int jobSeekerId);
        List<Application> ViewApplicationsByJOBId(int jobid);
        string DeleteApplicationsByJobId(int jobid);

        string IsGivenJobIdExist(int id);
        List<Application> GetApplicationsInfoForParticularJobSeeker(int applicantId);
    }
}
