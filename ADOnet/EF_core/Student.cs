namespace ADOnet.EF_core;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    
    public ICollection<CourseStudent> CourseStudents { get; set; }
}