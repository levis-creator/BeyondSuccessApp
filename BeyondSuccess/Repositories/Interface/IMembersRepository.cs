using BeyondSuccessWeb.Models.Entities;

namespace BeyondSuccessWeb.Repositories.Interface
{
    public interface IMembersRepository
    {
        public Task<List<Member>> GetAllMembers();
        public Task<Member?> GetMemberById(int memberId);
        public Task<Member?> UpdateMember(int memberId, Member member);
        public Task<string?> DeleteMembertById(int memberId);
        public Task<Member> CreateMember(Member member);
    }
}
