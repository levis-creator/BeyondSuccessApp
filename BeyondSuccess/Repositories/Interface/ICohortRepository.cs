using BeyondSuccessWeb.Models.Entities;

namespace BeyondSuccessWeb.Repositories.Interface
{
    public interface ICohortRepository
    {
        public Task<List<Cohort>> GetAllCohorts();
        public Task<Cohort?> GetCohortById(int cohortId);
        public Task<Cohort?> UpdateCohort(int cohortId, Cohort cohort);
        public Task<string?> DeleteCohortById(int cohortId);
        public Task<Cohort> CreateCohort(Cohort cohort);
    }
}
