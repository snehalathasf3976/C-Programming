using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        char[] separators = new char[] { ' ' };
        string[] subs = mainString.Split(separators, StringSplitOptions.None);
        System.Console.WriteLine(subs.Length);
    }
}