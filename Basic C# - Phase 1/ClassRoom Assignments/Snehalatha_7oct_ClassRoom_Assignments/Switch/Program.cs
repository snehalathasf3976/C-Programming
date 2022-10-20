using System;
namespace Switch;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First Integer");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Second Integer");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Performs to be done Press: \n + for Addition \n - for Subraction \n * for Multiplication \n / for Division \n % for Modulus ");
        char choice = char.Parse(Console.ReadLine());
        switch(choice)
        {
            case '+':
            {
                System.Console.WriteLine("Addition of Number {0} and {1} is {2} ",number1,number2,(number1+number2));
                break;
            }
            case '-':
            {
                System.Console.WriteLine("Subraction of Number {0} and {1} is {2} ",number1,number2,(number1-number2));
                break;
            }
            case '*':
            {
                System.Console.WriteLine("Multiplication of Number {0} and {1} is {2} ",number1,number2,(number1*number2));
                break;
            }
            case '/':
            {
                System.Console.WriteLine("Division of Number {0} and {1} is {2} ",number1,number2,(number1/number2));
                break;
            }
            case '%':
            {
                System.Console.WriteLine("Modulus of Number {0} and {1} is {2} ",number1,number2,(number1%number2));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid Operator");
                break;
            }
        }
    }
}