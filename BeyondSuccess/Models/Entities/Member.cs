using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeyondSuccessWeb.Models.Entities
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }=string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public int CohortId { get; set; }
        [ForeignKey(nameof(CohortId))]
        public Cohort? Cohort { get; set; }


    }
}
