using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Valid Input");
            bool temp = int.TryParse(Console.ReadLine(),out int number);
            while(!temp || (number<1 || number>5))
            {
                System.Console.WriteLine("Please Enter the Valid Number between 1-5");
                temp = int.TryParse(Console.ReadLine(),out number);
            }
            System.Console.WriteLine($"{number} is Valid Input");
        }
    }
}