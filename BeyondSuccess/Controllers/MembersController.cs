using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BeyondSuccessWeb.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMembersRepository membersRepository;

        public MembersController(IMembersRepository membersRepository)
        {
            this.membersRepository = membersRepository;
        }

        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult Add(int cohortId)
        {
            ViewBag.MemberAction = nameof(Add);
            ViewBag.CohortId = cohortId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(int cohortId, Member member)
        {
            member.CohortId = cohortId;
            if (ModelState.IsValid)
            {
                await membersRepository.CreateMember(member);
                return RedirectToAction("Cohort", "Cohorts", new { id = cohortId });
            }
            return View(member);
        }
        public async Task<IActionResult> Edit(int id, int cohortId)
        {
            ViewBag.MemberAction = nameof(Edit);
            ViewBag.CohortId = cohortId;
            var member=await membersRepository.GetMemberById(id);
            return View(member);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, int cohortId, Member member)
        {
            ViewBag.MemberAction = nameof(Edit);
            await membersRepository.UpdateMember(id, member);
                return RedirectToAction("Cohort", "Cohorts", new { id = cohortId });
            
        }
        public IActionResult Delete(int id, int cohortId)
        {
            ViewBag.CohortId = cohortId;
            return View(id);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteItem(int id, int cohortId)
        {
            await membersRepository.DeleteMembertById(id);
            return RedirectToAction("Cohort", "Cohorts", new { id = cohortId });
        }

    }
}
