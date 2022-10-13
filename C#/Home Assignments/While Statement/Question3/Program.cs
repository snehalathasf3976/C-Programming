using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of Terms: ");
        int terms = int.Parse(Console.ReadLine());
        int i=0 , temp = 0 , number = 1;
        if(terms>1)
        {
            System.Console.WriteLine("Here is the Fibonacci Series upto {0} Numbers \n0 \n1",terms);
            while(i<terms-2)
            {
                int sum = temp + number;
                temp = number;
                number = sum;
                System.Console.WriteLine(sum);
                i++;
            }
        }
        else if(terms==1)
        {
            System.Console.WriteLine("Here is the Fibonacci Series upto {0} Numbers \n0 ",terms);
        }
    }
}