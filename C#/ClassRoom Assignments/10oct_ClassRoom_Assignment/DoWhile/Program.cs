using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
        string condition="YES";
        do
        {
            System.Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());
            if(number%2 == 0)
            {
                System.Console.WriteLine("Even Number");
            }
            else
            {
                System.Console.WriteLine("Odd Number");
            }
            System.Console.WriteLine("Do you Want to repeat the Process");     
            condition = Console.ReadLine().ToUpper();

            while( condition != "YES" && condition != "NO")
            {
                System.Console.WriteLine("Please Enter the Valid Input Yes or No");
                condition = Console.ReadLine().ToUpper();
            }
        }while(condition == "YES");
    }
}