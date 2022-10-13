using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse (Console.ReadLine());
        int count = 0;
        for (int i=2 ; i<number ; i++ )
        {
            if(number%i == 0)
            {
                count = count + 1;
            }
        }
        if ( count == 0)
        {
            System.Console.WriteLine("Its a Prime Number");
        }
        else
        {
            System.Console.WriteLine("Its Not a Prime Number");
        }
    }
}