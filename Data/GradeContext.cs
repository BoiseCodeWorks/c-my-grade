using Microsoft.EntityFrameworkCore;

namespace c_my_grade
{
    public class GradeContext : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Gradebook.db");
        }

    }
}