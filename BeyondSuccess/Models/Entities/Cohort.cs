using System.ComponentModel.DataAnnotations;

namespace BeyondSuccessWeb.Models.Entities
{
    public class Cohort
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CohortName { get; set; }=string.Empty;
        public string? CohortDescription { get; set; }
        [Required]
        public DateOnly StartDate { get; set; }
        public DateTime? UpdatedAt { get; set; }=DateTime.Now;
        public readonly DateTime CreatedAt = DateTime.Now;
        public List<Member> Members { get; set; } = [];
        public List<Progress> Progress { get; set; } = [];
    }
}
