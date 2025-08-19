namespace ADOnet.EF_core;

public class CourseStudent
{
    public int CourseId { get; set; }
    public Course Course { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}
