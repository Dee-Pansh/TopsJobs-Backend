using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace JobService.Entities
{
    public class Job
    {
        [Key]
        [Required]
        public int JobId { get; set; }
        [Required]
        public int EmployerId { get; set; }
        public string PostedBy { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public DateTime CreatedDate = DateTime.Now;
        [Required]
        public DateTime LastDateToApply { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public string JobCategory { get; set; }
        [Required]
        public string status { get; set; } = "active";
        [Required]
        public int NoOfVacancies { get; set; }
    }
}