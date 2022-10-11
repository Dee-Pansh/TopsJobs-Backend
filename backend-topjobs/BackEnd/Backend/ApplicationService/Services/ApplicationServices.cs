using ApplicationService.Repository;
using System.Collections.Generic;
using ApplicationService.Entities.ViewApplicationModel;
namespace ApplicationService.Services
{
    public class ApplicationServices : IApplicationServices
    {
        private readonly IApplicationRepository db;
        public ApplicationServices(IApplicationRepository db)
        {
            this.db= db;
        }
        public string DeleteApplicationsByJobId(int jobid)
        {
            try
            {
                return this.db.DeleteApplicationsByJobId(jobid);
            }
            catch (System.Exception)
            {

                throw new System.Exception();
            }
        }

        public List<Application> GetApplicationsInfoForParticularJobSeeker(int applicantId)
        {
            try
            {
                return this.db.GetApplicationsInfoForParticularJobSeeker(applicantId);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public string IsGivenJobIdExist(int id)
        {
            //try
            //{
                return this.db.IsGivenJobIdExist(id);
            //}
            //catch (System.Exception)
            //{
            //    throw new System.Exception();
            //}
        }

        public string PostApplication(Application application)
        {
           
                return this.db.PostApplication(application);
            
        }

        public string UpdateApplicationStatus(UpdateApplicationStatus updateApplicationStatus)
        {
            try
            {
                return this.db.UpdateApplicationStatus(updateApplicationStatus);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public List<Application> ViewAllApplications()
        {
            try
            {
                return this.db.ViewAllApplications();
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public List<Application> ViewAllApplicationsByJobSeeker(int jobSeekerId)
        {
            try
            {
                return this.db.ViewAllApplicationsByJobSeeker(jobSeekerId);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }

        public List<Application>ViewApplicationsByJOBId(int jobid)
        {
            try
            {
                return this.db.ViewApplicationsByJOBId(jobid);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }
    }
}
