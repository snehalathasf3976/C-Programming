using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        //double num = (double) 1+2+(2^2)/Factorial(2) * (2^3)/ Factorial(3) * (2^4)/Factorial(4) * (2^5)/Factorial(5) * (2^6)/Factorial(6) * (2^7) /Factorial(7) * (2^3) / (Factorial (8));
        double check =  (double) ( 2^3);
        //System.Console.WriteLine(check);
        //System.Console.WriteLine(num);
        double number = 1+2+(2*2);
        for(int i=2 ; i<8 ; i++)
        {
            System.Console.WriteLine(number);
            number = number / (Factorial(i) + Power( i+1));
            
        }
        number = number / Factorial(8);
        System.Console.WriteLine(number);
        int Factorial(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            else
            {
                return (number * Factorial(number - 1));
            }
        }
        int Power(int number2)
        {
            int product = 2;
            for(int i=1 ; i<number2 ; i++)
            {
                product = product * 2;
            }
            return product;
        }
    }
}
        
