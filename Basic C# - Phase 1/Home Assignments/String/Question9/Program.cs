using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String:");
        string string1 = Console.ReadLine();
        System.Console.WriteLine("Enter the SubString: ");
        string string2 = Console.ReadLine();
        if(string1.Contains(string2))
        {
            System.Console.WriteLine("The Substring Exist in the String");
        }
    }
}