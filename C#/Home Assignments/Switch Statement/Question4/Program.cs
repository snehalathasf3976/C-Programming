using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your First Number");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Your Second Number");
        int number2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("1-Addition. \n2-Substraction. \n3-Multiplication. \n4-Division. \n5-Exit. \nEnter Your Option To Perform Operation");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine($"The Addition of {number1} and {number2} is {(number1 + number2)} ");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The Substraction of {number1} and {number2} is {(number1 - number2)} ");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The Multiplication of {number1} and {number2} is {(number1 * number2)} ");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"The Division of {number1} and {number2} is {(number1 + number2)} ");
                break;
            }
            case 5:
            {
                break;
            }
        }
    }
}