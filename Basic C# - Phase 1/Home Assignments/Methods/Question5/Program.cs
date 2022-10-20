using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse(Console.ReadLine());
        Prime(number);
        void Prime(int number)
        {
            int count = 0;
            for ( int i=0 ; i<number ; i++)
            {
                if(number%2 == 0)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                System.Console.WriteLine("Its a Prime Number");
            }
            else
            {
                System.Console.WriteLine("Not a Prime Number");
            }
        }
    }
}