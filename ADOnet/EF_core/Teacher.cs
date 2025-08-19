namespace ADOnet.EF_core;

public class Teacher
{
    public int TeacherId { get; set; }
    public string Name { get; set; }
    
    public ICollection<Course> Courses { get; set; }
}