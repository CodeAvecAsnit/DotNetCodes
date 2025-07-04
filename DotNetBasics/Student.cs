namespace Lab1.Files;

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }


    public void DisplayInfo()
    {
        Console.WriteLine("The name of the Student is "+this.StudentName +
                          ".The id of the student is : "+this.StudentId);
    }
    
}