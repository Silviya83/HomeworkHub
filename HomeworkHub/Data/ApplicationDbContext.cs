using HomeworkHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeworkHub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Assignment> Assigments { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherClass> TeacherClasses { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
    }
}
