using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while(number>=1)
        {
            int digit = number%10;
            sum = sum + digit;
            number = number / 10;
        }
        System.Console.WriteLine("The Sum of Digitd is: "+sum);
    }
}