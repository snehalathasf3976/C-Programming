using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        System.Console.WriteLine("Enter the Sub String: ");
        string subString = Console.ReadLine();
        string[] final = mainString.Split(subString);
        System.Console.WriteLine(final.Length-1);
    }
}