using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month");
        string month = Console.ReadLine();
        month = month.ToUpper();
        if (month == "DECEMBER" || month == "FEBRUARY" || month == "JANUARY")
        {
            System.Console.WriteLine("Its Winter");
        }
        else if (month == "MARCH" || month == "APRIL" || month == "MAY")
        {
            System.Console.WriteLine("Its Spring");
        }
        else if (month == "JUNE" || month == "JULY" || month == "AUGUST")
        {
            System.Console.WriteLine("Its Summer");
        }
        else
        {
            System.Console.WriteLine("Its Rainfall");
        }
    }
}