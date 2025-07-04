namespace Lab1.Files.Inheritence;

public class Animal
{
    public virtual string Breathe()
    {
        return "Animal Breathes";
    }
}

public class Plant : Animal //Single level Inheritance
{
    public override string Breathe()
    {
        return "Plants breathe";
    }
}
