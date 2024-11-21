using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BeyondSuccessWeb.Controllers
{
    public class CohortsController : Controller
    {
        private readonly ICohortRepository cohortRepository;

        public CohortsController(ICohortRepository cohortRepository)
        {
            this.cohortRepository = cohortRepository;
        }

        public async Task<IActionResult> Index()
        {

           var cohorts= await cohortRepository.GetAllCohorts();
            ViewBag.DeleteDescription = "Deleting a cohort involves also deleting all the members. Are you sure you want to delete this cohort?";
            ViewBag.DeleteAction= nameof(Delete);
            return View(cohorts);
        }
        public async Task<IActionResult> Cohort(int id)
        {
            var cohort= await cohortRepository.GetCohortById(id);
            ViewBag.CohortId= id;
            ViewBag.MemberAction = "Add";
            return View(cohort);
        }
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Cohort cohort)
        {
            if (ModelState.IsValid)
            {
                await cohortRepository.CreateCohort(cohort);
                return RedirectToAction(nameof(Index));
            }
            return View(cohort);
        }
        public async Task<IActionResult> Edit(int id) {
            ViewBag.Action = "Edit";
            var cohort = await cohortRepository.GetCohortById(id);
            return View(cohort);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Cohort cohort)
        {
            if (ModelState.IsValid)
            {
                await cohortRepository.UpdateCohort(id, cohort);
                return RedirectToAction(nameof(Index));
            }
            return View(cohort);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await cohortRepository.DeleteCohortById(id);
            return RedirectToAction(nameof(Index));
        }
       
    }
}
