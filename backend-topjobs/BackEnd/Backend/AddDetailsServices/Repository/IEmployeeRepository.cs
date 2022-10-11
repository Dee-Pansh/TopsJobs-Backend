using DetailsServices.Entities;
using System.Collections.Generic;
using DetailsServices.Entities.Model;
namespace DetailsServices.Repository
{
    public interface IEmployerRepository
    {
        string AddEmployer(Employer e);
     
      Employer Login(Login login);
    }
}
