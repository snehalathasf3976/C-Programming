using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number of Terms");
        int term = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i=1 ; i<=(term*2) ; i++)
        {
            if(i%2 == 0)
            {
                continue;
            }
            else
            {
                System.Console.WriteLine("The Odd Numbers are: "+i);
                sum = sum + i;
            }
        }
        System.Console.WriteLine("Sum of Odd Natural Numbers Upto {0} is: {1}",term,sum);
    }
}