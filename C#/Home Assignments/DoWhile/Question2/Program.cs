using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string condition = "";
        int sum = 0;
        do
        {
            System.Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());
            if(number > 0)
            {
                sum = sum + number;
            }
            System.Console.WriteLine("Do You Wanna Enter the Number to Add \nEnter Yes or No"); 
            condition = Console.ReadLine().ToUpper();
        } while (condition == "YES");
        System.Console.WriteLine("The Sum is: "+sum);
    }
}