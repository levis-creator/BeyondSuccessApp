using BeyondSuccessWeb.Models.Entities;

namespace BeyondSuccessWeb.Repositories.Interface
{
    public interface IProgressRepository
    {
        public Task<List<Progress>> GetAllProgress();
        public Task<List<Progress>?> GetAllProgressByCohortId(int cohortId);
        public Task<Progress?> GetProgressById(int progressId);
        public Task<Progress?> UpdateProgress(int progressId, Progress Progress);
        public Task<string?> DeleteProgressById(int progressId);
        public Task<Progress> CreateProgress(Progress Progress);
    }
}
