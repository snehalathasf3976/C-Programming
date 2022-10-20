using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse(Console.ReadLine());
        if(number < 100)
        {
            System.Console.WriteLine("Less than 100");
        }
        else if(number >= 100 && number < 200)
        {
            System.Console.WriteLine("Range Between 100 And 200");
        }
        else
        {
            System.Console.WriteLine("Greater than 200");
        }
    }
}