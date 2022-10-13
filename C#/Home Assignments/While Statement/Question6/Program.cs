using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int number = 1;
        System.Console.WriteLine("The Even Numbers are");
        while(number<=100)
        {
            if(number%2==0)
            {
                System.Console.Write("\t"+number);
            }
            number++;
        }
        System.Console.WriteLine("\nThe Odd Numbers are");
        int number1=1;
        while(number1<=100)
        {
            if(number1%2==0)
            {
                System.Console.Write("\t"+number1);
            }
            number1++;
        }
        System.Console.WriteLine("\nthe Prime Numbers are: ");
        int number2=1;
        while(number2<=100)
        {
            for ( int i=number2 ; i<=number2 ; i++)
            {
                if(i%2 == 0)
                {
                    continue;
                }
                else
                {
                    System.Console.Write("\t"+number2);
                }
            }
            number2++;
        }

    }
}