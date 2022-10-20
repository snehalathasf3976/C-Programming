using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse(Console.ReadLine());
        int temp = number;
        int sum = 0;
        for (int i=number ; number>0 ; i++)
        {
            int digit = number % 10;
            sum = sum + (digit * digit * digit);
            number = number/10;
        }
        if (temp == sum)
        {
            System.Console.WriteLine("The Given Number is Armstrong Number");
        }
        else
        {
         System.Console.WriteLine("The Given Number is Not a Armstrong Number");   
        }
    }
}