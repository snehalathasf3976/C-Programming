using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your Name");
        string name=Console.ReadLine();
        System.Console.WriteLine("Hello: " +name);
        System.Console.WriteLine("Hello: {0}",name);
        System.Console.WriteLine($"Hello: {name}");
    }
}