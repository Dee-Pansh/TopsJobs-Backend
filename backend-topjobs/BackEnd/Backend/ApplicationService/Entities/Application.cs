using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationService
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required]
        public int ApplicantId { get; set; }
        [Required]
        public int JobId { get; set; }
        [Required]
        public string ApplicationStatus { get; set; }
        [Required]
        public string Resume { get; set; }

        public string Status = "Applied";
    }
}
