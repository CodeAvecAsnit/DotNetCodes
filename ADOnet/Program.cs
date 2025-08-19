// using ADOnet.ado;
// using Microsoft.Extensions.Configuration;
//
//
// var configuration = new ConfigurationBuilder()
//     .SetBasePath(Directory.GetCurrentDirectory()) 
//     .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//     .Build();
//
// var connectionString = configuration.GetConnectionString("DefaultConnection");
// var disArchi = new DisconnectedArchi(connectionString);
// var connArchi = new ConnectedArchi(connectionString);
//
// disArchi.PutData_(6,"Marketing",35000);
// connArchi.GetData();
//
//

using ADOnet.EF_core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory()) 
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));

using var context = new SchoolContext(optionsBuilder.Options);

context.Database.EnsureCreated();

var teacher = new Teacher
{
    Name = "Mr. Smith",
    Courses = new List<Course>()
};

var course1 = new Course { Title = "Math 101", Teacher = teacher };
var course2 = new Course { Title = "Science 101", Teacher = teacher };

var student1 = new Student { Name = "Alice" };
var student2 = new Student { Name = "Bob" };

var cs1 = new CourseStudent { Student = student1, Course = course1 };
var cs2 = new CourseStudent { Student = student1, Course = course2 };
var cs3 = new CourseStudent { Student = student2, Course = course1 };


context.Teachers.Add(teacher);
context.Students.AddRange(student1, student2);
context.Courses.AddRange(course1, course2);
context.CourseStudents.AddRange(cs1, cs2, cs3);

context.SaveChanges();

Console.WriteLine("Data added successfully!");