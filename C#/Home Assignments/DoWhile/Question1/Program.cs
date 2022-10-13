using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string condition = "";
    do
    {
        System.Console.WriteLine("Enter the number");
        int number = int.Parse(Console.ReadLine());
        if(number%2 == 0)
        {
            System.Console.WriteLine("Given Number is Even");
        }
        else
        {
            System.Console.WriteLine("Given Number is Odd");
        }
        System.Console.WriteLine("Do you Want to Continue");
        condition = Console.ReadLine().ToUpper();
    }while(condition == "YES");
    }
}