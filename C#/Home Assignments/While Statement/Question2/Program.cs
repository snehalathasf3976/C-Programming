using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string condition = "YES";
        System.Console.WriteLine("Enter the Count Of the Input: ");
        int count = int.Parse(Console.ReadLine());
        while (condition == "YES")
        {
            System.Console.WriteLine("Enter the Numbers");
            int sum = 0;
            for(int i=1 ; i<=count ; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum = sum + (number*number);
            }
            System.Console.WriteLine("Sum Of Square of Numbers: "+sum);
            System.Console.WriteLine("Do you Want to Continue");
            condition=Console.ReadLine().ToUpper();
        }
    }
}