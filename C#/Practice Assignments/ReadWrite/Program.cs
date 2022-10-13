using System;
namespace ReadWrite;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter your Age");
        string age = Console.ReadLine();

        //Cancatenation - (Low perfomance)
        System.Console.WriteLine("My name is: "+name+ " and My Age is: " +age);

        //Placeholder - (Memory problem)
        System.Console.WriteLine("My Name is {0} and My Age is {1}",name,age);

        //Interpolation
        System.Console.WriteLine($"My Name is {name} and My Age is {age}");
    }
}
