using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Admin.Models;
namespace Admin.Services
{
    public class AdminServices
    {
        private readonly IMongoCollection<AdminDetails> _Addetails;
        public AdminServices()
        {
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Admin");
                _Addetails = database.GetCollection<AdminDetails>("Details");
            }
        }
        public List<AdminDetails> Get()
        {
            return _Addetails.Find(details => true).ToList();
        }
        public AdminDetails GetById(int id)
        {
            return _Addetails.Find<AdminDetails>(details => details.Id == id).SingleOrDefault();
        }
        public string AddAdminDetails(AdminDetails admin)
        {
            _Addetails.InsertOne(admin);
            return "added successfully";
        }
        public string RemoveAdminDetails(AdminDetails admin)
        {
            if (_Addetails.Find<AdminDetails>(details => details.Id == admin.Id).SingleOrDefault() != null)
            {
                _Addetails.DeleteOne(details => details.Id == admin.Id);
                return "deleted successfully";
            }
            return "cant find the record";
        }
        public string Update(AdminDetails admin)
        {
            if (_Addetails.Find<AdminDetails>(details => details.Id == admin.Id).SingleOrDefault() != null)
            {
                _Addetails.ReplaceOne(details => details.Id == admin.Id, admin);
                return "updated successfully";
            }
            return "cant find the record";
        }
    }
}

