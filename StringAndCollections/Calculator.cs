namespace Lab1.Files.StringAndCollections;


public interface IAdd
{
    public int Sum(int a, int b);
}

public interface ISub
{
    public int Sub(int a, int b);
}

public interface IMul
{
    public int Mul(int a, int b);
}

public interface IDiv
{
    public float Div(int a, int b);
}

public class Calculator : IAdd,ISub,IMul,IDiv
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }

    public float Div(int a, int b)
    {
        return a/b;
    }
}

// Program.cs
// var calc = new Calculator();
// var _num1 = 15;
// var _num2 = 5;
// Console.WriteLine($"Sum : {calc.Sum(_num1,_num2)}");
// Console.WriteLine($"Difference : {calc.Sub(_num1,_num2)}");
// Console.WriteLine($"Multiplication : {calc.Mul(_num1,_num2)}");
// Console.WriteLine($"Division : {calc.Div(_num1,_num2)}");