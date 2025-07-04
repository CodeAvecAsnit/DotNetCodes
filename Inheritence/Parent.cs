namespace Lab1.Files.Inheritence;

public abstract class Parent
{
    protected int a;
    
    
    public void SayHello()
    {
       Console.WriteLine("Bonjour, I am the Parent"+a); 
    }
}

public class Child : Parent // Single Level Inheritance
{
    protected int b;
    public Child(int x,int y)
    {
        this.a= x;
        this.b = y;
    }

    public void SayBye()
    {
        Console.WriteLine($"Au Revoir, I am the child{a+b}");
    }
    
}

public class Child2 : Parent
{
    protected string k;
    public Child2(int x, string y)
    {
        this.a = x;
        this.k = y;
    }

    public void SayWelcome()
    {
        Console.WriteLine("Bievenue "+k +" "+ a);
    }
}


public class GrandChild : Child // MultiLevel Inheritance
{
    private int c;
    public GrandChild(int x, int y, int z) : base(x, y)
    {
        this.a = x;
        this.b = y;
        this.c = z;
    }

    public void SayGoodMorning()
    {
        Console.WriteLine($"Bonsoir I am the GrandChild {a+b+c}");
    }
    
}


public class LivingBeing
{
    public virtual void Speak()
    {
        Console.WriteLine("Living Beings Speak");
    }
}

public interface IAct
{
    public void Swim();
    public void Walk();
}


public class Human : LivingBeing , IAct  // Multiple Inheritance only through Interface
{
    public void Swim()
    {
        Console.WriteLine("Human is Swimming");
    }

    public void Walk()
    {
        Console.WriteLine("Human is Walking");
    }

    public override void Speak()
    {
        Console.WriteLine("Human Beings can talk");
    }
    
}
//Hierarchical Inheritance

public class GrandChildren(int x, string data, string name) : Child2(x, data), IAct
{
    private string name = name;

    public void Swim()
    {
        Console.WriteLine("GrandChild can swim");
    }

    public void Walk()
    {
      Console.WriteLine("GrandChildren can also Walk");
    }

    public void SayGoodNight()
    {
        Console.WriteLine("Good Night "+this.name);
    }
}


