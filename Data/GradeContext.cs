using c_my_grade.Models;
using Microsoft.EntityFrameworkCore;

namespace c_my_grade
{
    public class GradeContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> CourseAssignments { get; set; }
        public DbSet<Submission> StudentSubmissions { get; set; }
        public DbSet<Review> SubmissionReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Gradebook.db");
        }

    }
}