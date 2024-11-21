using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BeyondSuccessWeb.Controllers
{
    public class LessonsController : Controller
    {
        private readonly ILessonsRepository lessonsRepository;

        public LessonsController(ILessonsRepository lessonsRepository)
        {
            this.lessonsRepository = lessonsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var lessons=await lessonsRepository.GetAllLessons();
            return View(lessons);
        }
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Lesson lesson)
        {
           if(ModelState.IsValid){
                await lessonsRepository.CreateLesson(lesson);
                return RedirectToAction(nameof(Index));
            }
            return View(lesson);
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Action = "Edit";
            var lesson = await lessonsRepository.GetLessonById(id);
            return View(lesson);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                await lessonsRepository.UpdateLesson(id, lesson);
                return RedirectToAction(nameof(Index));
            }
            return View(lesson);
        }
        public IActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            await lessonsRepository.DeleteLessonById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
