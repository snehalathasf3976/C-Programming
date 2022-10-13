using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Amount of Celsious");
        int celsious= int.Parse(Console.ReadLine());
        double kelvin = (float) celsious + 273.15;
        int fahrenheit = (celsious * 9/5) + 32;
        System.Console.WriteLine("Fahrenheit: "+fahrenheit);
        System.Console.WriteLine("Kelvin: "+kelvin);
    }
}