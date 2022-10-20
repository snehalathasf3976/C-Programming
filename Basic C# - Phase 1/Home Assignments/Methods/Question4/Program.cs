using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number of Terms: ");
        int terms = int.Parse(Console.ReadLine());
        System.Console.Write("Fibonnacci Series is: \t0 \t1");
        Fibonnacci(terms);
        void Fibonnacci(int term)
        {
            int number1 = 0 , number2 = 1 , i=1;
            while(i<term-1)
            {
                int temp = number1 + number2;
                System.Console.Write("\t"+temp);
                number1 = number2;
                number2 = temp;
                i++;
            }
        }
    }
}