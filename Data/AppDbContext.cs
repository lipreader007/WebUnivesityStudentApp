using Microsoft.EntityFrameworkCore;

namespace WebUnivesityStudentApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Application> Applications { get; set; }
    }
}
