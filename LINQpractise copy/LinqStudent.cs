namespace Lab1.Files.LINQpractie;

public class LinqStudent
{
    public string StudentName { get; set; }
    public int marks { get; set; }

    public LinqStudent()
    {
    }

    public LinqStudent(string studentName, int marks)
    { 
        StudentName = studentName;
        this.marks = marks;
    }
    
}