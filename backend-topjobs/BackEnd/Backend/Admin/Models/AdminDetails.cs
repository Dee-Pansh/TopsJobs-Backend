using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Admin.Models
{
    public class AdminDetails
    {
        [BsonId]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ProfileDescription { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string CompanyWebsiteLink { get; set; }
    }
}
