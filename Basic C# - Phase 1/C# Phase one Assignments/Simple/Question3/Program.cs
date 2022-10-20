using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Degree");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius*1.8+32;
        System.Console.WriteLine("Fahrenheit is: "+fahrenheit);
    }
}