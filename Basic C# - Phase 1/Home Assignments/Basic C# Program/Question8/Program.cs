using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Length");
        int length = int.Parse (Console.ReadLine());
        int cm = length*100;
        System.Console.WriteLine("Given Length in CM is: "+cm);
        int mm = cm*10;
        System.Console.WriteLine("Given Length in MM is: "+mm);
        System.Console.WriteLine("Given Length in Inches is :" +(39.3 * length));
        System.Console.WriteLine("Given Length in Foot is: " +(12 * length));
        System.Console.WriteLine("Given Length in Miles is: " +(0.0006213715277778 * length));
    }
}