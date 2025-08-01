namespace Lab1.Files.LINQpractise;

public class SquareStruct
{
    public int num { get; set; }
    public int square { get; set; }

    public SquareStruct()
    {
    }

    public SquareStruct(int num, int square)
    {
        this.num = num;
        this.square = square;
    }
}

class Person
{
    public string Name { get; set; }
    public string City { get; set; }
}