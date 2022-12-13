using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Data.Entity;

namespace StudentManagementPortal.Data.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        } 
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Prefect> Prefects { get; set; } 
        public DbSet<TeacherStudent> TeacherStudents { get; set; }
        public DbSet<StudentSubject> StudentCourses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
