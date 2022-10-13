using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        if (number%2 == 0)
        {
            System.Console.WriteLine("{0} is an Even Number ",number );
        }
        else
        {
            System.Console.WriteLine("{0} is an Odd Number",number );
        }

    }
}