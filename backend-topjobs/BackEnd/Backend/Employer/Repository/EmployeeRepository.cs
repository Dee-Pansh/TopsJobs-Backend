using Employer.Entities;
using System.Collections.Generic;

namespace Employer.Repository
{
    public class EmployeeRepository : IEmployeRepository
    {
        private readonly EmployerDb db;
        public EmployeRepository(EmployerDb database)
        {
            this.db = database;
        }
        public string AddJob(Jobs job)
        {
            this.db.Jobs.Add(job);
            return "added sucessfully";
        }

        public string DeleteJob(Jobs job)
        {
          if(this)
        }

        public Jobs JobById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Jobs> JobsByCategory(string category)
        {
            throw new System.NotImplementedException();
        }

        public string UpdateJob(Jobs job)
        {
            throw new System.NotImplementedException();
        }
    }
}
