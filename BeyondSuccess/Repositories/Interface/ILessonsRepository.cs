using BeyondSuccessWeb.Models.Entities;

namespace BeyondSuccessWeb.Repositories.Interface
{
    public interface ILessonsRepository
    {
        public Task<List<Lesson>> GetAllLessons();
        public Task<Lesson?> GetLessonById(int LessonId);
        public Task<Lesson?> UpdateLesson(int LessonId, Lesson Lesson);
        public Task<string?> DeleteLessonById(int LessonId);
        public Task<Lesson> CreateLesson(Lesson Lesson);
    }
}
