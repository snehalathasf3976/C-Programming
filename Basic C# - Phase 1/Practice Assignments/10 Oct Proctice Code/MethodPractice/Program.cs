using System;
namespace Program;
class Program
{
    public static void Main(string[] args)
    {
        //Method with Arguments With Return type
        int total = Addition(10,30);
        System.Console.WriteLine("Total is: "+total);

        //Methods With Arguments Without Return Type
        Subraction(56,34);

        //Method Without Arguments With Return Type
        int product = Multiplication();
        System.Console.WriteLine("The Product is: "+product);

        //Method Without Arguments Without Return Type
        Division();


        void Division()
        {
            System.Console.WriteLine("Enter a Number");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a Number");
            int number2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Division is: "+number1/number2);
        }

        int Multiplication()
        {
            System.Console.WriteLine("Enter a Number");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a Number");
            int number2 = int.Parse(Console.ReadLine());
            int product = number1 * number2;
            return product;
        }

        void Subraction(int number1 , int number2)
        {
            int difference = number1 - number2 ;
            System.Console.WriteLine("The Difference is: "+difference);
        }

        int Addition(int number1 , int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
    }
}