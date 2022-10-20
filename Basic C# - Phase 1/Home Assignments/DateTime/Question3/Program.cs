using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date Time in mm/dd/yyyy hh:mm:ss");
        DateTime date = DateTime.ParseExact(Console.ReadLine() , "MM/dd/yyyy hh:mm:ss",null);
        System.Console.WriteLine("Moth is: "+date.Month);
        System.Console.WriteLine("Date is: "+date.Day);
        System.Console.WriteLine("Year is: "+date.Year);
        System.Console.WriteLine("Hour is: "+date.Hour);
        System.Console.WriteLine("Minute is: "+date.Minute);
        System.Console.WriteLine("Second is: "+date.Second);
    }
}