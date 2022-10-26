using System;
namespace ByType;
class Program
{
    static void Display(int number)
    {
        System.Console.WriteLine("Number is: "+number);
    }

    static void Display(string name)
    {
        System.Console.WriteLine("Name is: "+name);
    }

    public static void Main(string[] args)
    {
       Display(100); 
       Display("Sneha");
    }
}