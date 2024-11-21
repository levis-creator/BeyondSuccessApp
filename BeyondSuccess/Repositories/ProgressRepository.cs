using BeyondSuccessWeb.Data;
using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BeyondSuccessWeb.Repositories
{
    public class ProgressRepository : IProgressRepository
    {
        private readonly DataContext context;

        public ProgressRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Progress> CreateProgress(Progress progress)
        {
            var progressDb = await context.Progresses.AddAsync(progress);
            await context.SaveChangesAsync();
            return progressDb.Entity;
        }

        public async Task<string?> DeleteProgressById(int progressId)
        {
            var progress = await context.Progresses.FindAsync(progressId);
            if (progress != null)
            {
                context.Progresses.Remove(progress);
                await context.SaveChangesAsync();
                return "Success";
            }
            return null;
        }

        public async Task<List<Progress>> GetAllProgress()
        {
            var progress = await context.Progresses.Include(p => p.Lesson).ToListAsync();
            return progress;
        }

        public async Task<List<Progress>?> GetAllProgressByCohortId(int cohortId)
        {
            var progress= await context.Progresses.Where(p=>p.CohortId==cohortId).Include(p=>p.Lesson).ToListAsync();
            return progress;

        }

        public async Task<Progress?> GetProgressById(int progressId)
        {
            var progress = await context.Progresses.Include(x => x.Lesson).FirstOrDefaultAsync(x => x.Id == progressId);
            if (progress != null)
            {
                return progress;
            }
            return null;
        }

        public async Task<Progress?> UpdateProgress(int progressId, Progress progress)
        {
            var progressDb = await context.Progresses.FindAsync(progressId);
            if (progressDb != null)
            {
              progressDb.CohortId= progress.CohortId;
                progressDb.LessonId= progress.LessonId;
                progressDb.CompletedOnDate= progress.CompletedOnDate;
                progressDb.UpdatedAt = DateTime.Now;
                await context.SaveChangesAsync();
                return progressDb;
            }
            return null;
        }
    }
}
