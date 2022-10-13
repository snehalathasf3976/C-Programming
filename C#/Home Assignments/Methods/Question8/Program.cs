using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        Get();
        void Get()
        {
            System.Console.WriteLine("Enter the Mark 1: ");
            int mark1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mark 2: ");
            int mark2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Mark 3: ");
            int mark3 = int.Parse(Console.ReadLine());
            Percentage(mark1 , mark2 , mark3);
        }
        void Percentage(int mark1, int mark2, int mark3)
        {
            int percentage = (mark1 + mark2 + mark3)* 100/300;
            System.Console.WriteLine(percentage);
        }
    }
}