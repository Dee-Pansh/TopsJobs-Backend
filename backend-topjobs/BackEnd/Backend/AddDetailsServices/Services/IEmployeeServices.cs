using DetailsServices.Entities;
using System.Collections.Generic;
using System.Linq;
using DetailsServices.Entities.Model;
namespace DetailsServices.Services
{
    public interface IEmployeeServices
    {

        string AddEmployer(Employer e);

        Employer Login(Login login);
    }
}
