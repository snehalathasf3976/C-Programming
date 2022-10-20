using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        //Even Number
        System.Console.WriteLine("Even Numbers are: 0 ");
        for (int i=1 ; i<25 ; i++)
        {
            if(i%2 == 0)
            {
                System.Console.WriteLine(i);
            }
        }

        //Exercise 2
        System.Console.WriteLine("Enter the Start Value: ");
        int start = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the End Value: ");
        int end = int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=start ; i<=end ; i++)
        {
            sum += (i*i);
        }
        System.Console.WriteLine("Sum of Square of Numbers in the Given Limit is: "+sum);
    }
}