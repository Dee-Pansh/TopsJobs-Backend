using DetailsServices.Entities;
using DetailsServices.Entities.Model;
using DetailsServices.Repository;
using System.Collections.Generic;

namespace DetailsServices.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployerRepository db;
        public EmployeeServices(IEmployerRepository db)
        {
            this.db = db;
        }
        public string AddEmployer(Employer e)
        {
            
                return this.db.AddEmployer(e);
           
        }

      


        public Employer Login(Login login)
        {
            try
            {
                return this.db.Login(login);
            }
            catch (System.Exception)
            {
                throw new System.Exception();
            }
        }
    }
}
