using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date Time in mm/dd/yyyy");
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy" , null);
        System.Console.WriteLine("Week is: "+date.DayOfWeek);
    }
}