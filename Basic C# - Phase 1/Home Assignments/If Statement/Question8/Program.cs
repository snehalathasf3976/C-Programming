using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Sugar Level");
        int level = int.Parse (Console.ReadLine());
        if (level < 90)
        {
            System.Console.WriteLine("Low Sugar");
        }
        else if(level >= 90 && level < 130)
        {
            System.Console.WriteLine("Normal");
        }
        else if(level >= 130 && level < 140)
        {
            System.Console.WriteLine("Medium");
        }
        else if(level >= 140 && level < 170)
        {
            System.Console.WriteLine("High Sugar \nTry To Reduce it From Now On");
        }
        else
        {
            System.Console.WriteLine("Your are a Very High Sugar Patient ");
        }
    }
}