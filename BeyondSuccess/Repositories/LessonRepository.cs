using BeyondSuccessWeb.Data;
using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BeyondSuccessWeb.Repositories
{
    public class LessonRepository : ILessonsRepository
    {
        private DataContext context;

        public LessonRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Lesson> CreateLesson(Lesson lesson)
        {
            var lessonDb = await context.Lessons.AddAsync(lesson);
            await context.SaveChangesAsync();
            return lessonDb.Entity;
        }

        public async Task<string?> DeleteLessonById(int lessonId)
        {
            var lesson = await context.Lessons.FindAsync(lessonId);
            if (lesson != null)
            {
                context.Lessons.Remove(lesson);
                await context.SaveChangesAsync();
                return "Success";
            }
            return null;
        }

        public async Task<List<Lesson>> GetAllLessons()
        {
            var lessons = await context.Lessons.ToListAsync();
            return lessons;
        }

        public async Task<Lesson?> GetLessonById(int lessonId)
        {
            var lesson = await context.Lessons.FindAsync(lessonId);
            if (lesson != null)
            {
                return lesson;
            }
            return null;
        }

        public async Task<Lesson?> UpdateLesson(int LessonId, Lesson lesson)
        {
            var lessonDb = await context.Lessons.FindAsync(LessonId);
            if (lessonDb != null)
            {
                lessonDb.LessonTitle = lesson.LessonTitle;
                lessonDb.LessonDescription = lesson.LessonDescription;
                lessonDb.UpdatedAt = DateTime.Now;
                await context.SaveChangesAsync();
                return lessonDb;
            }
            return null;
        }

    }
}
