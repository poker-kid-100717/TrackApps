using Microsoft.EntityFrameworkCore;
using TrackApps.Server.Models;

namespace TrackApps.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Interview> Interviews { get; set; }
        //public DbSet<JobRefData> PositionsRefData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data
            modelBuilder.Entity<Interview>().HasData(
                new Interview { Id = 1, InterviewDate = "2024-11-19", Interviewer = "I1", Company = "CYFD", Position = "DB Admim", ContactNumber = "", Round = 1 },
                new Interview { Id = 2, InterviewDate = "2024-11-20", Interviewer = "I2", Company = "Motion Recruitment", Position = "Full Stack Engineer", ContactNumber = "", Round = 1 }
            );

            //modelBuilder.Entity<JobRefData>().HasData(
            //    new JobRefData { Id = 1, PositionName = "Software Developer", ContactNumber = "", CompanyName = "", InterviewerName = "", InterviewDate = new DateOnly { } },
            //    new JobRefData { Id = 2, PositionName = "Software Engineer", ContactNumber = "", CompanyName = "", InterviewerName = "", InterviewDate = new DateOnly { } },
            //    new JobRefData { Id = 3, PositionName = "Full Stack Engineer", ContactNumber = "", CompanyName = "", InterviewerName = "", InterviewDate = new DateOnly { } },
            //    new JobRefData { Id = 4, PositionName = ".NET Developer", ContactNumber = "", CompanyName = "", InterviewerName = "", InterviewDate = new DateOnly { } },
            //    new JobRefData { Id = 5, PositionName = "Database Developer", ContactNumber = "", CompanyName = "", InterviewerName = "", InterviewDate = new DateOnly { } },
            //    new JobRefData { Id = 6, PositionName = "Database Administrator", ContactNumber = "", CompanyName = "", InterviewerName = "", InterviewDate = new DateOnly { } }

            //);
        }
    }
}

