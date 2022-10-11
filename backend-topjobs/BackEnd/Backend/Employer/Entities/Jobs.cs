using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Employer.Entities
{
    public class Jobs
    {
        [Key]
        [Required]
        public int JobId { get; set; }
        [Required]
        public string PostedBy { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime LastDateToApply { get; set; }
        [Required]
        public string JobDescription {get;set;}
        [Required]

        public string JobCategory { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
