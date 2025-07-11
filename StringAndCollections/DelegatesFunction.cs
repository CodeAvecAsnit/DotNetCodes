namespace Lab1.Files.StringAndCollections;

public delegate void PrintString(string x);
public class DelegatesFunction
{
    public void PrintString(string x)
    {
        Console.WriteLine("hello ! from "+ x);
    }
}

//Program.cs
// var obj = new DelegatesFunction();
// PrintString str = obj.PrintString;
// str("John Doe");
// str("Jane Smith");