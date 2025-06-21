using Microsoft.EntityFrameworkCore;
using RelationsTest.Model;
using RelationsTest.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddScoped<CitizenService>();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<PassportService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36))
    )
);



var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); 
app.Run();