using System.ComponentModel.DataAnnotations;

namespace BeyondSuccessWeb.Models.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        [Required]
        public string LessonTitle {  get; set; }=string.Empty;
        public string LessonDescription { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public readonly DateTime CreatedAt = DateTime.Now;
        public List<Progress> Progress { get; set; } = [];
    }
}
