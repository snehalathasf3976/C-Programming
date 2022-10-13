using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Rate");
        double rate = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Currency in USD is: "+(0.0122*rate));
        System.Console.WriteLine("Currency in USD is: "+(0.0127*rate));
        System.Console.WriteLine("Currency in USD is: "+(0.0879*rate));
    }
}