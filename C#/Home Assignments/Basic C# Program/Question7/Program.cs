using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First Number");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Second Number");
        int number2=int.Parse(Console.ReadLine());
        int total = (number1 * number1) + (2 * number1 * number2) + (number2 * number2);
        System.Console.WriteLine("({0} + {1})^2 = {2}",number1,number2,total);
    }
}