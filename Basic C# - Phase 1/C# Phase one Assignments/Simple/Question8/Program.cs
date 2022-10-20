using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Speed");
        int speed = int.Parse(Console.ReadLine());
        if(speed <= 10)
        {
            System.Console.WriteLine("Slow");
        }
        else if(speed >= 11 && speed <= 50)
        {
            System.Console.WriteLine("Average");
        }
        else if(speed >= 51 && speed <= 150)
        {
            System.Console.WriteLine("Fast");
        }
        else if(speed >= 151 && speed <= 1000)
        {
            System.Console.WriteLine("Ultra Fast");
        }
        else
        {
            System.Console.WriteLine("Extremely Fast");
        }
    }
}