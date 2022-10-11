using System.Collections.Generic;
using System.Linq;
using ApplicationService.Entities;
using ApplicationService.Entities.ViewApplicationModel;
namespace ApplicationService.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ApplicationDb db;
        public ApplicationRepository(ApplicationDb db)
        {
            this.db = db;
        }
        public string DeleteApplicationsByJobId(int jobid)
        {
            Application app = this.db.Applications.SingleOrDefault(r => r.JobId == jobid);
            if(app!=null)
            {
                this.db.Applications.Remove(app);
                db.SaveChanges();
                return "deleted successfully";
            }
            return "not found";
        }

        public List<Application> GetApplicationsInfoForParticularJobSeeker(int applicantId)
        {
            return this.db.Applications.Where(y => y.ApplicantId == applicantId).ToList();
        }

        public string IsGivenJobIdExist(int id)
        {
            bool has = this.db.Applications.Any(r => r.JobId == id);
            if(has==false)
            {
                return "false";
            }
            return "true";
           
        }

        public string PostApplication(Application application)
        {
            this.db.Add(application);
            db.SaveChanges();
            return "added successfully";
        }


//        SqlException: Cannot insert the value NULL into column 'Status', table 'Apllications.dbo.Applications'; column does not allow nulls.INSERT fails.
//The statement has been terminated.

        public string UpdateApplicationStatus(UpdateApplicationStatus updateApplicationStatus)
        {
            Application app = this.db.Applications.SingleOrDefault(r => updateApplicationStatus.applicantId == r.ApplicantId && r.JobId==updateApplicationStatus.jobId);
            if (app != null)
            {
                app.ApplicationStatus = updateApplicationStatus.status;
                
                db.SaveChanges();
                return "updated sucessfully";
            }
            return "record not found";
        }

        public List<Application> ViewAllApplications()
        {
            return this.db.Applications.ToList();
        }

        public List<Application> ViewAllApplicationsByJobSeeker(int jobSeekerId)
        {
            return this.db.Applications.Where(r => r.JobId == jobSeekerId).ToList();
        }

        public List<Application> ViewApplicationsByJOBId(int jobid)
        {
            return this.db.Applications.Where(r => r.JobId == jobid).ToList();
        }
    }
}
