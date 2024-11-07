using BeyondSuccessWeb.Data;
using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BeyondSuccessWeb.Repositories
{
    public class MembersRepository : IMembersRepository
    {
        private DataContext context;

        public MembersRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Member> CreateMember(Member member)
        {
            var memberDb = await context.Members.AddAsync(member);
            await context.SaveChangesAsync();
            return memberDb.Entity;
        }

        public async Task<string?> DeleteMembertById(int memberId)
        {
            var member = await context.Members.FindAsync(memberId);
            if (member != null)
            {
                context.Members.Remove(member);
                await context.SaveChangesAsync();
                return "Success";
            }
            return null;
        }

        public async Task<List<Member>> GetAllMembers()
        {
            var members = await context.Members.ToListAsync();
            return members;
        }

        public async Task<Member?> GetMemberById(int memberId)
        {
            var member = await context.Members.FindAsync(memberId);
            if (member != null)
            {
                return member;
            }
            return null;
        }

        public async Task<Member?> UpdateMember(int memberId, Member member)
        {
            var memberDb = await context.Members.FindAsync(memberId);
            if (memberDb != null)
            {
               memberDb.FirstName = member.FirstName;
                memberDb.LastName = member.LastName;
                memberDb.PhoneNumber = member.PhoneNumber;
                memberDb.EmailAddress   = member.EmailAddress;
                memberDb.UpdatedAt = DateTime.Now;
                await context.SaveChangesAsync();
                return memberDb;
            }
            return null;
        }
    }
}
