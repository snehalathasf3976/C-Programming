using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        double number = 0;
        for(int i=1 ; i<8 ; i++)
        {
            number =(double) number + (double) Power( i) / Factorial(i) ;
            
        }
        System.Console.WriteLine("Number is: "+number);
        int Factorial(int number)
        {
            int fact = 1;
            for(int i=1 ; i<number ; i++)
            {
                fact = fact * i ;
            }
            return fact ;
        }
        int Power(int number2)
        {
            int product = 1;
            for(int i=1 ; i<number2 ; i++)
            {
                product = product * 2;
            }
            return product;
        }
    }
}
        
