using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeyondSuccessWeb.Models.Entities
{
    public class Progress
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; } = null!;
        [ForeignKey(nameof(Cohort))]
        public int CohortId { get; set; }
        public Cohort? Cohort { get; set; }=null!;
        public DateOnly CompletedOnDate { get; set; }
        public string? Remarks { get; set; }=string.Empty;
        public List<Member> Attendance { get; set; } = [];
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public readonly DateTime CreatedAt = DateTime.Now;
    }
}
