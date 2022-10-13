using System;
namespace MethosAssignments;
class Program
{
    public static void Main(string[] args)
    {
        string condition = "";
        do
        {
            System.Console.WriteLine("Select the Operation to do \n1.Addition \n2.Subraction \n3.Multiplication \n4.Division");
            int choice = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter First Number");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Second Number");
            int number2 = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    Addition(number1 , number2);
                    break;
                }
                case 2:
                {
                    Subraction(number1 , number2);
                    break;
                }
                case 3:
                {
                    Multiplication(number1 , number2);
                    break;
                }
                case 4:
                {
                    Division(number1 , number2);
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Option");
                    break;
                }
            }
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
                System.Console.WriteLine("Sum of Two Numbers is: "+division);
            }
            System.Console.WriteLine("Do You Want to Continue");
            condition = Console.ReadLine().ToUpper();
        }while(condition == "YES");
    }
}