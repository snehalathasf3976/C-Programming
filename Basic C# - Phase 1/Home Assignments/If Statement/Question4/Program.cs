using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First Number: ");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Second  Number: ");
        int number2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Third Number: ");
        int number3 = int.Parse(Console.ReadLine());
        if (number1 > number2 && number1 > number3)
        {
            System.Console.WriteLine("{0} is the Greatest among three Number ",number1 );
        }
        else if (number2 > number1 && number2 > number3)
        {
            System.Console.WriteLine("{0} is the Greatest among three Number ",number2 );
        }
        else
        {
            System.Console.WriteLine("{0} is the Greatest among three Number ",number3  );
        }

    }
}
