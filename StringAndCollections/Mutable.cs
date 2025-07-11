namespace Lab1.Files.StringAndCollections;

public class Mutable
{
    public void CheckMutable()
    {
        String originalString = "Hello This is Original String";
        Console.WriteLine("Original String : " + originalString); 
        String modifiedString = originalString.Replace("Hello", "Ola");
        Console.WriteLine ("Modified String " +modifiedString);
        Console.WriteLine("Original String : "+originalString);
        Console.WriteLine("Are the original and modified strings the same object in memory?");
        Console.WriteLine(Object.ReferenceEquals(originalString, modifiedString));
    }
}

//Program.cs Body
// var mutable = new Mutable();
// mutable.CheckMutable();