using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        double number = double.Parse(Console.ReadLine());
        double cm = number*2.54;
        System.Console.WriteLine("In CentiMeter: "+cm);
    }
}