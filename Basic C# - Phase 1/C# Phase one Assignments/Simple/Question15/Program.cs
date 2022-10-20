using System;
namespace Question15;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i=2 ; i<number ; i++)
        {
            if(number%i == 0)
            {
                count++;
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("Prime Number");
        }
        else
        {
            System.Console.WriteLine("Not a Prime Number");
        }
    }
}