using DBTest.Models;
using DBTest.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers(); // ✅ Required to use controllers
builder.Services.AddScoped<NewLetterService>();
builder.Services.AddScoped<DbContext>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36)) // ✅ Use a real version (MySQL 9 doesn't exist yet)
    ));


var app = builder.Build();

app.UseHttpsRedirection();



app.MapControllers(); // ✅ Required to map attribute-based controllers

app.Run();