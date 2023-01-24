using Microsoft.EntityFrameworkCore;
using university.Models;

namespace university.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new
            {
                sc.StudentId,
                sc.CourseId
            });

            modelBuilder.Entity<ProfessorCourse>().HasKey(pc => new
            {
                pc.ProfessorId,
                pc.CourseId
            });

            modelBuilder.Entity<StudentCourse>().HasOne(s => s.Student).WithMany(sc => sc.Courses).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<StudentCourse>().HasOne(s => s.Course).WithMany(sc => sc.Students).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProfessorCourse>().HasOne(s => s.Course).WithMany(pc => pc.Professors).HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ProfessorCourse>().HasOne(s => s.Professor).WithMany(pc => pc.Courses).HasForeignKey(s => s.ProfessorId).OnDelete(DeleteBehavior.NoAction); ;

      
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<ProfessorCourse> ProfessorCourses { get; set; }

    }
}
