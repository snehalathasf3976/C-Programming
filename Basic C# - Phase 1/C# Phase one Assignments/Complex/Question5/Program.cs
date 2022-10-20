using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First Date in dd/MM/yyyy format");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Second Date in dd/MM/yyyy Format");
        DateTime date2 = DateTime.Parse(Console.ReadLine() );
        TimeSpan difference = date1 - date2 ;
        System.Console.WriteLine("Difference Between Days is: "+difference.Days);
        System.Console.WriteLine("TimeSpan is: "+difference.ToString());
    }
}