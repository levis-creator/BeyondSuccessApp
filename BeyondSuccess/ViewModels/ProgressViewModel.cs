using BeyondSuccessWeb.Models.Dtos.Member;
using BeyondSuccessWeb.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeyondSuccessWeb.ViewModels
{
    public class ProgressViewModel
    {
        [Required]
        public int LessonId { get; set; }
        [Required]
        public int CohortId { get; set; }
        [Required]
        public DateOnly CompletedOnDate { get; set; }
        public List<MemberSelectDto> Members { get; set; } = [];
        public List<int> SelectedMembers { get; set; } = [];
        public string? Remarks { get; set; } = string.Empty;
    }
}
