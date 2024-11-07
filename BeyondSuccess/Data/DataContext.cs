using BeyondSuccessWeb.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeyondSuccessWeb.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) { }
        public DbSet<Cohort> Cohorts { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cohort>().HasData(
                new Cohort
                {
                    Id=1,
                    CohortName="Cohort1",
                    StartDate=new DateOnly(2002, 07, 27)
                    
                }, new Cohort
                {
                    Id=2,
                    CohortName="Cohort2",
                    StartDate=new DateOnly(2010, 07, 27)
                    
                }
                );
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = 1,
                    FirstName="Eluid",
                    LastName="Kipchoge",
                    EmailAddress="eluid@email.com",
                    PhoneNumber="+2548708988",
                    CohortId=2,
                },
                 new Member
                 {
                     Id = 2,
                     FirstName = "Simon",
                     LastName = "Kinyanjui",
                     EmailAddress = "kinyanjuiSimon@email.com",
                     PhoneNumber = "+2548708988",
                     CohortId = 2,
                 }
                );

            modelBuilder.Entity<Cohort>()
                .HasMany(c => c.Members)
                .WithOne(m => m.Cohort)
                .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
