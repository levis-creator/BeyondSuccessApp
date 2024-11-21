using BeyondSuccessWeb.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeyondSuccessWeb.Models.Dtos.Member
{
    public class MemberSelectDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool Select { get; set; }
    }
}
