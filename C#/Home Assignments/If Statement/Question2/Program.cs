using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your Age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            System.Console.WriteLine("Congratulation!!!! \nYour Eligible for Voting" );
        }
        else
        {
            System.Console.WriteLine("Sorry!!! \nYour not Yet Eligible for Voting" );
        }

    }
}
