using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace DetailsServices.Entities
{
    public class Employer
    { 
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Designation { get; set; }
        public string Role="Employer";
        [Required]
        public string Password { get; set; }

    }
}
