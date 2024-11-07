using BeyondSuccessWeb.Data;
using BeyondSuccessWeb.Models.Entities;
using BeyondSuccessWeb.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace BeyondSuccessWeb.Repositories
{
    public class CohortRepository : ICohortRepository
    {
        private readonly DataContext context;

        public CohortRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<Cohort> CreateCohort(Cohort cohort)
        {
           var cohortDb= await context.Cohorts.AddAsync(cohort);
            await context.SaveChangesAsync();
            return cohortDb.Entity;
        }

        public async Task<string?> DeleteCohortById(int cohortId)
        {
           var cohort= await context.Cohorts.FindAsync(cohortId);
            if (cohort != null) { 
                context.Cohorts.Remove(cohort);
                await context.SaveChangesAsync();
                return "Success";
            }
            return null;
        }

        public async Task<List<Cohort>> GetAllCohorts()
        {
            var cohorts =await context.Cohorts.ToListAsync();
            return cohorts;
        }

        public async Task<Cohort?> GetCohortById(int cohortId)
        {
            var cohort = await context.Cohorts.Include(x=>x.Members).FirstOrDefaultAsync(x=>x.Id==cohortId);
            if (cohort != null)
            {
                return  cohort;
            }
            return null;
        }

        public async Task<Cohort?> UpdateCohort(int cohortId, Cohort cohort)
        {
            var cohortDb = await context.Cohorts.FindAsync(cohortId);
            if (cohortDb != null)
            {
                cohortDb.CohortName = cohort.CohortName;
                cohortDb.CohortDescription = cohort.CohortDescription;
                cohortDb.StartDate = cohort.StartDate;
                cohortDb.UpdatedAt = DateTime.Now;
                await context.SaveChangesAsync();
                return cohortDb;
            }
            return null;
        }
    }
}
