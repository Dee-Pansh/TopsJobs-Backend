using ResumeServices.Entities;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace ResumeServices.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly ResumeDb db;
        public ResumeRepository(ResumeDb database)
        {
            this.db = database;
        }
        public string AddResume(Resume r)
        {
            this.db.Resumes.Add(r);
            db.SaveChanges();
            return "added successfully";
        }

        public List<Resume> AllResumesForParticularJobId(int jobId)
        {
            return this.db.Resumes.Where(y=>y.jobId==jobId).ToList();
        }

        public string DeleteResume(Resume R)
        {
            Resume res = this.db.Resumes.SingleOrDefault(p=>p.Resume_Id==R.Resume_Id);
            if(res!=null)
            {
                this.db.Resumes.Remove(R);
                db.SaveChanges();
                return "deleted successfully";
            }
            return "record not found";
        }

        public Resume GetResumeByResumeId(int id)
        {
            Resume res = this.db.Resumes.SingleOrDefault(t => t.Resume_Id == id);
            return res;

        }

        public string JobSeekerRegisteredConfirmation(int applicantId)
        {
            bool has = this.db.Resumes.Any(y => y.applicantId == applicantId);
            if (has ==true)
                return "true";
            return "false";
        }

        public string UpdateResume(Resume r)
        {
            Resume res = this.db.Resumes.SingleOrDefault(t => t.Resume_Id == r.Resume_Id);
            if(res!=null)
            {
                db.Resumes.Update(res);
                db.SaveChanges();
                return "updated successfully";
            }
            return "cant find record";
        }
    }
}
