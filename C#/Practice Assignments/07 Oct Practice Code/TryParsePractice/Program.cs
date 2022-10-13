using System;
namespace TryParsePractice;
class Program
{
    public static void Main(string[] args)
    {
        //int number;
        System.Console.WriteLine("Enter the value");
        bool temp = int.TryParse(Console.ReadLine(),out int number);
        System.Console.WriteLine("the converted value is "+number);
        System.Console.WriteLine("Boolean = "+temp);
    }
}
