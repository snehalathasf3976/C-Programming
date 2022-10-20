using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Speed");
        int speed=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Time");
        int time=int.Parse(Console.ReadLine());
        float distance = speed * time * 5/18 ;
        System.Console.WriteLine("Distance: "+distance);
    }
}