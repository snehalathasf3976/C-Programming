using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse(Console.ReadLine());
        int fab = 1;
        while(number>=1)
        {
            fab = fab * number;
            number = Factorial(number);
        }
        System.Console.WriteLine("Factorial is: "+fab);
        int Factorial(int number)
        {
           return number-1;
        }
    }
}