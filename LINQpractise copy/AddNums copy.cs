using System.Diagnostics.Contracts;
using System.Drawing;
using System.Security.AccessControl;
using Lab1.Files;
using Lab1.Files.Inheritence;
using Lab1.Files.LINQpractie;
using Lab1.Files.LINQpractise;
using Lab1.Files.StringAndCollections;

namespace Lab1;


public abstract class AddNums
{

    public static void Main(string[] args)
    {
        // var nums = new Nums(4, 8);

        // var student = new Student();
        // student.StudentId = 9;
        // student.StudentName = "John Doe";
        // student.DisplayInfo();


        // int[] arr = [1, 2, 6, 7, 9, 10, 50];
        // var numArr = new ArrayFunctions();
        // numArr.ReverseArr(arr);
        //
        // var std = new StudentCollectionIndex(10)
        // {
        //     [0] = "Hello"
        // };
        // std[1] = "Amazing";
        // std[2] = "Hungry";
        // std[3] = "Manifest " +
        //          "Me";
        // std.DisplayInfo();
        // Console.WriteLine($"The required string at index 3 is {std[3]}");
        // Console.WriteLine($"The required string at index 0 is {std[0]}");




        // Animal animal = new Plant();
        // Console.WriteLine(animal.Breathe());



        // // Program.cs Body
        //  var mutable = new Mutable();
        //  mutable.CheckMutable();

        // var obj = new DelegatesFunction();
        // PrintString str = obj.PrintString;
        // str("John Doe");
        // str("Jane Smith");
        //
        // var listGen = new ListGeneric();
        // listGen.InsertInList();
        // listGen.DisplayList();

        // var generic = new DictionaryGeneric();
        // generic.AddToMap("John", "Doe");
        // generic.AddToMap("Jane", "Smith");
        // generic.AddToMap("Josh", "Henry");
        // generic.AddToMap("mail", "goat");
        //
        // generic.Display("mail");
        // generic.DisplayEntireList();
        
        
        // var calc = new Calculator();
        // var _num1 = 15;
        // var _num2 = 5;
        // Console.WriteLine($"Sum : {calc.Sum(_num1,_num2)}");
        // Console.WriteLine($"Difference : {calc.Sub(_num1,_num2)}");
        // Console.WriteLine($"Multiplication : {calc.Mul(_num1,_num2)}");
        // Console.WriteLine($"Division : {calc.Div(_num1,_num2)}");



        /*
        var bankUser = new BankInstance(5000)
        {
            _userId = 45,
            stringUserName = "John Pork"
        };
        try
        {
            bankUser.WithdrawMoney(4000);
            bankUser.WithdrawMoney(1500);
        }
        catch (BalanceNotEnoughException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        */

        /*var studentList = new List<LinqStudent>();
        var student = new LinqStudent()
        {
            StudentName = "asnit",
            marks = 90
        };
        studentList.Add(student);
        var std2 = new LinqStudent()
        {
            StudentName = "Aka",
            marks = 79
        };
        studentList.Add(std2);
        var std3 = new LinqStudent()
        {
            StudentName = "john",
            marks = 81
        };
        studentList.Add(std3);
        
        var highscores = studentList.Where(std => std.marks>80);
        
        foreach (var arc in highscores)
        {
            Console.WriteLine(arc.StudentName);
        }*/

        /*const string str = "LinQ is gooD ISN't it.It is USEFUL";
        var chr = str.Where(char.IsUpper);
        foreach (var ch in chr)
        {
            Console.Write(ch + " ");
        }*/
        
        /*
        Console.WriteLine();
        
        
        var num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var sq = num.Select(n => n * n);
        foreach (var n in sq)
        {
            Console.Write(n + " ");
        }
        
        Console.WriteLine();
        Console.ReadKey();*/
        
        /*
        List<Person> people = new List<Person>
        {
            new Person { Name = "RONNY", City = "ROME" },
            new Person { Name = "LANDON", City = "LONDON" },
            new Person { Name = "ANIL", City = "NAIROBI" },
            new Person { Name = "EMILY", City = "CALIFORNIA" },
            new Person { Name = "LUKA", City = "ZURICH" },
            new Person { Name = "MISTHI", City = "NEW-DELHI" },
            new Person { Name = "RAM", City = "AMSTERDAM" },
            new Person { Name = "Fatima", City = "ABU DHABI" },
            new Person { Name = "PARLE", City = "PARIS" }
        };
        
        Console.Write("Enter a character to filter cities that start and end with it: ");
        char ch = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine("\n");
        
        var matchedPeople = people
            .Where(p => p.City.StartsWith(ch) || p.City.EndsWith(ch))
            .ToList();
        
        if (matchedPeople.Any())
        {
            Console.WriteLine($"\nPeople from cities starting and ending with '{ch}':");
            foreach (var person in matchedPeople)
            {
                Console.WriteLine($"Name: {person.Name}, City: {person.City}");
            }
        }
        else
        {
            Console.WriteLine($"\nNo cities found that start and end with '{ch}'.");
        }
        */
        
        
        /*
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        var characterFrequencies = input
            .GroupBy(c => c)
            .Select(group => new { Character = group.Key, Count = group.Count() })
            .OrderBy(result => result.Character);
        
        Console.WriteLine("\nCharacter frequencies:");
        foreach (var item in characterFrequencies)
        {
            Console.WriteLine($"Character: '{item.Character}' - Count: {item.Count}");
        }*/
        
        
        var courses = new List<Course>
        {
            new Course { courseId  = 1, Name = "John" },
            new Course { courseId = 2, Name = "Alice" },
            new Course { courseId = 3, Name = "Bob" }
        };

        var teachers = new List<Teacher>
        {
            new Teacher { courseId = 1, courseName = "Database" },
            new Teacher { courseId = 2, courseName = "English" },
            new Teacher { courseId = 3, courseName = "Programming" },
            new Teacher{courseId = 3,courseName = "Mathematics"}
        };

        var joinTable = from teacher in teachers
            join course in courses
                on teacher.courseId equals course.courseId
            select new
            {
                teacherName = course.Name,
                courseName = teacher.courseName
            };

        foreach (var v in joinTable)
        {
            Console.Write("Teacher Name : "+v.teacherName);
            Console.Write("  Course Name : "+v.courseName);
            Console.WriteLine();
        }


    }
}

public class Course
{
    public int courseId;
    public string Name;
}

public class Teacher
{
    public string courseName;
    public int courseId;
}



    