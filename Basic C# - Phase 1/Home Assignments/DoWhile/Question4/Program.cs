using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        bool temp;
        int number;
        do
        {
            System.Console.WriteLine("Enter the Integer");
            temp = int.TryParse(Console.ReadLine(),out number);
            if (number<=1 || number>=10)
            {
                System.Console.WriteLine("Ivalid Integer!!! Enter the valid Integer");
            }
        } while (!temp || (number<=1 || number>=10));
        System.Console.WriteLine("Valid Input");
    }
}