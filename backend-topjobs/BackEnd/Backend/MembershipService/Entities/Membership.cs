using System.ComponentModel.DataAnnotations;
using System;
namespace MembershipService.Entities
{
    public class Membership
    {
        [Key]
        [Required]
        public int MembershipId { get; set; }
        [Required]
        public int EmployerId { get; set; }
        [Required]
        public string Plan { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }= DateTime.Now;
        [Required]
        public string Status { get; set; }
    }
}
