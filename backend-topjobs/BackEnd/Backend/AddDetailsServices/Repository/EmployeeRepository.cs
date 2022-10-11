using DetailsServices.Repository;
using DetailsServices.Entities;
using System.Collections.Generic;
using System.Linq;
using DetailsServices.Entities.Model;
namespace DetailsServices.Repository
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly DetailsDb database;
        public EmployerRepository(DetailsDb db)
        {
            this.database = db;
        }
        public string AddEmployer(Employer e)
        {
            this.database.Employers.Add(e);
            this.database.SaveChanges();
            return "added sucessfully";
        }
        Employer IEmployerRepository.Login(Login login)
        {
            return this.database.Employers.SingleOrDefault(o => o.EmailAddress == login.Email && o.Password == login.Password); 
        }




        /*   Employer IEmployerRepository.Login(Login login)
           {
               Employer e = this.database.Employers.SingleOrDefault(o => o.EmailAddress == login.Email && o.Password == login.Password);
               if (e != null)
               {
                   return "";
               }

           }
        */
    }
}
