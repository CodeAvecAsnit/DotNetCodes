namespace Lab1.Files;

public class StudentCollectionIndex(int size)
{
    private string[] StudentNames = new string[size];

    private int GetLength()
    {
        return StudentNames.Length;
    }
    

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < this.GetLength())
            {
                return this.StudentNames[index];
            }
            else throw new IndexOutOfRangeException("Invalid Index");
        }
        set
        {
            if (index >= 0 && index < GetLength())
            {
                StudentNames[index] = value;
            }
            else throw new IndexOutOfRangeException("Invalid Index");
        }
    }

    public void DisplayInfo()
    {
        foreach (var x in StudentNames)
        {
            Console.WriteLine(x+" ");
        }
        Console.WriteLine();
    }
    
}