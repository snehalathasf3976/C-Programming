using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Year: ");
        int year = int.Parse(Console.ReadLine());
        if (year%4 == 0)
        {
            System.Console.WriteLine("{0} is a Leap Year ",year );
        }
        else
        {
            System.Console.WriteLine("{0} is Not a Leap Year",year );
        }

    }
}
