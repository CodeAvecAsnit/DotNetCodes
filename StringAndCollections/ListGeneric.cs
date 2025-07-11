namespace Lab1.Files.StringAndCollections;

public class ListGeneric
{
    private List<int> _numList = [];

    public void InsertInList()
    {
        for (var i = 1; i <= 10; ++i)
        {
            _numList.Add(i);
        }
        Console.WriteLine("Successfully Inserted Data");
    }

    public void DisplayList()
    {
        Console.Write("The data in the List is : ");
        foreach (var y in _numList)
        {
            Console.Write(y + " ");
        }
        Console.WriteLine();
    }
}

//Program.cs
// var listGen = new ListGeneric();
// listGen.InsertInList();
// listGen.DisplayList();