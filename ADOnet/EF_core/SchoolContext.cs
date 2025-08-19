using Microsoft.EntityFrameworkCore;

namespace ADOnet.EF_core;

public class SchoolContext(DbContextOptions<SchoolContext> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseStudent> CourseStudents { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseStudent>()
            .HasKey(cs => new { cs.CourseId, cs.StudentId });
        
        modelBuilder.Entity<CourseStudent>()
            .HasOne(cs => cs.Course)
            .WithMany(c => c.CourseStudents)
            .HasForeignKey(cs => cs.CourseId);

        modelBuilder.Entity<CourseStudent>()
            .HasOne(cs => cs.Student)
            .WithMany(s => s.CourseStudents)
            .HasForeignKey(cs => cs.StudentId);
        
        modelBuilder.Entity<Course>()
            .HasOne(c => c.Teacher)
            .WithMany(t => t.Courses)
            .HasForeignKey(c => c.TeacherId);
    }
}
