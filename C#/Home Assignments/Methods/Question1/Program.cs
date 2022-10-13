using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
            System.Console.WriteLine("Enter First Number");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Second Number");
            int number2 = int.Parse(Console.ReadLine());
            Addition(number1 , number2);
            Subraction(number1 , number2);
            Multiplication(number1 , number2);
            Division(number1 , number2);
            void Addition(int number1 , int number2)
            {
                int sum = number1 + number2;
                System.Console.WriteLine("Sum of Two Numbers is: "+sum);
            }
            void Subraction(int number1 , int number2)
            {
                int difference = number1 - number2;
                System.Console.WriteLine("Difference of Two Numbers is: "+difference);
            }
            void Multiplication(int number1 , int number2)
            {
                int product = number1 * number2;
                System.Console.WriteLine("Product of Two Numbers is: "+product);
            }
            void Division(int number1 , int number2)
            {
                int division = number1 / number2;
                System.Console.WriteLine("Division of Two Numbers is: "+division);
            }
    }
}