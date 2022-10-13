using System;
namespace Switch;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Choice \n 1.Tea \n 2.Coffee \n 3.Milk");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    System.Console.WriteLine("Tae Selected");
                    break;
                }
            case 2:
                {
                    System.Console.WriteLine("Coffee Selected");
                    break;
                }
            case 3:
            {
                System.Console.WriteLine("Milk Selected");
                break;
            }
            default:
                {
                    System.Console.WriteLine("Invalid Input");
                    break;
                }
        }

        //Using Alphabet Char
        System.Console.WriteLine("Enter your Choice \n A.Tea \n B.Coffee \n C.Milk");
        char choice1 = char.Parse(Console.ReadLine().ToUpper());
        switch (choice1)
        {
            case 'A':
                {
                    System.Console.WriteLine("Tae Selected");
                    break;
                }
            case 'B':
                {
                    System.Console.WriteLine("Coffee Selected");
                    break;
                }
            case 'C':
            {
                System.Console.WriteLine("Milk Selected");
                break;
            }
            default:
                {
                    System.Console.WriteLine("Invalid Input");
                    break;
                }
        }
        

        //Switch with String
        System.Console.WriteLine("Enter your Choice \n Tea \n Coffee \n Milk");
        string choice2 = Console.ReadLine().ToUpper();
        switch (choice2)
        {
            case "TEA":
                {
                    System.Console.WriteLine("Tae Selected");
                    break;
                }
            case "COFFEE":
                {
                    System.Console.WriteLine("Coffee Selected");
                    break;
                }
            case "MILK":
            {
                System.Console.WriteLine("Milk Selected");
                break;
            }
            default:
                {
                    System.Console.WriteLine("Invalid Input");
                    break;
                }
        }
    }
}
