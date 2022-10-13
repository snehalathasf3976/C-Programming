using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Radius");
        float radius=float.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Height");
        int height=int.Parse(Console.ReadLine());
        float volume = (float)3.14 * radius * radius * height;
        System.Console.WriteLine("volume is: "+volume);
    }
    
}
