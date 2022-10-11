using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace DetailsServices.Entities
{
    public class JobSeeker
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public int Age { get; set; }
        public string Role = "JobSeeker"; 
        [Required]
        public string Password { get; set; }

    }
}
