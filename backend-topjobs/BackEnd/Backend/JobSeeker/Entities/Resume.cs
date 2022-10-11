using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ResumeServices.Entities
{
    public class Resume
    {
        [Key]
        [Required]
        public int Resume_Id { get; set; }
        [Required]
        public int applicantId { get; set; }
        [Required]
        public string Skills { get; set; }
        [Required]
        public string MajorProject { get; set; }
 
        [Required]
        public int Experience { get; set; }
        [Required]
        public string Achievements { get; set; }
        [Required]
        public int jobId { get; set; }
        [Required]
        public string Name { get; set; }
        
    }
}
