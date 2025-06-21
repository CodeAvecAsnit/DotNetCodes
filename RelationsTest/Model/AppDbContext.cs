namespace RelationsTest.Model;
using Microsoft.EntityFrameworkCore;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Citizen?> Citizens { get; set; }
    public DbSet<Passport> Passports { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Passport>()
            .HasOne(p => p.citizen)
            .WithOne()
            .HasForeignKey<Passport>(p => p.citizenId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade); 
    }
}