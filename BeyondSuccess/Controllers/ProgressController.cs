using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using BeyondSuccessWeb.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeyondSuccessWeb.ViewModels;
using BeyondSuccessWeb.Models.Dtos.Member;

namespace BeyondSuccessWeb.Controllers
{
    public class ProgressController : Controller
    {
        private readonly IProgressRepository progressRepository;
        private readonly ILessonsRepository lessonsRepository;
        private readonly IMembersRepository membersRepository;
        public ProgressController(IProgressRepository progressRepository, ILessonsRepository lessonsRepository, IMembersRepository membersRepository)
        {
            this.progressRepository = progressRepository;
            this.lessonsRepository = lessonsRepository;
            this.membersRepository = membersRepository;
        }

        public async Task<IActionResult> Index(int? cohortId)
        {
            List<Progress>? progress;

            if (cohortId.HasValue)
            {
                ViewBag.CohortId = cohortId.Value;
                progress = await progressRepository.GetAllProgressByCohortId(cohortId.Value);
            }
            else
            {
                progress = await progressRepository.GetAllProgress();
            }
           
            return View(progress);
        }
        public async Task<IActionResult> Add(int? cohortId)
        {
            var lessons= await lessonsRepository.GetAllLessons();
            var members = await membersRepository.GetMembersByCohort(cohortId.Value);
            ViewBag.Action = "Add";
            ViewBag.CohortId= cohortId.Value;
            var progressDto = new ProgressViewModel();
            foreach(Member member in members)
            {
                progressDto.Members.Add(
                    new MemberSelectDto
                    {
                        Id = member.Id,
                        FirstName = member.FirstName,
                        LastName = member.LastName

                    });
            }

            
            ViewBag.Lessons = new SelectList(lessons, "Id", "LessonTitle");
            return View(progressDto);
        }
        [HttpPost]
        public async Task<IActionResult> Add(int cohortId, ProgressViewModel progress)
        {
                progress.CohortId= cohortId;

            if (ModelState.IsValid)
            {
                var progressFm = new Progress()
                {
                    CohortId = cohortId,
                    LessonId = progress.LessonId,
                    CompletedOnDate = progress.CompletedOnDate,
                };
                foreach(var memberId in progress.SelectedMembers)
                {
                    progressFm.Attendance.Add(
                        new Member
                        {
                            Id=memberId
                        }
                       );
                }
                await progressRepository.CreateProgress(progressFm);
                return RedirectToAction("Index", "Progress", new { cohortId = cohortId });
            }
            return View(progress);
        }

    }
}
