using Microsoft.EntityFrameworkCore;

namespace DBTest.Models;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
public DbSet<NewLetter> NewLetters { get; set; }
}