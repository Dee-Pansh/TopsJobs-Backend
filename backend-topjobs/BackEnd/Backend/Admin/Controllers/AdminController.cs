using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Admin.Models;
using Admin.Services;
namespace Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminServices _adminServices;
        public AdminController()
        {
            this._adminServices = new AdminServices();
        }
        [HttpGet,Route("GetAllAdminDetails")]
        public List<AdminDetails> GetAllDetails()
        {
            return this._adminServices.Get();
        }
        [HttpGet,Route("GetByID/{id}")]
        public AdminDetails GetByid(int id)
        {
            return this._adminServices.GetById(id);
        }
        [HttpDelete,Route("DeleteAdminDetails")]
        public string DeleteDetails(AdminDetails admin)
        {
            return this._adminServices.RemoveAdminDetails(admin);
        }
        [HttpPost,Route("AddAdmin")]
        public string AddAdmin(AdminDetails admin)
        {
            return this._adminServices.AddAdminDetails(admin);
        }
        [HttpPut,Route("UpdateAdminDetails")]
        public string UpdateDetails(AdminDetails admin)
        {
            return this._adminServices.Update(admin);
        }

    }
}
