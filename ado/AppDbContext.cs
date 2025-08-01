using Microsoft.EntityFrameworkCore;

namespace ADOnet.ado;

public class AppDbContext (DbContextOptions<AppDbContext> options) : DbContext(options)
{
    
}