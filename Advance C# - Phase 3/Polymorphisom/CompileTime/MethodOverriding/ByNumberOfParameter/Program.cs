using System;
namespace ByNumberOfParameter;
class Program
{
    static void Display(int number)
    {
        System.Console.WriteLine("Parameter Value: "+number);
    }
    static void Display(int number1, int number2)
    {
        System.Console.WriteLine("Parameter Values Are: "+number1+" And "+number2);
    }
    
    
    
    public static void Main(string[] args)
    {
        Display(100);
        Display(200,10);
        
    }
}